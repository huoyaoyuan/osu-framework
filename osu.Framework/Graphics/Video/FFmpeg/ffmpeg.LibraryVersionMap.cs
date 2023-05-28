// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    public static partial class ffmpeg
    {
        // Keep in sync with file versions in NativeLibs!

        public static IReadOnlyDictionary<string, int> LibraryVersionMap { get; } = new Dictionary<string, int>
        {
            ["avcodec"] = 58,
            ["avfilter"] = 7,
            ["avformat"] = 58,
            ["avutil"] = 56,
            ["swscale"] = 5
        };
    }
}
