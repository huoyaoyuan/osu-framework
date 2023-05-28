// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using Java.Interop;
using osu.Framework.Extensions.EnumExtensions;
using osu.Framework.Graphics.Rendering;
using osu.Framework.Graphics.Video;
using osu.Framework.Graphics.Video.FFmpeg;
using osu.Framework.Logging;

namespace osu.Framework.Android.Graphics.Video
{
    // ReSharper disable InconsistentNaming
    public unsafe class AndroidVideoDecoder : VideoDecoder
    {
        private const string lib_avcodec = "libavcodec.so";

        [DllImport(lib_avcodec)]
        private static extern int av_jni_set_java_vm(void* vm, void* logCtx);

        public AndroidVideoDecoder(IRenderer renderer, string filename)
            : base(renderer, filename)
        {
        }

        public AndroidVideoDecoder(IRenderer renderer, Stream videoStream)
            : base(renderer, videoStream)
        {
            // Hardware decoding with MediaCodec requires that we pass a Java VM pointer
            // to FFmpeg so that it can call the MediaCodec APIs through JNI (as they're Java only).

            int result = av_jni_set_java_vm(JniEnvironment.Runtime.InvocationPointer.ToPointer(), null);
            if (result < 0)
                throw new InvalidOperationException($"Couldn't pass Java VM handle to FFmpeg: ${result}");
        }

        protected override IEnumerable<(FFmpegCodec codec, AVHWDeviceType hwDeviceType)> GetAvailableDecoders(
            AVInputFormat* inputFormat,
            AVCodecID codecId,
            HardwareVideoDecoder targetHwDecoders
        )
        {
            if (targetHwDecoders.HasFlagFast(HardwareVideoDecoder.MediaCodec))
            {
                string? formatName = Marshal.PtrToStringAnsi((IntPtr)inputFormat->name);

                switch (formatName)
                {
                    // MediaCodec doesn't return correct timestamps when playing back AVI files
                    // which results in the video running at ~30% less FPS than it's supposed to.
                    case "avi":
                    {
                        Logger.Log($"Disabling HW decoding for this video because of unsupported input format: ${formatName}");
                        targetHwDecoders &= ~HardwareVideoDecoder.MediaCodec;
                        break;
                    }
                }
            }

            return base.GetAvailableDecoders(inputFormat, codecId, targetHwDecoders);
        }
    }
}
