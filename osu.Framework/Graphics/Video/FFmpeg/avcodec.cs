// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming style
#pragma warning disable IDE0027 // Use expression-body

using System;
using System.Runtime.InteropServices;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    public enum AVDiscard
    {
        AVDISCARD_NONE = -16,
        AVDISCARD_DEFAULT = 0,
        AVDISCARD_NONREF = 8,
        AVDISCARD_BIDIR = 16,
        AVDISCARD_NONINTRA = 24,
        AVDISCARD_NONKEY = 32,
        AVDISCARD_ALL = 48,
    }

    public enum AVAudioServiceType
    {
        AV_AUDIO_SERVICE_TYPE_MAIN = 0,
        AV_AUDIO_SERVICE_TYPE_EFFECTS = 1,
        AV_AUDIO_SERVICE_TYPE_VISUALLY_IMPAIRED = 2,
        AV_AUDIO_SERVICE_TYPE_HEARING_IMPAIRED = 3,
        AV_AUDIO_SERVICE_TYPE_DIALOGUE = 4,
        AV_AUDIO_SERVICE_TYPE_COMMENTARY = 5,
        AV_AUDIO_SERVICE_TYPE_EMERGENCY = 6,
        AV_AUDIO_SERVICE_TYPE_VOICE_OVER = 7,
        AV_AUDIO_SERVICE_TYPE_KARAOKE = 8,
        AV_AUDIO_SERVICE_TYPE_NB,
    }

    public partial struct RcOverride
    {
        public int start_frame;

        public int end_frame;

        public int qscale;

        public float quality_factor;
    }

    public unsafe partial struct AVPanScan
    {
        public int id;

        public int width;

        public int height;

        [NativeTypeName("int16_t[3][2]")]
        public fixed short position[3 * 2];
    }

    public partial struct AVCPBProperties
    {
        public int max_bitrate;

        public int min_bitrate;

        public int avg_bitrate;

        public int buffer_size;

        [NativeTypeName("uint64_t")]
        public ulong vbv_delay;
    }

    public partial struct AVProducerReferenceTime
    {
        [NativeTypeName("int64_t")]
        public long wallclock;

        public int flags;
    }

    public partial struct AVCodecInternal
    {
    }

    public unsafe partial struct AVCodecContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public int log_level_offset;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("const struct AVCodec *")]
        public AVCodec* codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("unsigned int")]
        public uint codec_tag;

        public void* priv_data;

        [NativeTypeName("struct AVCodecInternal *")]
        public AVCodecInternal* @internal;

        public void* opaque;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int bit_rate_tolerance;

        public int global_quality;

        public int compression_level;

        public int flags;

        public int flags2;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public AVRational time_base;

        public int ticks_per_frame;

        public int delay;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public int gop_size;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        [NativeTypeName("void (*)(struct AVCodecContext *, const AVFrame *, int *, int, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int, int, int, void> draw_horiz_band;

        [NativeTypeName("enum AVPixelFormat (*)(struct AVCodecContext *, const enum AVPixelFormat *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPixelFormat*, AVPixelFormat> get_format;

        public int max_b_frames;

        public float b_quant_factor;

        [Obsolete]
        public int b_frame_strategy;

        public float b_quant_offset;

        public int has_b_frames;

        [Obsolete]
        public int mpeg_quant;

        public float i_quant_factor;

        public float i_quant_offset;

        public float lumi_masking;

        public float temporal_cplx_masking;

        public float spatial_cplx_masking;

        public float p_masking;

        public float dark_masking;

        public int slice_count;

        [Obsolete]
        public int prediction_method;

        public int* slice_offset;

        public AVRational sample_aspect_ratio;

        public int me_cmp;

        public int me_sub_cmp;

        public int mb_cmp;

        public int ildct_cmp;

        public int dia_size;

        public int last_predictor_count;

        [Obsolete]
        public int pre_me;

        public int me_pre_cmp;

        public int pre_dia_size;

        public int me_subpel_quality;

        public int me_range;

        public int slice_flags;

        public int mb_decision;

        [NativeTypeName("uint16_t *")]
        public ushort* intra_matrix;

        [NativeTypeName("uint16_t *")]
        public ushort* inter_matrix;

        [Obsolete]
        public int scenechange_threshold;

        [Obsolete]
        public int noise_reduction;

        public int intra_dc_precision;

        public int skip_top;

        public int skip_bottom;

        public int mb_lmin;

        public int mb_lmax;

        [Obsolete]
        public int me_penalty_compensation;

        public int bidir_refine;

        [Obsolete]
        public int brd_scale;

        public int keyint_min;

        public int refs;

        [Obsolete]
        public int chromaoffset;

        public int mv0_threshold;

        [Obsolete]
        public int b_sensitivity;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace colorspace;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_sample_location;

        public int slices;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        public int sample_rate;

        public int channels;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat sample_fmt;

        public int frame_size;

        public int frame_number;

        public int block_align;

        public int cutoff;

        [NativeTypeName("uint64_t")]
        public ulong channel_layout;

        [NativeTypeName("uint64_t")]
        public ulong request_channel_layout;

        [NativeTypeName("enum AVAudioServiceType")]
        public AVAudioServiceType audio_service_type;

        [NativeTypeName("enum AVSampleFormat")]
        public AVSampleFormat request_sample_fmt;

        [NativeTypeName("int (*)(struct AVCodecContext *, AVFrame *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int, int> get_buffer2;

        [Obsolete]
        public int refcounted_frames;

        public float qcompress;

        public float qblur;

        public int qmin;

        public int qmax;

        public int max_qdiff;

        public int rc_buffer_size;

        public int rc_override_count;

        public RcOverride* rc_override;

        [NativeTypeName("int64_t")]
        public long rc_max_rate;

        [NativeTypeName("int64_t")]
        public long rc_min_rate;

        public float rc_max_available_vbv_use;

        public float rc_min_vbv_overflow_use;

        public int rc_initial_buffer_occupancy;

        [Obsolete]
        public int coder_type;

        [Obsolete]
        public int context_model;

        [Obsolete]
        public int frame_skip_threshold;

        [Obsolete]
        public int frame_skip_factor;

        [Obsolete]
        public int frame_skip_exp;

        [Obsolete]
        public int frame_skip_cmp;

        public int trellis;

        [Obsolete]
        public int min_prediction_order;

        [Obsolete]
        public int max_prediction_order;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long timecode_frame_start;

        [NativeTypeName("void (*)(struct AVCodecContext *, void *, int, int)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, void> rtp_callback;

        [Obsolete]
        public int rtp_payload_size;

        [Obsolete]
        public int mv_bits;

        [Obsolete]
        public int header_bits;

        [Obsolete]
        public int i_tex_bits;

        [Obsolete]
        public int p_tex_bits;

        [Obsolete]
        public int i_count;

        [Obsolete]
        public int p_count;

        [Obsolete]
        public int skip_count;

        [Obsolete]
        public int misc_bits;

        [Obsolete]
        public int frame_bits;

        [NativeTypeName("char *")]
        public byte* stats_out;

        [NativeTypeName("char *")]
        public byte* stats_in;

        public int workaround_bugs;

        public int strict_std_compliance;

        public int error_concealment;

        public int debug;

        public int err_recognition;

        [NativeTypeName("int64_t")]
        public long reordered_opaque;

        [NativeTypeName("const struct AVHWAccel *")]
        public AVHWAccel* hwaccel;

        public void* hwaccel_context;

        [NativeTypeName("uint64_t[8]")]
        public fixed ulong error[8];

        public int dct_algo;

        public int idct_algo;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int lowres;

        [Obsolete]
        public AVFrame* coded_frame;

        public int thread_count;

        public int thread_type;

        public int active_thread_type;

        public int thread_safe_callbacks;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *), void *, int *, int, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int>, void*, int*, int, int, int> execute;

        [NativeTypeName("int (*)(struct AVCodecContext *, int (*)(struct AVCodecContext *, void *, int, int), void *, int *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int>, void*, int*, int, int> execute2;

        public int nsse_weight;

        public int profile;

        public int level;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_loop_filter;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_idct;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard skip_frame;

        [NativeTypeName("uint8_t *")]
        public byte* subtitle_header;

        public int subtitle_header_size;

        [NativeTypeName("uint64_t")]
        [Obsolete]
        public ulong vbv_delay;

        [Obsolete]
        public int side_data_only_packets;

        public int initial_padding;

        public AVRational framerate;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat sw_pix_fmt;

        public AVRational pkt_timebase;

        [NativeTypeName("const AVCodecDescriptor *")]
        public AVCodecDescriptor* codec_descriptor;

        [NativeTypeName("int64_t")]
        public long pts_correction_num_faulty_pts;

        [NativeTypeName("int64_t")]
        public long pts_correction_num_faulty_dts;

        [NativeTypeName("int64_t")]
        public long pts_correction_last_pts;

        [NativeTypeName("int64_t")]
        public long pts_correction_last_dts;

        [NativeTypeName("char *")]
        public byte* sub_charenc;

        public int sub_charenc_mode;

        public int skip_alpha;

        public int seek_preroll;

        public int debug_mv;

        [NativeTypeName("uint16_t *")]
        public ushort* chroma_intra_matrix;

        [NativeTypeName("uint8_t *")]
        public byte* dump_separator;

        [NativeTypeName("char *")]
        public byte* codec_whitelist;

        [NativeTypeName("unsigned int")]
        public uint properties;

        public AVPacketSideData* coded_side_data;

        public int nb_coded_side_data;

        public AVBufferRef* hw_frames_ctx;

        public int sub_text_format;

        public int trailing_padding;

        [NativeTypeName("int64_t")]
        public long max_pixels;

        public AVBufferRef* hw_device_ctx;

        public int hwaccel_flags;

        public int apply_cropping;

        public int extra_hw_frames;

        public int discard_damaged_percentage;

        [NativeTypeName("int64_t")]
        public long max_samples;

        public int export_side_data;
    }

    public partial struct AVCodecContext
    {
    }

    public partial struct MpegEncContext
    {
    }

    public unsafe partial struct AVHWAccel
    {
        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int capabilities;

        [NativeTypeName("int (*)(AVCodecContext *, AVFrame *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> alloc_frame;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, uint32_t)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, uint, int> start_frame;

        [NativeTypeName("int (*)(AVCodecContext *, int, const uint8_t *, uint32_t)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int, byte*, uint, int> decode_params;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, uint32_t)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, uint, int> decode_slice;

        [NativeTypeName("int (*)(AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> end_frame;

        public int frame_priv_data_size;

        [NativeTypeName("void (*)(struct MpegEncContext *)")]
        public delegate* unmanaged[Cdecl]<MpegEncContext*, void> decode_mb;

        [NativeTypeName("int (*)(AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> init;

        [NativeTypeName("int (*)(AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> uninit;

        public int priv_data_size;

        public int caps_internal;

        [NativeTypeName("int (*)(AVCodecContext *, AVBufferRef *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVBufferRef*, int> frame_params;
    }

    public unsafe partial struct AVPicture
    {
        [NativeTypeName("uint8_t *[8]")]
        [Obsolete]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[8]")]
        [Obsolete]
        public fixed int linesize[8];

        [Obsolete]
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
    }

    public enum AVSubtitleType
    {
        SUBTITLE_NONE,
        SUBTITLE_BITMAP,
        SUBTITLE_TEXT,
        SUBTITLE_ASS,
    }

    public unsafe partial struct AVSubtitleRect
    {
        public int x;

        public int y;

        public int w;

        public int h;

        public int nb_colors;

        [Obsolete]
        public AVPicture pict;

        [NativeTypeName("uint8_t *[4]")]
        public _data_e__FixedBuffer data;

        [NativeTypeName("int[4]")]
        public fixed int linesize[4];

        [NativeTypeName("enum AVSubtitleType")]
        public AVSubtitleType type;

        [NativeTypeName("char *")]
        public byte* text;

        [NativeTypeName("char *")]
        public byte* ass;

        public int flags;

        public unsafe partial struct _data_e__FixedBuffer
        {
            public byte* e0;
            public byte* e1;
            public byte* e2;
            public byte* e3;

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
    }

    public unsafe partial struct AVSubtitle
    {
        [NativeTypeName("uint16_t")]
        public ushort format;

        [NativeTypeName("uint32_t")]
        public uint start_display_time;

        [NativeTypeName("uint32_t")]
        public uint end_display_time;

        [NativeTypeName("unsigned int")]
        public uint num_rects;

        public AVSubtitleRect** rects;

        [NativeTypeName("int64_t")]
        public long pts;
    }

    public partial struct AVSubtitle
    {
    }

    public enum AVPictureStructure
    {
        AV_PICTURE_STRUCTURE_UNKNOWN,
        AV_PICTURE_STRUCTURE_TOP_FIELD,
        AV_PICTURE_STRUCTURE_BOTTOM_FIELD,
        AV_PICTURE_STRUCTURE_FRAME,
    }

    public unsafe partial struct AVCodecParserContext
    {
        public void* priv_data;

        [NativeTypeName("struct AVCodecParser *")]
        public AVCodecParser* parser;

        [NativeTypeName("int64_t")]
        public long frame_offset;

        [NativeTypeName("int64_t")]
        public long cur_offset;

        [NativeTypeName("int64_t")]
        public long next_frame_offset;

        public int pict_type;

        public int repeat_pict;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("int64_t")]
        public long last_pts;

        [NativeTypeName("int64_t")]
        public long last_dts;

        public int fetch_timestamp;

        public int cur_frame_start_index;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_offset[4];

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_pts[4];

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_dts[4];

        public int flags;

        [NativeTypeName("int64_t")]
        public long offset;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_end[4];

        public int key_frame;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long convergence_duration;

        public int dts_sync_point;

        public int dts_ref_dts_delta;

        public int pts_dts_delta;

        [NativeTypeName("int64_t[4]")]
        public fixed long cur_frame_pos[4];

        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        public long last_pos;

        public int duration;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVPictureStructure")]
        public AVPictureStructure picture_structure;

        public int output_picture_number;

        public int width;

        public int height;

        public int coded_width;

        public int coded_height;

        public int format;
    }

    public unsafe partial struct AVCodecParser
    {
        [NativeTypeName("int[5]")]
        public fixed int codec_ids[5];

        public int priv_data_size;

        [NativeTypeName("int (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, int> parser_init;

        [NativeTypeName("int (*)(AVCodecParserContext *, AVCodecContext *, const uint8_t **, int *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, AVCodecContext*, byte**, int*, byte*, int, int> parser_parse;

        [NativeTypeName("void (*)(AVCodecParserContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecParserContext*, void> parser_close;

        [NativeTypeName("int (*)(AVCodecContext *, const uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, int> split;

        [NativeTypeName("struct AVCodecParser *")]
        public AVCodecParser* next;
    }

    public unsafe partial struct AVBitStreamFilterContext
    {
        public void* priv_data;

        [NativeTypeName("const struct AVBitStreamFilter *")]
        public AVBitStreamFilter* filter;

        public AVCodecParserContext* parser;

        [NativeTypeName("struct AVBitStreamFilterContext *")]
        public AVBitStreamFilterContext* next;

        [NativeTypeName("char *")]
        public byte* args;
    }

    public enum AVLockOp
    {
        AV_LOCK_CREATE,
        AV_LOCK_OBTAIN,
        AV_LOCK_RELEASE,
        AV_LOCK_DESTROY,
    }

    public partial struct AVBSFInternal
    {
    }

    public unsafe partial struct AVBSFContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("const struct AVBitStreamFilter *")]
        public AVBitStreamFilter* filter;

        public AVBSFInternal* @internal;

        public void* priv_data;

        public AVCodecParameters* par_in;

        public AVCodecParameters* par_out;

        public AVRational time_base_in;

        public AVRational time_base_out;
    }

    public unsafe partial struct AVBitStreamFilter
    {
        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const enum AVCodecID *")]
        public AVCodecID* codec_ids;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        public int priv_data_size;

        [NativeTypeName("int (*)(AVBSFContext *)")]
        public delegate* unmanaged[Cdecl]<AVBSFContext*, int> init;

        [NativeTypeName("int (*)(AVBSFContext *, AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVBSFContext*, AVPacket*, int> filter;

        [NativeTypeName("void (*)(AVBSFContext *)")]
        public delegate* unmanaged[Cdecl]<AVBSFContext*, void> close;

        [NativeTypeName("void (*)(AVBSFContext *)")]
        public delegate* unmanaged[Cdecl]<AVBSFContext*, void> flush;
    }

    public partial struct AVBSFList
    {
    }

    public unsafe partial struct AVProfile
    {
        public int profile;

        [NativeTypeName("const char *")]
        public byte* name;
    }

    public partial struct AVCodecDefault
    {
    }

    public partial struct AVPacket
    {
    }

    public unsafe partial struct AVPacket
    {
        public AVBufferRef* buf;

        [NativeTypeName("int64_t")]
        public long pts;

        [NativeTypeName("int64_t")]
        public long dts;

        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;

        public int stream_index;

        public int flags;

        public AVPacketSideData* side_data;

        public int side_data_elems;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        [Obsolete]
        public long convergence_duration;
    }

    public unsafe partial struct AVCodec
    {
        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const char *")]
        public byte* long_name;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        public int capabilities;

        [NativeTypeName("const AVRational *")]
        public AVRational* supported_framerates;

        [NativeTypeName("const enum AVPixelFormat *")]
        public AVPixelFormat* pix_fmts;

        [NativeTypeName("const int *")]
        public int* supported_samplerates;

        [NativeTypeName("const enum AVSampleFormat *")]
        public AVSampleFormat* sample_fmts;

        [NativeTypeName("const uint64_t *")]
        public ulong* channel_layouts;

        [NativeTypeName("uint8_t")]
        public byte max_lowres;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const AVProfile *")]
        public AVProfile* profiles;

        [NativeTypeName("const char *")]
        public byte* wrapper_name;

        public int priv_data_size;

        [NativeTypeName("struct AVCodec *")]
        public AVCodec* next;

        [NativeTypeName("int (*)(struct AVCodecContext *, const struct AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVCodecContext*, int> update_thread_context;

        [NativeTypeName("const AVCodecDefault *")]
        public AVCodecDefault* defaults;

        [NativeTypeName("void (*)(struct AVCodec *)")]
        public delegate* unmanaged[Cdecl]<AVCodec*, void> init_static_data;

        [NativeTypeName("int (*)(struct AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> init;

        [NativeTypeName("int (*)(struct AVCodecContext *, uint8_t *, int, const struct AVSubtitle *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, byte*, int, AVSubtitle*, int> encode_sub;

        [NativeTypeName("int (*)(struct AVCodecContext *, struct AVPacket *, const struct AVFrame *, int *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, AVFrame*, int*, int> encode2;

        [NativeTypeName("int (*)(struct AVCodecContext *, void *, int *, struct AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int*, AVPacket*, int> decode;

        [NativeTypeName("int (*)(struct AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, int> close;

        [NativeTypeName("int (*)(struct AVCodecContext *, const struct AVFrame *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> send_frame;

        [NativeTypeName("int (*)(struct AVCodecContext *, struct AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVPacket*, int> receive_packet;

        [NativeTypeName("int (*)(struct AVCodecContext *, struct AVFrame *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, AVFrame*, int> receive_frame;

        [NativeTypeName("void (*)(struct AVCodecContext *)")]
        public delegate* unmanaged[Cdecl]<AVCodecContext*, void> flush;

        public int caps_internal;

        [NativeTypeName("const char *")]
        public byte* bsfs;

        [NativeTypeName("const struct AVCodecHWConfigInternal **")]
        public AVCodecHWConfigInternal** hw_configs;

        [NativeTypeName("const uint32_t *")]
        public uint* codec_tags;

        public partial struct AVCodecHWConfigInternal
        {
        }
    }

    public partial struct AVCodecHWConfig
    {
        [NativeTypeName("enum AVPixelFormat")]
        public AVPixelFormat pix_fmt;

        public int methods;

        [NativeTypeName("enum AVHWDeviceType")]
        public AVHWDeviceType device_type;
    }

    public unsafe partial struct AVCodecDescriptor
    {
        [NativeTypeName("enum AVCodecID")]
        public AVCodecID id;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        [NativeTypeName("const char *")]
        public byte* name;

        [NativeTypeName("const char *")]
        public byte* long_name;

        public int props;

        [NativeTypeName("const char *const *")]
        public byte** mime_types;

        [NativeTypeName("const struct AVProfile *")]
        public AVProfile* profiles;

        public partial struct AVProfile
        {
        }
    }

    public enum AVCodecID
    {
        AV_CODEC_ID_NONE,
        AV_CODEC_ID_MPEG1VIDEO,
        AV_CODEC_ID_MPEG2VIDEO,
        AV_CODEC_ID_H261,
        AV_CODEC_ID_H263,
        AV_CODEC_ID_RV10,
        AV_CODEC_ID_RV20,
        AV_CODEC_ID_MJPEG,
        AV_CODEC_ID_MJPEGB,
        AV_CODEC_ID_LJPEG,
        AV_CODEC_ID_SP5X,
        AV_CODEC_ID_JPEGLS,
        AV_CODEC_ID_MPEG4,
        AV_CODEC_ID_RAWVIDEO,
        AV_CODEC_ID_MSMPEG4V1,
        AV_CODEC_ID_MSMPEG4V2,
        AV_CODEC_ID_MSMPEG4V3,
        AV_CODEC_ID_WMV1,
        AV_CODEC_ID_WMV2,
        AV_CODEC_ID_H263P,
        AV_CODEC_ID_H263I,
        AV_CODEC_ID_FLV1,
        AV_CODEC_ID_SVQ1,
        AV_CODEC_ID_SVQ3,
        AV_CODEC_ID_DVVIDEO,
        AV_CODEC_ID_HUFFYUV,
        AV_CODEC_ID_CYUV,
        AV_CODEC_ID_H264,
        AV_CODEC_ID_INDEO3,
        AV_CODEC_ID_VP3,
        AV_CODEC_ID_THEORA,
        AV_CODEC_ID_ASV1,
        AV_CODEC_ID_ASV2,
        AV_CODEC_ID_FFV1,
        AV_CODEC_ID_4XM,
        AV_CODEC_ID_VCR1,
        AV_CODEC_ID_CLJR,
        AV_CODEC_ID_MDEC,
        AV_CODEC_ID_ROQ,
        AV_CODEC_ID_INTERPLAY_VIDEO,
        AV_CODEC_ID_XAN_WC3,
        AV_CODEC_ID_XAN_WC4,
        AV_CODEC_ID_RPZA,
        AV_CODEC_ID_CINEPAK,
        AV_CODEC_ID_WS_VQA,
        AV_CODEC_ID_MSRLE,
        AV_CODEC_ID_MSVIDEO1,
        AV_CODEC_ID_IDCIN,
        AV_CODEC_ID_8BPS,
        AV_CODEC_ID_SMC,
        AV_CODEC_ID_FLIC,
        AV_CODEC_ID_TRUEMOTION1,
        AV_CODEC_ID_VMDVIDEO,
        AV_CODEC_ID_MSZH,
        AV_CODEC_ID_ZLIB,
        AV_CODEC_ID_QTRLE,
        AV_CODEC_ID_TSCC,
        AV_CODEC_ID_ULTI,
        AV_CODEC_ID_QDRAW,
        AV_CODEC_ID_VIXL,
        AV_CODEC_ID_QPEG,
        AV_CODEC_ID_PNG,
        AV_CODEC_ID_PPM,
        AV_CODEC_ID_PBM,
        AV_CODEC_ID_PGM,
        AV_CODEC_ID_PGMYUV,
        AV_CODEC_ID_PAM,
        AV_CODEC_ID_FFVHUFF,
        AV_CODEC_ID_RV30,
        AV_CODEC_ID_RV40,
        AV_CODEC_ID_VC1,
        AV_CODEC_ID_WMV3,
        AV_CODEC_ID_LOCO,
        AV_CODEC_ID_WNV1,
        AV_CODEC_ID_AASC,
        AV_CODEC_ID_INDEO2,
        AV_CODEC_ID_FRAPS,
        AV_CODEC_ID_TRUEMOTION2,
        AV_CODEC_ID_BMP,
        AV_CODEC_ID_CSCD,
        AV_CODEC_ID_MMVIDEO,
        AV_CODEC_ID_ZMBV,
        AV_CODEC_ID_AVS,
        AV_CODEC_ID_SMACKVIDEO,
        AV_CODEC_ID_NUV,
        AV_CODEC_ID_KMVC,
        AV_CODEC_ID_FLASHSV,
        AV_CODEC_ID_CAVS,
        AV_CODEC_ID_JPEG2000,
        AV_CODEC_ID_VMNC,
        AV_CODEC_ID_VP5,
        AV_CODEC_ID_VP6,
        AV_CODEC_ID_VP6F,
        AV_CODEC_ID_TARGA,
        AV_CODEC_ID_DSICINVIDEO,
        AV_CODEC_ID_TIERTEXSEQVIDEO,
        AV_CODEC_ID_TIFF,
        AV_CODEC_ID_GIF,
        AV_CODEC_ID_DXA,
        AV_CODEC_ID_DNXHD,
        AV_CODEC_ID_THP,
        AV_CODEC_ID_SGI,
        AV_CODEC_ID_C93,
        AV_CODEC_ID_BETHSOFTVID,
        AV_CODEC_ID_PTX,
        AV_CODEC_ID_TXD,
        AV_CODEC_ID_VP6A,
        AV_CODEC_ID_AMV,
        AV_CODEC_ID_VB,
        AV_CODEC_ID_PCX,
        AV_CODEC_ID_SUNRAST,
        AV_CODEC_ID_INDEO4,
        AV_CODEC_ID_INDEO5,
        AV_CODEC_ID_MIMIC,
        AV_CODEC_ID_RL2,
        AV_CODEC_ID_ESCAPE124,
        AV_CODEC_ID_DIRAC,
        AV_CODEC_ID_BFI,
        AV_CODEC_ID_CMV,
        AV_CODEC_ID_MOTIONPIXELS,
        AV_CODEC_ID_TGV,
        AV_CODEC_ID_TGQ,
        AV_CODEC_ID_TQI,
        AV_CODEC_ID_AURA,
        AV_CODEC_ID_AURA2,
        AV_CODEC_ID_V210X,
        AV_CODEC_ID_TMV,
        AV_CODEC_ID_V210,
        AV_CODEC_ID_DPX,
        AV_CODEC_ID_MAD,
        AV_CODEC_ID_FRWU,
        AV_CODEC_ID_FLASHSV2,
        AV_CODEC_ID_CDGRAPHICS,
        AV_CODEC_ID_R210,
        AV_CODEC_ID_ANM,
        AV_CODEC_ID_BINKVIDEO,
        AV_CODEC_ID_IFF_ILBM,
        AV_CODEC_ID_KGV1,
        AV_CODEC_ID_YOP,
        AV_CODEC_ID_VP8,
        AV_CODEC_ID_PICTOR,
        AV_CODEC_ID_ANSI,
        AV_CODEC_ID_A64_MULTI,
        AV_CODEC_ID_A64_MULTI5,
        AV_CODEC_ID_R10K,
        AV_CODEC_ID_MXPEG,
        AV_CODEC_ID_LAGARITH,
        AV_CODEC_ID_PRORES,
        AV_CODEC_ID_JV,
        AV_CODEC_ID_DFA,
        AV_CODEC_ID_WMV3IMAGE,
        AV_CODEC_ID_VC1IMAGE,
        AV_CODEC_ID_UTVIDEO,
        AV_CODEC_ID_BMV_VIDEO,
        AV_CODEC_ID_VBLE,
        AV_CODEC_ID_DXTORY,
        AV_CODEC_ID_V410,
        AV_CODEC_ID_XWD,
        AV_CODEC_ID_CDXL,
        AV_CODEC_ID_XBM,
        AV_CODEC_ID_ZEROCODEC,
        AV_CODEC_ID_MSS1,
        AV_CODEC_ID_MSA1,
        AV_CODEC_ID_TSCC2,
        AV_CODEC_ID_MTS2,
        AV_CODEC_ID_CLLC,
        AV_CODEC_ID_MSS2,
        AV_CODEC_ID_VP9,
        AV_CODEC_ID_AIC,
        AV_CODEC_ID_ESCAPE130,
        AV_CODEC_ID_G2M,
        AV_CODEC_ID_WEBP,
        AV_CODEC_ID_HNM4_VIDEO,
        AV_CODEC_ID_HEVC,
        AV_CODEC_ID_FIC,
        AV_CODEC_ID_ALIAS_PIX,
        AV_CODEC_ID_BRENDER_PIX,
        AV_CODEC_ID_PAF_VIDEO,
        AV_CODEC_ID_EXR,
        AV_CODEC_ID_VP7,
        AV_CODEC_ID_SANM,
        AV_CODEC_ID_SGIRLE,
        AV_CODEC_ID_MVC1,
        AV_CODEC_ID_MVC2,
        AV_CODEC_ID_HQX,
        AV_CODEC_ID_TDSC,
        AV_CODEC_ID_HQ_HQA,
        AV_CODEC_ID_HAP,
        AV_CODEC_ID_DDS,
        AV_CODEC_ID_DXV,
        AV_CODEC_ID_SCREENPRESSO,
        AV_CODEC_ID_RSCC,
        AV_CODEC_ID_AVS2,
        AV_CODEC_ID_Y41P = 0x8000,
        AV_CODEC_ID_AVRP,
        AV_CODEC_ID_012V,
        AV_CODEC_ID_AVUI,
        AV_CODEC_ID_AYUV,
        AV_CODEC_ID_TARGA_Y216,
        AV_CODEC_ID_V308,
        AV_CODEC_ID_V408,
        AV_CODEC_ID_YUV4,
        AV_CODEC_ID_AVRN,
        AV_CODEC_ID_CPIA,
        AV_CODEC_ID_XFACE,
        AV_CODEC_ID_SNOW,
        AV_CODEC_ID_SMVJPEG,
        AV_CODEC_ID_APNG,
        AV_CODEC_ID_DAALA,
        AV_CODEC_ID_CFHD,
        AV_CODEC_ID_TRUEMOTION2RT,
        AV_CODEC_ID_M101,
        AV_CODEC_ID_MAGICYUV,
        AV_CODEC_ID_SHEERVIDEO,
        AV_CODEC_ID_YLC,
        AV_CODEC_ID_PSD,
        AV_CODEC_ID_PIXLET,
        AV_CODEC_ID_SPEEDHQ,
        AV_CODEC_ID_FMVC,
        AV_CODEC_ID_SCPR,
        AV_CODEC_ID_CLEARVIDEO,
        AV_CODEC_ID_XPM,
        AV_CODEC_ID_AV1,
        AV_CODEC_ID_BITPACKED,
        AV_CODEC_ID_MSCC,
        AV_CODEC_ID_SRGC,
        AV_CODEC_ID_SVG,
        AV_CODEC_ID_GDV,
        AV_CODEC_ID_FITS,
        AV_CODEC_ID_IMM4,
        AV_CODEC_ID_PROSUMER,
        AV_CODEC_ID_MWSC,
        AV_CODEC_ID_WCMV,
        AV_CODEC_ID_RASC,
        AV_CODEC_ID_HYMT,
        AV_CODEC_ID_ARBC,
        AV_CODEC_ID_AGM,
        AV_CODEC_ID_LSCR,
        AV_CODEC_ID_VP4,
        AV_CODEC_ID_IMM5,
        AV_CODEC_ID_MVDV,
        AV_CODEC_ID_MVHA,
        AV_CODEC_ID_CDTOONS,
        AV_CODEC_ID_MV30,
        AV_CODEC_ID_NOTCHLC,
        AV_CODEC_ID_PFM,
        AV_CODEC_ID_FIRST_AUDIO = 0x10000,
        AV_CODEC_ID_PCM_S16LE = 0x10000,
        AV_CODEC_ID_PCM_S16BE,
        AV_CODEC_ID_PCM_U16LE,
        AV_CODEC_ID_PCM_U16BE,
        AV_CODEC_ID_PCM_S8,
        AV_CODEC_ID_PCM_U8,
        AV_CODEC_ID_PCM_MULAW,
        AV_CODEC_ID_PCM_ALAW,
        AV_CODEC_ID_PCM_S32LE,
        AV_CODEC_ID_PCM_S32BE,
        AV_CODEC_ID_PCM_U32LE,
        AV_CODEC_ID_PCM_U32BE,
        AV_CODEC_ID_PCM_S24LE,
        AV_CODEC_ID_PCM_S24BE,
        AV_CODEC_ID_PCM_U24LE,
        AV_CODEC_ID_PCM_U24BE,
        AV_CODEC_ID_PCM_S24DAUD,
        AV_CODEC_ID_PCM_ZORK,
        AV_CODEC_ID_PCM_S16LE_PLANAR,
        AV_CODEC_ID_PCM_DVD,
        AV_CODEC_ID_PCM_F32BE,
        AV_CODEC_ID_PCM_F32LE,
        AV_CODEC_ID_PCM_F64BE,
        AV_CODEC_ID_PCM_F64LE,
        AV_CODEC_ID_PCM_BLURAY,
        AV_CODEC_ID_PCM_LXF,
        AV_CODEC_ID_S302M,
        AV_CODEC_ID_PCM_S8_PLANAR,
        AV_CODEC_ID_PCM_S24LE_PLANAR,
        AV_CODEC_ID_PCM_S32LE_PLANAR,
        AV_CODEC_ID_PCM_S16BE_PLANAR,
        AV_CODEC_ID_PCM_S64LE = 0x10800,
        AV_CODEC_ID_PCM_S64BE,
        AV_CODEC_ID_PCM_F16LE,
        AV_CODEC_ID_PCM_F24LE,
        AV_CODEC_ID_PCM_VIDC,
        AV_CODEC_ID_ADPCM_IMA_QT = 0x11000,
        AV_CODEC_ID_ADPCM_IMA_WAV,
        AV_CODEC_ID_ADPCM_IMA_DK3,
        AV_CODEC_ID_ADPCM_IMA_DK4,
        AV_CODEC_ID_ADPCM_IMA_WS,
        AV_CODEC_ID_ADPCM_IMA_SMJPEG,
        AV_CODEC_ID_ADPCM_MS,
        AV_CODEC_ID_ADPCM_4XM,
        AV_CODEC_ID_ADPCM_XA,
        AV_CODEC_ID_ADPCM_ADX,
        AV_CODEC_ID_ADPCM_EA,
        AV_CODEC_ID_ADPCM_G726,
        AV_CODEC_ID_ADPCM_CT,
        AV_CODEC_ID_ADPCM_SWF,
        AV_CODEC_ID_ADPCM_YAMAHA,
        AV_CODEC_ID_ADPCM_SBPRO_4,
        AV_CODEC_ID_ADPCM_SBPRO_3,
        AV_CODEC_ID_ADPCM_SBPRO_2,
        AV_CODEC_ID_ADPCM_THP,
        AV_CODEC_ID_ADPCM_IMA_AMV,
        AV_CODEC_ID_ADPCM_EA_R1,
        AV_CODEC_ID_ADPCM_EA_R3,
        AV_CODEC_ID_ADPCM_EA_R2,
        AV_CODEC_ID_ADPCM_IMA_EA_SEAD,
        AV_CODEC_ID_ADPCM_IMA_EA_EACS,
        AV_CODEC_ID_ADPCM_EA_XAS,
        AV_CODEC_ID_ADPCM_EA_MAXIS_XA,
        AV_CODEC_ID_ADPCM_IMA_ISS,
        AV_CODEC_ID_ADPCM_G722,
        AV_CODEC_ID_ADPCM_IMA_APC,
        AV_CODEC_ID_ADPCM_VIMA,
        AV_CODEC_ID_ADPCM_AFC = 0x11800,
        AV_CODEC_ID_ADPCM_IMA_OKI,
        AV_CODEC_ID_ADPCM_DTK,
        AV_CODEC_ID_ADPCM_IMA_RAD,
        AV_CODEC_ID_ADPCM_G726LE,
        AV_CODEC_ID_ADPCM_THP_LE,
        AV_CODEC_ID_ADPCM_PSX,
        AV_CODEC_ID_ADPCM_AICA,
        AV_CODEC_ID_ADPCM_IMA_DAT4,
        AV_CODEC_ID_ADPCM_MTAF,
        AV_CODEC_ID_ADPCM_AGM,
        AV_CODEC_ID_ADPCM_ARGO,
        AV_CODEC_ID_ADPCM_IMA_SSI,
        AV_CODEC_ID_ADPCM_ZORK,
        AV_CODEC_ID_ADPCM_IMA_APM,
        AV_CODEC_ID_ADPCM_IMA_ALP,
        AV_CODEC_ID_ADPCM_IMA_MTF,
        AV_CODEC_ID_ADPCM_IMA_CUNNING,
        AV_CODEC_ID_AMR_NB = 0x12000,
        AV_CODEC_ID_AMR_WB,
        AV_CODEC_ID_RA_144 = 0x13000,
        AV_CODEC_ID_RA_288,
        AV_CODEC_ID_ROQ_DPCM = 0x14000,
        AV_CODEC_ID_INTERPLAY_DPCM,
        AV_CODEC_ID_XAN_DPCM,
        AV_CODEC_ID_SOL_DPCM,
        AV_CODEC_ID_SDX2_DPCM = 0x14800,
        AV_CODEC_ID_GREMLIN_DPCM,
        AV_CODEC_ID_DERF_DPCM,
        AV_CODEC_ID_MP2 = 0x15000,
        AV_CODEC_ID_MP3,
        AV_CODEC_ID_AAC,
        AV_CODEC_ID_AC3,
        AV_CODEC_ID_DTS,
        AV_CODEC_ID_VORBIS,
        AV_CODEC_ID_DVAUDIO,
        AV_CODEC_ID_WMAV1,
        AV_CODEC_ID_WMAV2,
        AV_CODEC_ID_MACE3,
        AV_CODEC_ID_MACE6,
        AV_CODEC_ID_VMDAUDIO,
        AV_CODEC_ID_FLAC,
        AV_CODEC_ID_MP3ADU,
        AV_CODEC_ID_MP3ON4,
        AV_CODEC_ID_SHORTEN,
        AV_CODEC_ID_ALAC,
        AV_CODEC_ID_WESTWOOD_SND1,
        AV_CODEC_ID_GSM,
        AV_CODEC_ID_QDM2,
        AV_CODEC_ID_COOK,
        AV_CODEC_ID_TRUESPEECH,
        AV_CODEC_ID_TTA,
        AV_CODEC_ID_SMACKAUDIO,
        AV_CODEC_ID_QCELP,
        AV_CODEC_ID_WAVPACK,
        AV_CODEC_ID_DSICINAUDIO,
        AV_CODEC_ID_IMC,
        AV_CODEC_ID_MUSEPACK7,
        AV_CODEC_ID_MLP,
        AV_CODEC_ID_GSM_MS,
        AV_CODEC_ID_ATRAC3,
        AV_CODEC_ID_APE,
        AV_CODEC_ID_NELLYMOSER,
        AV_CODEC_ID_MUSEPACK8,
        AV_CODEC_ID_SPEEX,
        AV_CODEC_ID_WMAVOICE,
        AV_CODEC_ID_WMAPRO,
        AV_CODEC_ID_WMALOSSLESS,
        AV_CODEC_ID_ATRAC3P,
        AV_CODEC_ID_EAC3,
        AV_CODEC_ID_SIPR,
        AV_CODEC_ID_MP1,
        AV_CODEC_ID_TWINVQ,
        AV_CODEC_ID_TRUEHD,
        AV_CODEC_ID_MP4ALS,
        AV_CODEC_ID_ATRAC1,
        AV_CODEC_ID_BINKAUDIO_RDFT,
        AV_CODEC_ID_BINKAUDIO_DCT,
        AV_CODEC_ID_AAC_LATM,
        AV_CODEC_ID_QDMC,
        AV_CODEC_ID_CELT,
        AV_CODEC_ID_G723_1,
        AV_CODEC_ID_G729,
        AV_CODEC_ID_8SVX_EXP,
        AV_CODEC_ID_8SVX_FIB,
        AV_CODEC_ID_BMV_AUDIO,
        AV_CODEC_ID_RALF,
        AV_CODEC_ID_IAC,
        AV_CODEC_ID_ILBC,
        AV_CODEC_ID_OPUS,
        AV_CODEC_ID_COMFORT_NOISE,
        AV_CODEC_ID_TAK,
        AV_CODEC_ID_METASOUND,
        AV_CODEC_ID_PAF_AUDIO,
        AV_CODEC_ID_ON2AVC,
        AV_CODEC_ID_DSS_SP,
        AV_CODEC_ID_CODEC2,
        AV_CODEC_ID_FFWAVESYNTH = 0x15800,
        AV_CODEC_ID_SONIC,
        AV_CODEC_ID_SONIC_LS,
        AV_CODEC_ID_EVRC,
        AV_CODEC_ID_SMV,
        AV_CODEC_ID_DSD_LSBF,
        AV_CODEC_ID_DSD_MSBF,
        AV_CODEC_ID_DSD_LSBF_PLANAR,
        AV_CODEC_ID_DSD_MSBF_PLANAR,
        AV_CODEC_ID_4GV,
        AV_CODEC_ID_INTERPLAY_ACM,
        AV_CODEC_ID_XMA1,
        AV_CODEC_ID_XMA2,
        AV_CODEC_ID_DST,
        AV_CODEC_ID_ATRAC3AL,
        AV_CODEC_ID_ATRAC3PAL,
        AV_CODEC_ID_DOLBY_E,
        AV_CODEC_ID_APTX,
        AV_CODEC_ID_APTX_HD,
        AV_CODEC_ID_SBC,
        AV_CODEC_ID_ATRAC9,
        AV_CODEC_ID_HCOM,
        AV_CODEC_ID_ACELP_KELVIN,
        AV_CODEC_ID_MPEGH_3D_AUDIO,
        AV_CODEC_ID_SIREN,
        AV_CODEC_ID_HCA,
        AV_CODEC_ID_FIRST_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVD_SUBTITLE = 0x17000,
        AV_CODEC_ID_DVB_SUBTITLE,
        AV_CODEC_ID_TEXT,
        AV_CODEC_ID_XSUB,
        AV_CODEC_ID_SSA,
        AV_CODEC_ID_MOV_TEXT,
        AV_CODEC_ID_HDMV_PGS_SUBTITLE,
        AV_CODEC_ID_DVB_TELETEXT,
        AV_CODEC_ID_SRT,
        AV_CODEC_ID_MICRODVD = 0x17800,
        AV_CODEC_ID_EIA_608,
        AV_CODEC_ID_JACOSUB,
        AV_CODEC_ID_SAMI,
        AV_CODEC_ID_REALTEXT,
        AV_CODEC_ID_STL,
        AV_CODEC_ID_SUBVIEWER1,
        AV_CODEC_ID_SUBVIEWER,
        AV_CODEC_ID_SUBRIP,
        AV_CODEC_ID_WEBVTT,
        AV_CODEC_ID_MPL2,
        AV_CODEC_ID_VPLAYER,
        AV_CODEC_ID_PJS,
        AV_CODEC_ID_ASS,
        AV_CODEC_ID_HDMV_TEXT_SUBTITLE,
        AV_CODEC_ID_TTML,
        AV_CODEC_ID_ARIB_CAPTION,
        AV_CODEC_ID_FIRST_UNKNOWN = 0x18000,
        AV_CODEC_ID_TTF = 0x18000,
        AV_CODEC_ID_SCTE_35,
        AV_CODEC_ID_EPG,
        AV_CODEC_ID_BINTEXT = 0x18800,
        AV_CODEC_ID_XBIN,
        AV_CODEC_ID_IDF,
        AV_CODEC_ID_OTF,
        AV_CODEC_ID_SMPTE_KLV,
        AV_CODEC_ID_DVD_NAV,
        AV_CODEC_ID_TIMED_ID3,
        AV_CODEC_ID_BIN_DATA,
        AV_CODEC_ID_PROBE = 0x19000,
        AV_CODEC_ID_MPEG2TS = 0x20000,
        AV_CODEC_ID_MPEG4SYSTEMS = 0x20001,
        AV_CODEC_ID_FFMETADATA = 0x21000,
        AV_CODEC_ID_WRAPPED_AVFRAME = 0x21001,
    }

    public enum AVFieldOrder
    {
        AV_FIELD_UNKNOWN,
        AV_FIELD_PROGRESSIVE,
        AV_FIELD_TT,
        AV_FIELD_BB,
        AV_FIELD_TB,
        AV_FIELD_BT,
    }

    public unsafe partial struct AVCodecParameters
    {
        [NativeTypeName("enum AVMediaType")]
        public AVMediaType codec_type;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID codec_id;

        [NativeTypeName("uint32_t")]
        public uint codec_tag;

        [NativeTypeName("uint8_t *")]
        public byte* extradata;

        public int extradata_size;

        public int format;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        public int bits_per_coded_sample;

        public int bits_per_raw_sample;

        public int profile;

        public int level;

        public int width;

        public int height;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("enum AVFieldOrder")]
        public AVFieldOrder field_order;

        [NativeTypeName("enum AVColorRange")]
        public AVColorRange color_range;

        [NativeTypeName("enum AVColorPrimaries")]
        public AVColorPrimaries color_primaries;

        [NativeTypeName("enum AVColorTransferCharacteristic")]
        public AVColorTransferCharacteristic color_trc;

        [NativeTypeName("enum AVColorSpace")]
        public AVColorSpace color_space;

        [NativeTypeName("enum AVChromaLocation")]
        public AVChromaLocation chroma_location;

        public int video_delay;

        [NativeTypeName("uint64_t")]
        public ulong channel_layout;

        public int channels;

        public int sample_rate;

        public int block_align;

        public int frame_size;

        public int initial_padding;

        public int trailing_padding;

        public int seek_preroll;
    }

    public enum AVPacketSideDataType
    {
        AV_PKT_DATA_PALETTE,
        AV_PKT_DATA_NEW_EXTRADATA,
        AV_PKT_DATA_PARAM_CHANGE,
        AV_PKT_DATA_H263_MB_INFO,
        AV_PKT_DATA_REPLAYGAIN,
        AV_PKT_DATA_DISPLAYMATRIX,
        AV_PKT_DATA_STEREO3D,
        AV_PKT_DATA_AUDIO_SERVICE_TYPE,
        AV_PKT_DATA_QUALITY_STATS,
        AV_PKT_DATA_FALLBACK_TRACK,
        AV_PKT_DATA_CPB_PROPERTIES,
        AV_PKT_DATA_SKIP_SAMPLES,
        AV_PKT_DATA_JP_DUALMONO,
        AV_PKT_DATA_STRINGS_METADATA,
        AV_PKT_DATA_SUBTITLE_POSITION,
        AV_PKT_DATA_MATROSKA_BLOCKADDITIONAL,
        AV_PKT_DATA_WEBVTT_IDENTIFIER,
        AV_PKT_DATA_WEBVTT_SETTINGS,
        AV_PKT_DATA_METADATA_UPDATE,
        AV_PKT_DATA_MPEGTS_STREAM_ID,
        AV_PKT_DATA_MASTERING_DISPLAY_METADATA,
        AV_PKT_DATA_SPHERICAL,
        AV_PKT_DATA_CONTENT_LIGHT_LEVEL,
        AV_PKT_DATA_A53_CC,
        AV_PKT_DATA_ENCRYPTION_INIT_INFO,
        AV_PKT_DATA_ENCRYPTION_INFO,
        AV_PKT_DATA_AFD,
        AV_PKT_DATA_PRFT,
        AV_PKT_DATA_ICC_PROFILE,
        AV_PKT_DATA_DOVI_CONF,
        AV_PKT_DATA_NB,
    }

    public unsafe partial struct AVPacketSideData
    {
        [NativeTypeName("uint8_t *")]
        public byte* data;

        public int size;

        [NativeTypeName("enum AVPacketSideDataType")]
        public AVPacketSideDataType type;
    }

    public enum AVSideDataParamChangeFlags
    {
        AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_COUNT = 0x0001,
        AV_SIDE_DATA_PARAM_CHANGE_CHANNEL_LAYOUT = 0x0002,
        AV_SIDE_DATA_PARAM_CHANGE_SAMPLE_RATE = 0x0004,
        AV_SIDE_DATA_PARAM_CHANGE_DIMENSIONS = 0x0008,
    }

    public static unsafe partial class FFmpegNative
    {
        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVRational av_codec_get_pkt_timebase([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_codec_set_pkt_timebase(AVCodecContext* avctx, AVRational val);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        [Obsolete]
        public static extern AVCodecDescriptor* av_codec_get_codec_descriptor([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_codec_set_codec_descriptor(AVCodecContext* avctx, [NativeTypeName("const AVCodecDescriptor *")] AVCodecDescriptor* desc);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        [Obsolete]
        public static extern uint av_codec_get_codec_properties([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_codec_get_lowres([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_codec_set_lowres(AVCodecContext* avctx, int val);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_codec_get_seek_preroll([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_codec_set_seek_preroll(AVCodecContext* avctx, int val);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint16_t *")]
        [Obsolete]
        public static extern ushort* av_codec_get_chroma_intra_matrix([NativeTypeName("const AVCodecContext *")] AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_codec_set_chroma_intra_matrix(AVCodecContext* avctx, [NativeTypeName("uint16_t *")] ushort* val);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_codec_get_max_lowres([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodec* av_codec_next([NativeTypeName("const AVCodec *")] AVCodec* c);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avcodec_version();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* avcodec_configuration();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* avcodec_license();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avcodec_register(AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avcodec_register_all();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecContext* avcodec_alloc_context3([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_free_context(AVCodecContext** avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_get_context_defaults3(AVCodecContext* s, [NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avcodec_get_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avcodec_get_frame_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avcodec_get_subtitle_rect_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avcodec_copy_context(AVCodecContext* dest, [NativeTypeName("const AVCodecContext *")] AVCodecContext* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_from_context(AVCodecParameters* par, [NativeTypeName("const AVCodecContext *")] AVCodecContext* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_to_context(AVCodecContext* codec, [NativeTypeName("const AVCodecParameters *")] AVCodecParameters* par);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_open2(AVCodecContext* avctx, [NativeTypeName("const AVCodec *")] AVCodec* codec, AVDictionary** options);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_close(AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avsubtitle_free(AVSubtitle* sub);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_get_buffer2(AVCodecContext* s, AVFrame* frame, int flags);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_align_dimensions(AVCodecContext* s, int* width, int* height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_align_dimensions2(AVCodecContext* s, int* width, int* height, [NativeTypeName("int[8]")] int* linesize_align);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_enum_to_chroma_pos(int* xpos, int* ypos, [NativeTypeName("enum AVChromaLocation")] AVChromaLocation pos);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVChromaLocation")]
        public static extern AVChromaLocation avcodec_chroma_pos_to_enum(int xpos, int ypos);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avcodec_decode_audio4(AVCodecContext* avctx, AVFrame* frame, int* got_frame_ptr, [NativeTypeName("const AVPacket *")] AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avcodec_decode_video2(AVCodecContext* avctx, AVFrame* picture, int* got_picture_ptr, [NativeTypeName("const AVPacket *")] AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_decode_subtitle2(AVCodecContext* avctx, AVSubtitle* sub, int* got_sub_ptr, AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_send_packet(AVCodecContext* avctx, [NativeTypeName("const AVPacket *")] AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_receive_frame(AVCodecContext* avctx, AVFrame* frame);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_send_frame(AVCodecContext* avctx, [NativeTypeName("const AVFrame *")] AVFrame* frame);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_receive_packet(AVCodecContext* avctx, AVPacket* avpkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_get_hw_frames_parameters(AVCodecContext* avctx, AVBufferRef* device_ref, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat hw_pix_fmt, AVBufferRef** out_frames_ref);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecParser *")]
        public static extern AVCodecParser* av_parser_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodecParser* av_parser_next([NativeTypeName("const AVCodecParser *")] AVCodecParser* c);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_codec_parser(AVCodecParser* parser);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecParserContext* av_parser_init(int codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_parser_parse2(AVCodecParserContext* s, AVCodecContext* avctx, [NativeTypeName("uint8_t **")] byte** poutbuf, int* poutbuf_size, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, [NativeTypeName("int64_t")] long pts, [NativeTypeName("int64_t")] long dts, [NativeTypeName("int64_t")] long pos);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_parser_change(AVCodecParserContext* s, AVCodecContext* avctx, [NativeTypeName("uint8_t **")] byte** poutbuf, int* poutbuf_size, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, int keyframe);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_parser_close(AVCodecParserContext* s);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avcodec_encode_audio2(AVCodecContext* avctx, AVPacket* avpkt, [NativeTypeName("const AVFrame *")] AVFrame* frame, int* got_packet_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avcodec_encode_video2(AVCodecContext* avctx, AVPacket* avpkt, [NativeTypeName("const AVFrame *")] AVFrame* frame, int* got_packet_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_encode_subtitle(AVCodecContext* avctx, [NativeTypeName("uint8_t *")] byte* buf, int buf_size, [NativeTypeName("const AVSubtitle *")] AVSubtitle* sub);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avpicture_alloc(AVPicture* picture, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avpicture_free(AVPicture* picture);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avpicture_fill(AVPicture* picture, [NativeTypeName("const uint8_t *")] byte* ptr, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avpicture_layout([NativeTypeName("const AVPicture *")] AVPicture* src, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height, [NativeTypeName("unsigned char *")] byte* dest, int dest_size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avpicture_get_size([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_picture_copy(AVPicture* dst, [NativeTypeName("const AVPicture *")] AVPicture* src, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int width, int height);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_picture_crop(AVPicture* dst, [NativeTypeName("const AVPicture *")] AVPicture* src, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int top_band, int left_band);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_picture_pad(AVPicture* dst, [NativeTypeName("const AVPicture *")] AVPicture* src, int height, int width, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int padtop, int padbottom, int padleft, int padright, int* color);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avcodec_get_chroma_sub_sample([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt, int* h_shift, int* v_shift);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avcodec_pix_fmt_to_codec_tag([NativeTypeName("enum AVPixelFormat")] AVPixelFormat pix_fmt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_get_pix_fmt_loss([NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_list([NativeTypeName("const enum AVPixelFormat *")] AVPixelFormat* pix_fmt_list, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt_of_2([NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt1, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt2, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        [Obsolete]
        public static extern AVPixelFormat avcodec_find_best_pix_fmt2([NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt1, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat dst_pix_fmt2, [NativeTypeName("enum AVPixelFormat")] AVPixelFormat src_pix_fmt, int has_alpha, int* loss_ptr);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVPixelFormat")]
        public static extern AVPixelFormat avcodec_default_get_format([NativeTypeName("struct AVCodecContext *")] AVCodecContext* s, [NativeTypeName("const enum AVPixelFormat *")] AVPixelFormat* fmt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("size_t")]
        [Obsolete]
        public static extern nuint av_get_codec_tag_string([NativeTypeName("char *")] byte* buf, [NativeTypeName("size_t")] nuint buf_size, [NativeTypeName("unsigned int")] uint codec_tag);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_string([NativeTypeName("char *")] byte* buf, int buf_size, AVCodecContext* enc, int encode);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* av_get_profile_name([NativeTypeName("const AVCodec *")] AVCodec* codec, int profile);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* avcodec_profile_name([NativeTypeName("enum AVCodecID")] AVCodecID codec_id, int profile);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_execute(AVCodecContext* c, [NativeTypeName("int (*)(AVCodecContext *, void *)")] delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int> func, void* arg, int* ret, int count, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_default_execute2(AVCodecContext* c, [NativeTypeName("int (*)(AVCodecContext *, void *, int, int)")] delegate* unmanaged[Cdecl]<AVCodecContext*, void*, int, int, int> func, void* arg, int* ret, int count);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_fill_audio_frame(AVFrame* frame, int nb_channels, [NativeTypeName("enum AVSampleFormat")] AVSampleFormat sample_fmt, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, int align);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_flush_buffers(AVCodecContext* avctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_bits_per_sample([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVCodecID")]
        public static extern AVCodecID av_get_pcm_codec([NativeTypeName("enum AVSampleFormat")] AVSampleFormat fmt, int be);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_exact_bits_per_sample([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_audio_frame_duration(AVCodecContext* avctx, int frame_bytes);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_audio_frame_duration2(AVCodecParameters* par, int frame_bytes);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_bitstream_filter(AVBitStreamFilter* bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVBitStreamFilterContext* av_bitstream_filter_init([NativeTypeName("const char *")] byte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_bitstream_filter_filter(AVBitStreamFilterContext* bsfc, AVCodecContext* avctx, [NativeTypeName("const char *")] byte* args, [NativeTypeName("uint8_t **")] byte** poutbuf, int* poutbuf_size, [NativeTypeName("const uint8_t *")] byte* buf, int buf_size, int keyframe);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_bitstream_filter_close(AVBitStreamFilterContext* bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        [Obsolete]
        public static extern AVBitStreamFilter* av_bitstream_filter_next([NativeTypeName("const AVBitStreamFilter *")] AVBitStreamFilter* f);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        [Obsolete]
        public static extern AVBitStreamFilter* av_bsf_next(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_fast_padded_malloc(void* ptr, [NativeTypeName("unsigned int *")] uint* size, [NativeTypeName("size_t")] nuint min_size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_fast_padded_mallocz(void* ptr, [NativeTypeName("unsigned int *")] uint* size, [NativeTypeName("size_t")] nuint min_size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint av_xiphlacing([NativeTypeName("unsigned char *")] byte* s, [NativeTypeName("unsigned int")] uint v);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_hwaccel(AVHWAccel* hwaccel);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVHWAccel* av_hwaccel_next([NativeTypeName("const AVHWAccel *")] AVHWAccel* hwaccel);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_lockmgr_register([NativeTypeName("int (*)(void **, enum AVLockOp)")] delegate* unmanaged[Cdecl]<void**, AVLockOp, int> cb);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_is_open(AVCodecContext* s);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCPBProperties* av_cpb_properties_alloc([NativeTypeName("size_t *")] nuint* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        public static extern AVBitStreamFilter* av_bsf_get_by_name([NativeTypeName("const char *")] byte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVBitStreamFilter *")]
        public static extern AVBitStreamFilter* av_bsf_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_alloc([NativeTypeName("const AVBitStreamFilter *")] AVBitStreamFilter* filter, AVBSFContext** ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_init(AVBSFContext* ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_send_packet(AVBSFContext* ctx, AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_receive_packet(AVBSFContext* ctx, AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_flush(AVBSFContext* ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_free(AVBSFContext** ctx);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* av_bsf_get_class();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVBSFList* av_bsf_list_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_bsf_list_free(AVBSFList** lst);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_append(AVBSFList* lst, AVBSFContext* bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_append2(AVBSFList* lst, [NativeTypeName("const char *")] byte* bsf_name, AVDictionary** options);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_finalize(AVBSFList** lst, AVBSFContext** bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_list_parse_str([NativeTypeName("const char *")] byte* str, AVBSFContext** bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_bsf_get_null_filter(AVBSFContext** bsf);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodec *")]
        public static extern AVCodec* av_codec_iterate(void** opaque);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodec* avcodec_find_decoder([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodec* avcodec_find_decoder_by_name([NativeTypeName("const char *")] byte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodec* avcodec_find_encoder([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodec* avcodec_find_encoder_by_name([NativeTypeName("const char *")] byte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_codec_is_encoder([NativeTypeName("const AVCodec *")] AVCodec* codec);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_codec_is_decoder([NativeTypeName("const AVCodec *")] AVCodec* codec);

        public const int AV_CODEC_HW_CONFIG_METHOD_HW_DEVICE_CTX = 0x01;
        public const int AV_CODEC_HW_CONFIG_METHOD_HW_FRAMES_CTX = 0x02;
        public const int AV_CODEC_HW_CONFIG_METHOD_INTERNAL = 0x04;
        public const int AV_CODEC_HW_CONFIG_METHOD_AD_HOC = 0x08;

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecHWConfig *")]
        public static extern AVCodecHWConfig* avcodec_get_hw_config([NativeTypeName("const AVCodec *")] AVCodec* codec, int index);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_next([NativeTypeName("const AVCodecDescriptor *")] AVCodecDescriptor* prev);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVCodecDescriptor *")]
        public static extern AVCodecDescriptor* avcodec_descriptor_get_by_name([NativeTypeName("const char *")] byte* name);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVMediaType")]
        public static extern AVMediaType avcodec_get_type([NativeTypeName("enum AVCodecID")] AVCodecID codec_id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* avcodec_get_name([NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVCodecParameters* avcodec_parameters_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avcodec_parameters_free(AVCodecParameters** par);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avcodec_parameters_copy(AVCodecParameters* dst, [NativeTypeName("const AVCodecParameters *")] AVCodecParameters* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacket* av_packet_alloc();

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVPacket* av_packet_clone([NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_free(AVPacket** pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_init_packet(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_new_packet(AVPacket* pkt, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_shrink_packet(AVPacket* pkt, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_grow_packet(AVPacket* pkt, int grow_by);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_from_data(AVPacket* pkt, [NativeTypeName("uint8_t *")] byte* data, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_dup_packet(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_copy_packet(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_copy_packet_side_data(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_free_packet(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_new_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_add_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_shrink_side_data(AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, int size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_get_side_data([NativeTypeName("const AVPacket *")] AVPacket* pkt, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, int* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_packet_merge_side_data(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_packet_split_side_data(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern byte* av_packet_side_data_name([NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_packet_pack_dictionary(AVDictionary* dict, int* size);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_unpack_dictionary([NativeTypeName("const uint8_t *")] byte* data, int size, AVDictionary** dict);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_free_side_data(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_ref(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_unref(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_move_ref(AVPacket* dst, AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_copy_props(AVPacket* dst, [NativeTypeName("const AVPacket *")] AVPacket* src);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_make_refcounted(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_packet_make_writable(AVPacket* pkt);

        [DllImport("avcodec", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_packet_rescale_ts(AVPacket* pkt, AVRational tb_src, AVRational tb_dst);
    }
}
