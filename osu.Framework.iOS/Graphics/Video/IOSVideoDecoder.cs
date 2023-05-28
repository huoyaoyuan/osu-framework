// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using System.IO;
using osu.Framework.Graphics.Rendering;
using osu.Framework.Graphics.Video;

namespace osu.Framework.iOS.Graphics.Video
{
    public unsafe class IOSVideoDecoder : VideoDecoder
    {
        public IOSVideoDecoder(IRenderer renderer, string filename)
            : base(renderer, filename)
        {
        }

        public IOSVideoDecoder(IRenderer renderer, Stream videoStream)
            : base(renderer, videoStream)
        {
        }
    }
}
