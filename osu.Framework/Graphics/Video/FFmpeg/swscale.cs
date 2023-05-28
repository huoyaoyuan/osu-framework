// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming style
#pragma warning disable IDE0027 // Use expression-body

using System;
using System.Runtime.InteropServices;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    public unsafe partial struct SwsVector
    {
        public double* coeff;

        public int length;
    }

    public unsafe partial struct SwsFilter
    {
        public SwsVector* lumH;

        public SwsVector* lumV;

        public SwsVector* chrH;

        public SwsVector* chrV;
    }

    public partial struct SwsContext
    {
    }

    public static unsafe partial class ffmpeg
    {
        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint swscale_version();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* swscale_configuration();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* swscale_license();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const int *")]
        public static extern int* sws_getCoefficients(int colorspace);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedInput([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedOutput([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_isSupportedEndiannessConversion([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct SwsContext *")]
        public static extern SwsContext* sws_alloc_context();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_init_context([NativeTypeName("struct SwsContext *")] SwsContext* sws_context, SwsFilter* srcFilter, SwsFilter* dstFilter);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeContext([NativeTypeName("struct SwsContext *")] SwsContext* swsContext);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct SwsContext *")]
        public static extern SwsContext* sws_getContext(int srcW, int srcH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat srcFormat, int dstW, int dstH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, [NativeTypeName("const double *")] double* param9);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_scale([NativeTypeName("struct SwsContext *")] SwsContext* c, [NativeTypeName("const uint8_t *const[]")] byte** srcSlice, [NativeTypeName("const int[]")] int* srcStride, int srcSliceY, int srcSliceH, [NativeTypeName("uint8_t *const[]")] byte** dst, [NativeTypeName("const int[]")] int* dstStride);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_setColorspaceDetails([NativeTypeName("struct SwsContext *")] SwsContext* c, [NativeTypeName("const int[4]")] int* inv_table, int srcRange, [NativeTypeName("const int[4]")] int* table, int dstRange, int brightness, int contrast, int saturation);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int sws_getColorspaceDetails([NativeTypeName("struct SwsContext *")] SwsContext* c, int** inv_table, int* srcRange, int** table, int* dstRange, int* brightness, int* contrast, int* saturation);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsVector* sws_allocVec(int length);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsVector* sws_getGaussianVec(double variance, double quality);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_scaleVec(SwsVector* a, double scalar);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_normalizeVec(SwsVector* a, double height);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern SwsVector* sws_getConstVec(double c, int length);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern SwsVector* sws_getIdentityVec();

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void sws_convVec(SwsVector* a, SwsVector* b);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void sws_addVec(SwsVector* a, SwsVector* b);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void sws_subVec(SwsVector* a, SwsVector* b);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void sws_shiftVec(SwsVector* a, int shift);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern SwsVector* sws_cloneVec(SwsVector* a);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void sws_printVec2(SwsVector* a, AVClass* log_ctx, int log_level);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeVec(SwsVector* a);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SwsFilter* sws_getDefaultFilter(float lumaGBlur, float chromaGBlur, float lumaSharpen, float chromaSharpen, float chromaHShift, float chromaVShift, int verbose);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_freeFilter(SwsFilter* filter);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct SwsContext *")]
        public static extern SwsContext* sws_getCachedContext([NativeTypeName("struct SwsContext *")] SwsContext* context, int srcW, int srcH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat srcFormat, int dstW, int dstH, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dstFormat, int flags, SwsFilter* srcFilter, SwsFilter* dstFilter, [NativeTypeName("const double *")] double* param10);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_convertPalette8ToPacked32([NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("uint8_t *")] byte* dst, int num_pixels, [NativeTypeName("const uint8_t *")] byte* palette);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void sws_convertPalette8ToPacked24([NativeTypeName("const uint8_t *")] byte* src, [NativeTypeName("uint8_t *")] byte* dst, int num_pixels, [NativeTypeName("const uint8_t *")] byte* palette);

        [DllImport("swscale", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* sws_get_class();
    }
}
