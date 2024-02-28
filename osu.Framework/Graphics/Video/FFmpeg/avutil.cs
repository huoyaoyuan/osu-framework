// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming style

using System;
using System.Runtime.InteropServices;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    internal enum AVMediaType
    {
        AVMEDIA_TYPE_UNKNOWN = -1,
        AVMEDIA_TYPE_VIDEO,
        AVMEDIA_TYPE_AUDIO,
        AVMEDIA_TYPE_DATA,
        AVMEDIA_TYPE_SUBTITLE,
        AVMEDIA_TYPE_ATTACHMENT,
        AVMEDIA_TYPE_NB,
    }

    internal enum AVPictureType
    {
        AV_PICTURE_TYPE_NONE = 0,
        AV_PICTURE_TYPE_I,
        AV_PICTURE_TYPE_P,
        AV_PICTURE_TYPE_B,
        AV_PICTURE_TYPE_S,
        AV_PICTURE_TYPE_SI,
        AV_PICTURE_TYPE_SP,
        AV_PICTURE_TYPE_BI,
    }

    internal partial struct AVBuffer
    {
    }

    internal unsafe partial struct AVBufferRef
    {
        public AVBuffer* buffer;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;
    }

    internal partial struct AVBufferPool
    {
    }

    internal unsafe partial struct AVDictionaryEntry
    {
        [NativeTypeName("char *")]
        public sbyte* key;

        [NativeTypeName("char *")]
        public sbyte* value;
    }

    internal partial struct AVDictionary
    {
    }

    internal enum AVFrameSideDataType
    {
        AV_FRAME_DATA_PANSCAN,
        AV_FRAME_DATA_A53_CC,
        AV_FRAME_DATA_STEREO3D,
        AV_FRAME_DATA_MATRIXENCODING,
        AV_FRAME_DATA_DOWNMIX_INFO,
        AV_FRAME_DATA_REPLAYGAIN,
        AV_FRAME_DATA_DISPLAYMATRIX,
        AV_FRAME_DATA_AFD,
        AV_FRAME_DATA_MOTION_VECTORS,
        AV_FRAME_DATA_SKIP_SAMPLES,
        AV_FRAME_DATA_AUDIO_SERVICE_TYPE,
        AV_FRAME_DATA_MASTERING_DISPLAY_METADATA,
        AV_FRAME_DATA_GOP_TIMECODE,
        AV_FRAME_DATA_SPHERICAL,
        AV_FRAME_DATA_CONTENT_LIGHT_LEVEL,
        AV_FRAME_DATA_ICC_PROFILE,
        AV_FRAME_DATA_QP_TABLE_PROPERTIES,
        AV_FRAME_DATA_QP_TABLE_DATA,
        AV_FRAME_DATA_S12M_TIMECODE,
        AV_FRAME_DATA_DYNAMIC_HDR_PLUS,
        AV_FRAME_DATA_REGIONS_OF_INTEREST,
        AV_FRAME_DATA_VIDEO_ENC_PARAMS,
    }

    internal enum AVActiveFormatDescription
    {
        AV_AFD_SAME = 8,
        AV_AFD_4_3 = 9,
        AV_AFD_16_9 = 10,
        AV_AFD_14_9 = 11,
        AV_AFD_4_3_SP_14_9 = 13,
        AV_AFD_16_9_SP_14_9 = 14,
        AV_AFD_SP_4_3 = 15,
    }

    internal unsafe partial struct AVFrameSideData
    {
        [NativeTypeName("enum AVFrameSideDataType")]
        public AVFrameSideDataType type;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;

        public AVDictionary* metadata;

        public AVBufferRef* buf;
    }

    internal partial struct AVRegionOfInterest
    {
        [NativeTypeName("uint32_t")]
        public uint self_size;

        public int top;

        public int bottom;

        public int left;

        public int right;

        public AVRational qoffset;
    }

    internal unsafe partial struct AVFrame
    {
        [NativeTypeName("uint8_t *[8]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[8]")]
        public fixed int linesize[8];

        [NativeTypeName("uint8_t **")]
        public byte** extended_data;

        public int width;

        public int height;

        public int nb_samples;

        public int format;

        public int key_frame;

        [NativeTypeName("enum AVPictureType")]
        public AVPictureType pict_type;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long pkt_pts;

        [NativeTypeName("int64_t")]
        public long pkt_dts;

        public int coded_picture_number;

        public int display_picture_number;

        public int quality;

        public void* opaque;

        [NativeTypeName("uint64_t[8]")]
        [Obsolete]
        public fixed ulong error[8];

        public int repeat_pict;

        public int interlaced_frame;

        public int top_field_first;

        public int palette_has_changed;

        [NativeTypeName("int64_t")]
        public long reordered_opaque;

        public int sample_rate;

        [NativeTypeName("uint64_t")]
        public ulong channel_layout;

        [NativeTypeName("AVBufferRef *[8]")]
        public _buf_e__FixedBuffer buf;

        public AVBufferRef** extended_buf;

        public int nb_extended_buf;

        public AVFrameSideData** side_data;

        public int nb_side_data;

        public int flags;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        [NativeTypeName("int64_t")]
        public long best_effort_timestamp;

        [NativeTypeName("int64_t")]
        public long pkt_pos;

        [NativeTypeName("int64_t")]
        public long pkt_duration;

        public AVDictionary* metadata;

        public int decode_error_flags;

        public int channels;

        public int pkt_size;

        [NativeTypeName("int8_t *")]
        [Obsolete]
        public sbyte* qscale_table;

        [Obsolete]
        public int qstride;

        [Obsolete]
        public int qscale_type;

        [Obsolete]
        public AVBufferRef* qp_table_buf;

        public AVBufferRef* hw_frames_ctx;

        public AVBufferRef* opaque_ref;

        [NativeTypeName("size_t")]
        public nuint crop_top;

        [NativeTypeName("size_t")]
        public nuint crop_bottom;

        [NativeTypeName("size_t")]
        public nuint crop_left;

        [NativeTypeName("size_t")]
        public nuint crop_right;

        public AVBufferRef* private_ref;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;
            public byte* e4;
            public byte* e5;
            public byte* e6;
            public byte* e7;

            public ref byte* this[int index]
            {
                get
                {
                    fixed (byte** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }

        public unsafe partial struct _buf_e__FixedBuffer
        {
            public AVBufferRef* e0;
            public AVBufferRef* e1;
            public AVBufferRef* e2;
            public AVBufferRef* e3;
            public AVBufferRef* e4;
            public AVBufferRef* e5;
            public AVBufferRef* e6;
            public AVBufferRef* e7;

            public ref AVBufferRef* this[int index]
            {
                get
                {
                    fixed (AVBufferRef** pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    internal enum AVPixelFormat
    {
        AV_PIX_FMT_NONE = -1,
        AV_PIX_FMT_YUV420P,
        AV_PIX_FMT_YUYV422,
        AV_PIX_FMT_RGB24,
        AV_PIX_FMT_BGR24,
        AV_PIX_FMT_YUV422P,
        AV_PIX_FMT_YUV444P,
        AV_PIX_FMT_YUV410P,
        AV_PIX_FMT_YUV411P,
        AV_PIX_FMT_GRAY8,
        AV_PIX_FMT_MONOWHITE,
        AV_PIX_FMT_MONOBLACK,
        AV_PIX_FMT_PAL8,
        AV_PIX_FMT_YUVJ420P,
        AV_PIX_FMT_YUVJ422P,
        AV_PIX_FMT_YUVJ444P,
        AV_PIX_FMT_UYVY422,
        AV_PIX_FMT_UYYVYY411,
        AV_PIX_FMT_BGR8,
        AV_PIX_FMT_BGR4,
        AV_PIX_FMT_BGR4_BYTE,
        AV_PIX_FMT_RGB8,
        AV_PIX_FMT_RGB4,
        AV_PIX_FMT_RGB4_BYTE,
        AV_PIX_FMT_NV12,
        AV_PIX_FMT_NV21,
        AV_PIX_FMT_ARGB,
        AV_PIX_FMT_RGBA,
        AV_PIX_FMT_ABGR,
        AV_PIX_FMT_BGRA,
        AV_PIX_FMT_GRAY16BE,
        AV_PIX_FMT_GRAY16LE,
        AV_PIX_FMT_YUV440P,
        AV_PIX_FMT_YUVJ440P,
        AV_PIX_FMT_YUVA420P,
        AV_PIX_FMT_RGB48BE,
        AV_PIX_FMT_RGB48LE,
        AV_PIX_FMT_RGB565BE,
        AV_PIX_FMT_RGB565LE,
        AV_PIX_FMT_RGB555BE,
        AV_PIX_FMT_RGB555LE,
        AV_PIX_FMT_BGR565BE,
        AV_PIX_FMT_BGR565LE,
        AV_PIX_FMT_BGR555BE,
        AV_PIX_FMT_BGR555LE,
        AV_PIX_FMT_VAAPI_MOCO,
        AV_PIX_FMT_VAAPI_IDCT,
        AV_PIX_FMT_VAAPI_VLD,
        AV_PIX_FMT_VAAPI = AV_PIX_FMT_VAAPI_VLD,
        AV_PIX_FMT_YUV420P16LE,
        AV_PIX_FMT_YUV420P16BE,
        AV_PIX_FMT_YUV422P16LE,
        AV_PIX_FMT_YUV422P16BE,
        AV_PIX_FMT_YUV444P16LE,
        AV_PIX_FMT_YUV444P16BE,
        AV_PIX_FMT_DXVA2_VLD,
        AV_PIX_FMT_RGB444LE,
        AV_PIX_FMT_RGB444BE,
        AV_PIX_FMT_BGR444LE,
        AV_PIX_FMT_BGR444BE,
        AV_PIX_FMT_YA8,
        AV_PIX_FMT_Y400A = AV_PIX_FMT_YA8,
        AV_PIX_FMT_GRAY8A = AV_PIX_FMT_YA8,
        AV_PIX_FMT_BGR48BE,
        AV_PIX_FMT_BGR48LE,
        AV_PIX_FMT_YUV420P9BE,
        AV_PIX_FMT_YUV420P9LE,
        AV_PIX_FMT_YUV420P10BE,
        AV_PIX_FMT_YUV420P10LE,
        AV_PIX_FMT_YUV422P10BE,
        AV_PIX_FMT_YUV422P10LE,
        AV_PIX_FMT_YUV444P9BE,
        AV_PIX_FMT_YUV444P9LE,
        AV_PIX_FMT_YUV444P10BE,
        AV_PIX_FMT_YUV444P10LE,
        AV_PIX_FMT_YUV422P9BE,
        AV_PIX_FMT_YUV422P9LE,
        AV_PIX_FMT_GBRP,
        AV_PIX_FMT_GBR24P = AV_PIX_FMT_GBRP,
        AV_PIX_FMT_GBRP9BE,
        AV_PIX_FMT_GBRP9LE,
        AV_PIX_FMT_GBRP10BE,
        AV_PIX_FMT_GBRP10LE,
        AV_PIX_FMT_GBRP16BE,
        AV_PIX_FMT_GBRP16LE,
        AV_PIX_FMT_YUVA422P,
        AV_PIX_FMT_YUVA444P,
        AV_PIX_FMT_YUVA420P9BE,
        AV_PIX_FMT_YUVA420P9LE,
        AV_PIX_FMT_YUVA422P9BE,
        AV_PIX_FMT_YUVA422P9LE,
        AV_PIX_FMT_YUVA444P9BE,
        AV_PIX_FMT_YUVA444P9LE,
        AV_PIX_FMT_YUVA420P10BE,
        AV_PIX_FMT_YUVA420P10LE,
        AV_PIX_FMT_YUVA422P10BE,
        AV_PIX_FMT_YUVA422P10LE,
        AV_PIX_FMT_YUVA444P10BE,
        AV_PIX_FMT_YUVA444P10LE,
        AV_PIX_FMT_YUVA420P16BE,
        AV_PIX_FMT_YUVA420P16LE,
        AV_PIX_FMT_YUVA422P16BE,
        AV_PIX_FMT_YUVA422P16LE,
        AV_PIX_FMT_YUVA444P16BE,
        AV_PIX_FMT_YUVA444P16LE,
        AV_PIX_FMT_VDPAU,
        AV_PIX_FMT_XYZ12LE,
        AV_PIX_FMT_XYZ12BE,
        AV_PIX_FMT_NV16,
        AV_PIX_FMT_NV20LE,
        AV_PIX_FMT_NV20BE,
        AV_PIX_FMT_RGBA64BE,
        AV_PIX_FMT_RGBA64LE,
        AV_PIX_FMT_BGRA64BE,
        AV_PIX_FMT_BGRA64LE,
        AV_PIX_FMT_YVYU422,
        AV_PIX_FMT_YA16BE,
        AV_PIX_FMT_YA16LE,
        AV_PIX_FMT_GBRAP,
        AV_PIX_FMT_GBRAP16BE,
        AV_PIX_FMT_GBRAP16LE,
        AV_PIX_FMT_QSV,
        AV_PIX_FMT_MMAL,
        AV_PIX_FMT_D3D11VA_VLD,
        AV_PIX_FMT_CUDA,
        AV_PIX_FMT_0RGB,
        AV_PIX_FMT_RGB0,
        AV_PIX_FMT_0BGR,
        AV_PIX_FMT_BGR0,
        AV_PIX_FMT_YUV420P12BE,
        AV_PIX_FMT_YUV420P12LE,
        AV_PIX_FMT_YUV420P14BE,
        AV_PIX_FMT_YUV420P14LE,
        AV_PIX_FMT_YUV422P12BE,
        AV_PIX_FMT_YUV422P12LE,
        AV_PIX_FMT_YUV422P14BE,
        AV_PIX_FMT_YUV422P14LE,
        AV_PIX_FMT_YUV444P12BE,
        AV_PIX_FMT_YUV444P12LE,
        AV_PIX_FMT_YUV444P14BE,
        AV_PIX_FMT_YUV444P14LE,
        AV_PIX_FMT_GBRP12BE,
        AV_PIX_FMT_GBRP12LE,
        AV_PIX_FMT_GBRP14BE,
        AV_PIX_FMT_GBRP14LE,
        AV_PIX_FMT_YUVJ411P,
        AV_PIX_FMT_BAYER_BGGR8,
        AV_PIX_FMT_BAYER_RGGB8,
        AV_PIX_FMT_BAYER_GBRG8,
        AV_PIX_FMT_BAYER_GRBG8,
        AV_PIX_FMT_BAYER_BGGR16LE,
        AV_PIX_FMT_BAYER_BGGR16BE,
        AV_PIX_FMT_BAYER_RGGB16LE,
        AV_PIX_FMT_BAYER_RGGB16BE,
        AV_PIX_FMT_BAYER_GBRG16LE,
        AV_PIX_FMT_BAYER_GBRG16BE,
        AV_PIX_FMT_BAYER_GRBG16LE,
        AV_PIX_FMT_BAYER_GRBG16BE,
        AV_PIX_FMT_XVMC,
        AV_PIX_FMT_YUV440P10LE,
        AV_PIX_FMT_YUV440P10BE,
        AV_PIX_FMT_YUV440P12LE,
        AV_PIX_FMT_YUV440P12BE,
        AV_PIX_FMT_AYUV64LE,
        AV_PIX_FMT_AYUV64BE,
        AV_PIX_FMT_VIDEOTOOLBOX,
        AV_PIX_FMT_P010LE,
        AV_PIX_FMT_P010BE,
        AV_PIX_FMT_GBRAP12BE,
        AV_PIX_FMT_GBRAP12LE,
        AV_PIX_FMT_GBRAP10BE,
        AV_PIX_FMT_GBRAP10LE,
        AV_PIX_FMT_MEDIACODEC,
        AV_PIX_FMT_GRAY12BE,
        AV_PIX_FMT_GRAY12LE,
        AV_PIX_FMT_GRAY10BE,
        AV_PIX_FMT_GRAY10LE,
        AV_PIX_FMT_P016LE,
        AV_PIX_FMT_P016BE,
        AV_PIX_FMT_D3D11,
        AV_PIX_FMT_GRAY9BE,
        AV_PIX_FMT_GRAY9LE,
        AV_PIX_FMT_GBRPF32BE,
        AV_PIX_FMT_GBRPF32LE,
        AV_PIX_FMT_GBRAPF32BE,
        AV_PIX_FMT_GBRAPF32LE,
        AV_PIX_FMT_DRM_PRIME,
        AV_PIX_FMT_OPENCL,
        AV_PIX_FMT_GRAY14BE,
        AV_PIX_FMT_GRAY14LE,
        AV_PIX_FMT_GRAYF32BE,
        AV_PIX_FMT_GRAYF32LE,
        AV_PIX_FMT_YUVA422P12BE,
        AV_PIX_FMT_YUVA422P12LE,
        AV_PIX_FMT_YUVA444P12BE,
        AV_PIX_FMT_YUVA444P12LE,
        AV_PIX_FMT_NV24,
        AV_PIX_FMT_NV42,
        AV_PIX_FMT_VULKAN,
        AV_PIX_FMT_Y210BE,
        AV_PIX_FMT_Y210LE,
        AV_PIX_FMT_NB,
    }

    internal enum AVColorPrimaries
    {
        AVCOL_PRI_RESERVED0 = 0,
        AVCOL_PRI_BT709 = 1,
        AVCOL_PRI_UNSPECIFIED = 2,
        AVCOL_PRI_RESERVED = 3,
        AVCOL_PRI_BT470M = 4,
        AVCOL_PRI_BT470BG = 5,
        AVCOL_PRI_SMPTE170M = 6,
        AVCOL_PRI_SMPTE240M = 7,
        AVCOL_PRI_FILM = 8,
        AVCOL_PRI_BT2020 = 9,
        AVCOL_PRI_SMPTE428 = 10,
        AVCOL_PRI_SMPTEST428_1 = AVCOL_PRI_SMPTE428,
        AVCOL_PRI_SMPTE431 = 11,
        AVCOL_PRI_SMPTE432 = 12,
        AVCOL_PRI_EBU3213 = 22,
        AVCOL_PRI_JEDEC_P22 = AVCOL_PRI_EBU3213,
        AVCOL_PRI_NB,
    }

    internal enum AVColorTransferCharacteristic
    {
        AVCOL_TRC_RESERVED0 = 0,
        AVCOL_TRC_BT709 = 1,
        AVCOL_TRC_UNSPECIFIED = 2,
        AVCOL_TRC_RESERVED = 3,
        AVCOL_TRC_GAMMA22 = 4,
        AVCOL_TRC_GAMMA28 = 5,
        AVCOL_TRC_SMPTE170M = 6,
        AVCOL_TRC_SMPTE240M = 7,
        AVCOL_TRC_LINEAR = 8,
        AVCOL_TRC_LOG = 9,
        AVCOL_TRC_LOG_SQRT = 10,
        AVCOL_TRC_IEC61966_2_4 = 11,
        AVCOL_TRC_BT1361_ECG = 12,
        AVCOL_TRC_IEC61966_2_1 = 13,
        AVCOL_TRC_BT2020_10 = 14,
        AVCOL_TRC_BT2020_12 = 15,
        AVCOL_TRC_SMPTE2084 = 16,
        AVCOL_TRC_SMPTEST2084 = AVCOL_TRC_SMPTE2084,
        AVCOL_TRC_SMPTE428 = 17,
        AVCOL_TRC_SMPTEST428_1 = AVCOL_TRC_SMPTE428,
        AVCOL_TRC_ARIB_STD_B67 = 18,
        AVCOL_TRC_NB,
    }

    internal enum AVColorSpace
    {
        AVCOL_SPC_RGB = 0,
        AVCOL_SPC_BT709 = 1,
        AVCOL_SPC_UNSPECIFIED = 2,
        AVCOL_SPC_RESERVED = 3,
        AVCOL_SPC_FCC = 4,
        AVCOL_SPC_BT470BG = 5,
        AVCOL_SPC_SMPTE170M = 6,
        AVCOL_SPC_SMPTE240M = 7,
        AVCOL_SPC_YCGCO = 8,
        AVCOL_SPC_YCOCG = AVCOL_SPC_YCGCO,
        AVCOL_SPC_BT2020_NCL = 9,
        AVCOL_SPC_BT2020_CL = 10,
        AVCOL_SPC_SMPTE2085 = 11,
        AVCOL_SPC_CHROMA_DERIVED_NCL = 12,
        AVCOL_SPC_CHROMA_DERIVED_CL = 13,
        AVCOL_SPC_ICTCP = 14,
        AVCOL_SPC_NB,
    }

    internal enum AVColorRange
    {
        AVCOL_RANGE_UNSPECIFIED = 0,
        AVCOL_RANGE_MPEG = 1,
        AVCOL_RANGE_JPEG = 2,
        AVCOL_RANGE_NB,
    }

    internal enum AVChromaLocation
    {
        AVCHROMA_LOC_UNSPECIFIED = 0,
        AVCHROMA_LOC_LEFT = 1,
        AVCHROMA_LOC_CENTER = 2,
        AVCHROMA_LOC_TOPLEFT = 3,
        AVCHROMA_LOC_TOP = 4,
        AVCHROMA_LOC_BOTTOMLEFT = 5,
        AVCHROMA_LOC_BOTTOM = 6,
        AVCHROMA_LOC_NB,
    }

    internal partial struct AVRational
    {
        public int num;

        public int den;
    }

    internal static unsafe partial class FFmpegNative
    {
        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avutil_version();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_version_info();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avutil_configuration();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avutil_license();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_media_type_string([NativeTypeName("enum AVMediaType")] AVMediaType media_type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char")]
        public static extern sbyte av_get_picture_type_char([NativeTypeName("enum AVPictureType")] AVPictureType pict_type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint av_int_list_length_for_size([NativeTypeName("unsigned int")] uint elsize, [NativeTypeName("const void *")] void* list, [NativeTypeName("uint64_t")] ulong term);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_get_time_base_q();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* av_fourcc_make_string([NativeTypeName("char *")] sbyte* buf, [NativeTypeName("uint32_t")] uint fourcc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_alloc(int size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_allocz(int size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_create([NativeTypeName("uint8_t *")] byte* data, int size, [NativeTypeName("void (*)(void *, uint8_t *)")] delegate* unmanaged[Cdecl]<void*, byte*, void> free, void* opaque, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_default_free(void* opaque, [NativeTypeName("uint8_t *")] byte* data);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_ref(AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_unref(AVBufferRef** buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_is_writable([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_buffer_get_opaque([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_get_ref_count([NativeTypeName("const AVBufferRef *")] AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_make_writable(AVBufferRef** buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_buffer_realloc(AVBufferRef** buf, int size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferPool* av_buffer_pool_init(int size, [NativeTypeName("AVBufferRef *(*)(int)")] delegate* unmanaged[Cdecl]<int, AVBufferRef*> alloc);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferPool* av_buffer_pool_init2(int size, void* opaque, [NativeTypeName("AVBufferRef *(*)(void *, int)")] delegate* unmanaged[Cdecl]<void*, int, AVBufferRef*> alloc, [NativeTypeName("void (*)(void *)")] delegate* unmanaged[Cdecl]<void*, void> pool_free);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_buffer_pool_uninit(AVBufferPool** pool);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_buffer_pool_get(AVBufferPool* pool);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* av_buffer_pool_buffer_get_opaque(AVBufferRef* @ref);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVDictionaryEntry* av_dict_get([NativeTypeName("const AVDictionary *")] AVDictionary* m, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const AVDictionaryEntry *")] AVDictionaryEntry* prev, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_count([NativeTypeName("const AVDictionary *")] AVDictionary* m);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_set(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("const char *")] sbyte* value, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_set_int(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* key, [NativeTypeName("int64_t")] long value, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_parse_string(AVDictionary** pm, [NativeTypeName("const char *")] sbyte* str, [NativeTypeName("const char *")] sbyte* key_val_sep, [NativeTypeName("const char *")] sbyte* pairs_sep, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_copy(AVDictionary** dst, [NativeTypeName("const AVDictionary *")] AVDictionary* src, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_dict_free(AVDictionary** m);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_dict_get_string([NativeTypeName("const AVDictionary *")] AVDictionary* m, [NativeTypeName("char **")] sbyte** buffer, [NativeTypeName("const char")] sbyte key_val_sep, [NativeTypeName("const char")] sbyte pairs_sep);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        [Obsolete]
        public static extern long av_frame_get_best_effort_timestamp([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_best_effort_timestamp(AVFrame* frame, [NativeTypeName("int64_t")] long val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        [Obsolete]
        public static extern long av_frame_get_pkt_duration([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_pkt_duration(AVFrame* frame, [NativeTypeName("int64_t")] long val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        [Obsolete]
        public static extern long av_frame_get_pkt_pos([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_pkt_pos(AVFrame* frame, [NativeTypeName("int64_t")] long val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        [Obsolete]
        public static extern long av_frame_get_channel_layout([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_channel_layout(AVFrame* frame, [NativeTypeName("int64_t")] long val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_frame_get_channels([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_channels(AVFrame* frame, int val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_frame_get_sample_rate([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_sample_rate(AVFrame* frame, int val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVDictionary* av_frame_get_metadata([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_metadata(AVFrame* frame, AVDictionary* val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_frame_get_decode_error_flags([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_decode_error_flags(AVFrame* frame, int val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_frame_get_pkt_size([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_pkt_size(AVFrame* frame, int val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int8_t *")]
        [Obsolete]
        public static extern sbyte* av_frame_get_qp_table(AVFrame* f, int* stride, int* type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_frame_set_qp_table(AVFrame* f, AVBufferRef* buf, int stride, int type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVColorSpace")]
        [Obsolete]
        public static extern AVColorSpace av_frame_get_colorspace([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_colorspace(AVFrame* frame, [NativeTypeName("enum AVColorSpace")] AVColorSpace val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVColorRange")]
        [Obsolete]
        public static extern AVColorRange av_frame_get_color_range([NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_frame_set_color_range(AVFrame* frame, [NativeTypeName("enum AVColorRange")] AVColorRange val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_get_colorspace_name([NativeTypeName("enum AVColorSpace")] AVColorSpace val);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrame* av_frame_alloc();

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_free(AVFrame** frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_ref(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrame* av_frame_clone([NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_unref(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_move_ref(AVFrame* dst, AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_get_buffer(AVFrame* frame, int align);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_is_writable(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_make_writable(AVFrame* frame);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_copy(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_copy_props(AVFrame* dst, [NativeTypeName("const AVFrame *")] AVFrame* src);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBufferRef* av_frame_get_plane_buffer(AVFrame* frame, int plane);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_new_side_data(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, int size);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_new_side_data_from_buf(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type, AVBufferRef* buf);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFrameSideData* av_frame_get_side_data([NativeTypeName("const AVFrame *")] AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_frame_remove_side_data(AVFrame* frame, [NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        internal const int AV_FRAME_CROP_UNALIGNED = 1 << 0;

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_frame_apply_cropping(AVFrame* frame, int flags);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* av_frame_side_data_name([NativeTypeName("enum AVFrameSideDataType")] AVFrameSideDataType type);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_reduce(int* dst_num, int* dst_den, [NativeTypeName("int64_t")] long num, [NativeTypeName("int64_t")] long den, [NativeTypeName("int64_t")] long max);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_mul_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_div_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_add_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_sub_q(AVRational b, AVRational c);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_d2q(double d, int max);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_nearer_q(AVRational q, AVRational q1, AVRational q2);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_find_nearest_q_idx(AVRational q, [NativeTypeName("const AVRational *")] AVRational* q_list);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint32_t")]
        public static extern uint av_q2intfloat(AVRational q);

        [DllImport("avutil", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_gcd_q(AVRational a, AVRational b, int max_den, AVRational def);
    }
}
