// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Diagnostics;
using System.Reflection;

namespace osu.Framework
{
    public static class RuntimeInfo
    {
        /// <summary>
        /// The absolute path to the startup directory of this game.
        /// </summary>
        public static string StartupDirectory { get; } = AppContext.BaseDirectory;

        /// <summary>
        /// Returns the absolute path of osu.Framework.dll.
        /// </summary>
        public static string GetFrameworkAssemblyPath()
        {
            var assembly = Assembly.GetAssembly(typeof(RuntimeInfo));
            Debug.Assert(assembly != null);

            return assembly.Location;
        }

        public static Platform OS
        {
            get
            {
                if (OperatingSystem.IsWindows())
                    return Platform.Windows;
                if (OperatingSystem.IsIOS())
                    return Platform.iOS;
                if (OperatingSystem.IsAndroid())
                    return Platform.Android;
                if (OperatingSystem.IsMacOS())
                    return Platform.macOS;
                if (OperatingSystem.IsLinux())
                    return Platform.Linux;

                throw new PlatformNotSupportedException("Operating system could not be detected correctly.");
            }
        }

        public static bool IsUnix => !OperatingSystem.IsWindows();
        public static bool IsDesktop => OperatingSystem.IsLinux() || OperatingSystem.IsMacOS() || OperatingSystem.IsWindows();
        public static bool IsMobile => OperatingSystem.IsIOS() || OperatingSystem.IsAndroid();
        public static bool IsApple => OperatingSystem.IsIOS() || OperatingSystem.IsMacOS();

        public enum Platform
        {
            Windows = 1,
            Linux = 2,
            macOS = 3,
            iOS = 4,
            Android = 5
        }
    }
}
