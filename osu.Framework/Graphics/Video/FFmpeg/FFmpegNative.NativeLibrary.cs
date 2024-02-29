// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Loader;
using osu.Framework.Extensions.ObjectExtensions;
using osu.Framework.Platform.Linux.Native;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    public partial class FFmpegNative
    {
        static FFmpegNative()
        {
            if (OperatingSystem.IsLinux())
            {
                // P/Invoke loader doesn't load libraries as RTLD_GLOBAL, so we must load them ourselves to fix inter-library dependencies
                // otherwise they would fallback to the system-installed libraries that can differ in version installed.
                Library.Load("libavutil.so", Library.LoadFlags.RTLD_LAZY | Library.LoadFlags.RTLD_GLOBAL);
                Library.Load("libavcodec.so", Library.LoadFlags.RTLD_LAZY | Library.LoadFlags.RTLD_GLOBAL);
                Library.Load("libavformat.so", Library.LoadFlags.RTLD_LAZY | Library.LoadFlags.RTLD_GLOBAL);
                Library.Load("libswscale.so", Library.LoadFlags.RTLD_LAZY | Library.LoadFlags.RTLD_GLOBAL);
            }

            AssemblyLoadContext.GetLoadContext(typeof(FFmpegNative).Assembly).AsNonNull().ResolvingUnmanagedDll += static (assembly, name) =>
            {
                // Returning null instead of throwing allows subsequent handlers.

                if (!libraryVersionMap.TryGetValue(name, out int version))
                    return IntPtr.Zero;

                string libraryName;

                // "lib" prefix and extensions are resolved by .net core
                if (OperatingSystem.IsWindows())
                    libraryName = $"{name}-{version}";
                else if (OperatingSystem.IsMacOS())
                    libraryName = $"{name}.{version}";
                else
                    libraryName = name;

                return NativeLibrary.TryLoad(libraryName, System.Reflection.Assembly.GetEntryAssembly().AsNonNull(), DllImportSearchPath.UseDllDirectoryForDependencies | DllImportSearchPath.SafeDirectories, out IntPtr handle)
                    ? handle : IntPtr.Zero;
            };
        }

        // Keep in sync with file versions in NativeLibs!

        private static IReadOnlyDictionary<string, int> libraryVersionMap { get; } = new Dictionary<string, int>
        {
            ["avcodec"] = 58,
            ["avfilter"] = 7,
            ["avformat"] = 58,
            ["avutil"] = 56,
            ["swscale"] = 5
        };
    }
}
