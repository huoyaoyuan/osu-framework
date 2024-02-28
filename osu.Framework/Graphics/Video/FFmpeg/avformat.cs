// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming style
#pragma warning disable IDE0027 // Use expression-body

using System;
using System.Runtime.InteropServices;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    public partial struct AVDeviceInfoList
    {
    }

    public partial struct AVDeviceCapabilitiesQuery
    {
    }

    public partial struct AVCodecTag
    {
    }

    public unsafe partial struct AVProbeData
    {
        [NativeTypeName("const char *")]
        public sbyte* filename;

        [NativeTypeName("unsigned char *")]
        public byte* buf;

        public int buf_size;

        [NativeTypeName("const char *")]
        public sbyte* mime_type;
    }

    public unsafe partial struct AVOutputFormat
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        [NativeTypeName("const char *")]
        public sbyte* mime_type;

        [NativeTypeName("const char *")]
        public sbyte* extensions;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID audio_codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID video_codec;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID subtitle_codec;

        public int flags;

        [NativeTypeName("const struct AVCodecTag *const *")]
        public AVCodecTag** codec_tag;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("struct AVOutputFormat *")]
        public AVOutputFormat* next;

        public int priv_data_size;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> write_header;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> write_packet;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> write_trailer;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVPacket *, AVPacket *, int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, AVPacket*, int, int> interleave_packet;

        [NativeTypeName("int (*)(enum AVCodecID, int)")]
        public delegate* unmanaged[Cdecl]<AVCodecID, int, int> query_codec;

        [NativeTypeName("void (*)(struct AVFormatContext *, int, int64_t *, int64_t *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long*, long*, void> get_output_timestamp;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, void *, size_t)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, void*, nuint, int> control_message;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, AVFrame **, unsigned int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, AVFrame**, uint, int> write_uncoded_frame;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceInfoList *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceInfoList*, int> get_device_list;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceCapabilitiesQuery *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceCapabilitiesQuery*, int> create_device_capabilities;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceCapabilitiesQuery *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceCapabilitiesQuery*, int> free_device_capabilities;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID data_codec;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> init;

        [NativeTypeName("void (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, void> deinit;

        [NativeTypeName("int (*)(struct AVFormatContext *, const AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> check_bitstream;
    }

    public unsafe partial struct AVInputFormat
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* long_name;

        public int flags;

        [NativeTypeName("const char *")]
        public sbyte* extensions;

        [NativeTypeName("const struct AVCodecTag *const *")]
        public AVCodecTag** codec_tag;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        [NativeTypeName("const char *")]
        public sbyte* mime_type;

        [NativeTypeName("struct AVInputFormat *")]
        public AVInputFormat* next;

        public int raw_codec_id;

        public int priv_data_size;

        [NativeTypeName("int (*)(const AVProbeData *)")]
        public delegate* unmanaged[Cdecl]<AVProbeData*, int> read_probe;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_header;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVPacket *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVPacket*, int> read_packet;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_close;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, int, int> read_seek;

        [NativeTypeName("int64_t (*)(struct AVFormatContext *, int, int64_t *, int64_t)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long*, long, long> read_timestamp;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_play;

        [NativeTypeName("int (*)(struct AVFormatContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int> read_pause;

        [NativeTypeName("int (*)(struct AVFormatContext *, int, int64_t, int64_t, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, long, long, long, int, int> read_seek2;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceInfoList *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceInfoList*, int> get_device_list;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceCapabilitiesQuery *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceCapabilitiesQuery*, int> create_device_capabilities;

        [NativeTypeName("int (*)(struct AVFormatContext *, struct AVDeviceCapabilitiesQuery *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVDeviceCapabilitiesQuery*, int> free_device_capabilities;
    }

    public enum AVStreamParseType
    {
        AVSTREAM_PARSE_NONE,
        AVSTREAM_PARSE_FULL,
        AVSTREAM_PARSE_HEADERS,
        AVSTREAM_PARSE_TIMESTAMPS,
        AVSTREAM_PARSE_FULL_ONCE,
        AVSTREAM_PARSE_FULL_RAW,
    }

    public partial struct AVIndexEntry
    {
        [NativeTypeName("int64_t")]
        public long pos;

        [NativeTypeName("int64_t")]
        public long timestamp;

        public int _bitfield;

        [NativeTypeName("int : 2")]
        public int flags
        {
            readonly get
            {
                return (_bitfield << 30) >> 30;
            }

            set
            {
                _bitfield = (_bitfield & ~0x3) | (value & 0x3);
            }
        }

        [NativeTypeName("int : 30")]
        public int size
        {
            readonly get
            {
                return (_bitfield << 0) >> 2;
            }

            set
            {
                _bitfield = (_bitfield & ~(0x3FFFFFFF << 2)) | ((value & 0x3FFFFFFF) << 2);
            }
        }

        public int min_distance;
    }

    public partial struct AVStreamInternal
    {
    }

    public unsafe partial struct AVStream
    {
        public int index;

        public int id;

        [Obsolete]
        public AVCodecContext* codec;

        public void* priv_data;

        public AVRational time_base;

        [NativeTypeName("int64_t")]
        public long start_time;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long nb_frames;

        public int disposition;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard discard;

        public AVRational sample_aspect_ratio;

        public AVDictionary* metadata;

        public AVRational avg_frame_rate;

        public AVPacket attached_pic;

        public AVPacketSideData* side_data;

        public int nb_side_data;

        public int event_flags;

        public AVRational r_frame_rate;

        [NativeTypeName("char *")]
        [Obsolete]
        public sbyte* recommended_encoder_configuration;

        public AVCodecParameters* codecpar;

        [NativeTypeName("struct (anonymous struct at ffmpeg-4.3.3/libavformat/avformat.h:1030:5) *")]
        public _Anonymous_e__Struct* info;

        public int pts_wrap_bits;

        [NativeTypeName("int64_t")]
        public long first_dts;

        [NativeTypeName("int64_t")]
        public long cur_dts;

        [NativeTypeName("int64_t")]
        public long last_IP_pts;

        public int last_IP_duration;

        public int probe_packets;

        public int codec_info_nb_frames;

        [NativeTypeName("enum AVStreamParseType")]
        public AVStreamParseType need_parsing;

        [NativeTypeName("struct AVCodecParserContext *")]
        public AVCodecParserContext* parser;

        [NativeTypeName("struct AVPacketList *")]
        public AVPacketList* last_in_packet_buffer;

        public AVProbeData probe_data;

        [NativeTypeName("int64_t[17]")]
        public fixed long pts_buffer[17];

        public AVIndexEntry* index_entries;

        public int nb_index_entries;

        [NativeTypeName("unsigned int")]
        public uint index_entries_allocated_size;

        public int stream_identifier;

        public int program_num;

        public int pmt_version;

        public int pmt_stream_idx;

        [NativeTypeName("int64_t")]
        public long interleaver_chunk_size;

        [NativeTypeName("int64_t")]
        public long interleaver_chunk_duration;

        public int request_probe;

        public int skip_to_keyframe;

        public int skip_samples;

        [NativeTypeName("int64_t")]
        public long start_skip_samples;

        [NativeTypeName("int64_t")]
        public long first_discard_sample;

        [NativeTypeName("int64_t")]
        public long last_discard_sample;

        public int nb_decoded_frames;

        [NativeTypeName("int64_t")]
        public long mux_ts_offset;

        [NativeTypeName("int64_t")]
        public long pts_wrap_reference;

        public int pts_wrap_behavior;

        public int update_initial_durations_done;

        [NativeTypeName("int64_t[17]")]
        public fixed long pts_reorder_error[17];

        [NativeTypeName("uint8_t[17]")]
        public fixed byte pts_reorder_error_count[17];

        [NativeTypeName("int64_t")]
        public long last_dts_for_order_check;

        [NativeTypeName("uint8_t")]
        public byte dts_ordered;

        [NativeTypeName("uint8_t")]
        public byte dts_misordered;

        public int inject_global_side_data;

        public AVRational display_aspect_ratio;

        public AVStreamInternal* @internal;

        public unsafe partial struct _Anonymous_e__Struct
        {
            [NativeTypeName("int64_t")]
            public long last_dts;

            [NativeTypeName("int64_t")]
            public long duration_gcd;

            public int duration_count;

            [NativeTypeName("int64_t")]
            public long rfps_duration_sum;

            [NativeTypeName("double (*)[2][399]")]
            public double* duration_error;

            [NativeTypeName("int64_t")]
            public long codec_info_duration;

            [NativeTypeName("int64_t")]
            public long codec_info_duration_fields;

            public int frame_delay_evidence;

            public int found_decoder;

            [NativeTypeName("int64_t")]
            public long last_duration;

            [NativeTypeName("int64_t")]
            public long fps_first_dts;

            public int fps_first_dts_idx;

            [NativeTypeName("int64_t")]
            public long fps_last_dts;

            public int fps_last_dts_idx;
        }
    }

    public unsafe partial struct AVProgram
    {
        public int id;

        public int flags;

        [NativeTypeName("enum AVDiscard")]
        public AVDiscard discard;

        [NativeTypeName("unsigned int *")]
        public uint* stream_index;

        [NativeTypeName("unsigned int")]
        public uint nb_stream_indexes;

        public AVDictionary* metadata;

        public int program_num;

        public int pmt_pid;

        public int pcr_pid;

        public int pmt_version;

        [NativeTypeName("int64_t")]
        public long start_time;

        [NativeTypeName("int64_t")]
        public long end_time;

        [NativeTypeName("int64_t")]
        public long pts_wrap_reference;

        public int pts_wrap_behavior;
    }

    public unsafe partial struct AVChapter
    {
        public int id;

        public AVRational time_base;

        [NativeTypeName("int64_t")]
        public long start;

        [NativeTypeName("int64_t")]
        public long end;

        public AVDictionary* metadata;
    }

    public enum AVDurationEstimationMethod
    {
        AVFMT_DURATION_FROM_PTS,
        AVFMT_DURATION_FROM_STREAM,
        AVFMT_DURATION_FROM_BITRATE,
    }

    public partial struct AVFormatInternal
    {
    }

    public unsafe partial struct AVFormatContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("struct AVInputFormat *")]
        public AVInputFormat* iformat;

        [NativeTypeName("struct AVOutputFormat *")]
        public AVOutputFormat* oformat;

        public void* priv_data;

        public AVIOContext* pb;

        public int ctx_flags;

        [NativeTypeName("unsigned int")]
        public uint nb_streams;

        public AVStream** streams;

        [NativeTypeName("char[1024]")]
        [Obsolete]
        public fixed sbyte filename[1024];

        [NativeTypeName("char *")]
        public sbyte* url;

        [NativeTypeName("int64_t")]
        public long start_time;

        [NativeTypeName("int64_t")]
        public long duration;

        [NativeTypeName("int64_t")]
        public long bit_rate;

        [NativeTypeName("unsigned int")]
        public uint packet_size;

        public int max_delay;

        public int flags;

        [NativeTypeName("int64_t")]
        public long probesize;

        [NativeTypeName("int64_t")]
        public long max_analyze_duration;

        [NativeTypeName("const uint8_t *")]
        public byte* key;

        public int keylen;

        [NativeTypeName("unsigned int")]
        public uint nb_programs;

        public AVProgram** programs;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID video_codec_id;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID audio_codec_id;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID subtitle_codec_id;

        [NativeTypeName("unsigned int")]
        public uint max_index_size;

        [NativeTypeName("unsigned int")]
        public uint max_picture_buffer;

        [NativeTypeName("unsigned int")]
        public uint nb_chapters;

        public AVChapter** chapters;

        public AVDictionary* metadata;

        [NativeTypeName("int64_t")]
        public long start_time_realtime;

        public int fps_probe_size;

        public int error_recognition;

        public AVIOInterruptCB interrupt_callback;

        public int debug;

        [NativeTypeName("int64_t")]
        public long max_interleave_delta;

        public int strict_std_compliance;

        public int event_flags;

        public int max_ts_probe;

        public int avoid_negative_ts;

        public int ts_id;

        public int audio_preload;

        public int max_chunk_duration;

        public int max_chunk_size;

        public int use_wallclock_as_timestamps;

        public int avio_flags;

        [NativeTypeName("enum AVDurationEstimationMethod")]
        public AVDurationEstimationMethod duration_estimation_method;

        [NativeTypeName("int64_t")]
        public long skip_initial_bytes;

        [NativeTypeName("unsigned int")]
        public uint correct_ts_overflow;

        public int seek2any;

        public int flush_packets;

        public int probe_score;

        public int format_probesize;

        [NativeTypeName("char *")]
        public sbyte* codec_whitelist;

        [NativeTypeName("char *")]
        public sbyte* format_whitelist;

        public AVFormatInternal* @internal;

        public int io_repositioned;

        public AVCodec* video_codec;

        public AVCodec* audio_codec;

        public AVCodec* subtitle_codec;

        public AVCodec* data_codec;

        public int metadata_header_padding;

        public void* opaque;

        [NativeTypeName("av_format_control_message")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, int, void*, nuint, int> control_message_cb;

        [NativeTypeName("int64_t")]
        public long output_ts_offset;

        [NativeTypeName("uint8_t *")]
        public byte* dump_separator;

        [NativeTypeName("enum AVCodecID")]
        public AVCodecID data_codec_id;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVIOContext **, const char *, int, const AVIOInterruptCB *, AVDictionary **)")]
        [Obsolete]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVIOContext**, sbyte*, int, AVIOInterruptCB*, AVDictionary**, int> open_cb;

        [NativeTypeName("char *")]
        public sbyte* protocol_whitelist;

        [NativeTypeName("int (*)(struct AVFormatContext *, AVIOContext **, const char *, int, AVDictionary **)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVIOContext**, sbyte*, int, AVDictionary**, int> io_open;

        [NativeTypeName("void (*)(struct AVFormatContext *, AVIOContext *)")]
        public delegate* unmanaged[Cdecl]<AVFormatContext*, AVIOContext*, void> io_close;

        [NativeTypeName("char *")]
        public sbyte* protocol_blacklist;

        public int max_streams;

        public int skip_estimate_duration_from_pts;

        public int max_probe_packets;
    }

    public unsafe partial struct AVPacketList
    {
        public AVPacket pkt;

        [NativeTypeName("struct AVPacketList *")]
        public AVPacketList* next;
    }

    public enum AVTimebaseSource
    {
        AVFMT_TBCF_AUTO = -1,
        AVFMT_TBCF_DECODER,
        AVFMT_TBCF_DEMUXER,
        AVFMT_TBCF_R_FRAMERATE,
    }

    public unsafe partial struct AVIOInterruptCB
    {
        [NativeTypeName("int (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, int> callback;

        public void* opaque;
    }

    public enum AVIODirEntryType
    {
        AVIO_ENTRY_UNKNOWN,
        AVIO_ENTRY_BLOCK_DEVICE,
        AVIO_ENTRY_CHARACTER_DEVICE,
        AVIO_ENTRY_DIRECTORY,
        AVIO_ENTRY_NAMED_PIPE,
        AVIO_ENTRY_SYMBOLIC_LINK,
        AVIO_ENTRY_SOCKET,
        AVIO_ENTRY_FILE,
        AVIO_ENTRY_SERVER,
        AVIO_ENTRY_SHARE,
        AVIO_ENTRY_WORKGROUP,
    }

    public unsafe partial struct AVIODirEntry
    {
        [NativeTypeName("char *")]
        public sbyte* name;

        public int type;

        public int utf8;

        [NativeTypeName("int64_t")]
        public long size;

        [NativeTypeName("int64_t")]
        public long modification_timestamp;

        [NativeTypeName("int64_t")]
        public long access_timestamp;

        [NativeTypeName("int64_t")]
        public long status_change_timestamp;

        [NativeTypeName("int64_t")]
        public long user_id;

        [NativeTypeName("int64_t")]
        public long group_id;

        [NativeTypeName("int64_t")]
        public long filemode;
    }

    public unsafe partial struct AVIODirContext
    {
        [NativeTypeName("struct URLContext *")]
        public URLContext* url_context;

        public partial struct URLContext
        {
        }
    }

    public enum AVIODataMarkerType
    {
        AVIO_DATA_MARKER_HEADER,
        AVIO_DATA_MARKER_SYNC_POINT,
        AVIO_DATA_MARKER_BOUNDARY_POINT,
        AVIO_DATA_MARKER_UNKNOWN,
        AVIO_DATA_MARKER_TRAILER,
        AVIO_DATA_MARKER_FLUSH_POINT,
    }

    public unsafe partial struct AVIOContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("unsigned char *")]
        public byte* buffer;

        public int buffer_size;

        [NativeTypeName("unsigned char *")]
        public byte* buf_ptr;

        [NativeTypeName("unsigned char *")]
        public byte* buf_end;

        public void* opaque;

        [NativeTypeName("int (*)(void *, uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, int> read_packet;

        [NativeTypeName("int (*)(void *, uint8_t *, int)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, int> write_packet;

        [NativeTypeName("int64_t (*)(void *, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<void*, long, int, long> seek;

        [NativeTypeName("int64_t")]
        public long pos;

        public int eof_reached;

        public int write_flag;

        public int max_packet_size;

        [NativeTypeName("unsigned long")]
        public nuint checksum;

        [NativeTypeName("unsigned char *")]
        public byte* checksum_ptr;

        [NativeTypeName("unsigned long (*)(unsigned long, const uint8_t *, unsigned int)")]
        public delegate* unmanaged[Cdecl]<nuint, byte*, uint, nuint> update_checksum;

        public int error;

        [NativeTypeName("int (*)(void *, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, int> read_pause;

        [NativeTypeName("int64_t (*)(void *, int, int64_t, int)")]
        public delegate* unmanaged[Cdecl]<void*, int, long, int, long> read_seek;

        public int seekable;

        [NativeTypeName("int64_t")]
        public long maxsize;

        public int direct;

        [NativeTypeName("int64_t")]
        public long bytes_read;

        public int seek_count;

        public int writeout_count;

        public int orig_buffer_size;

        public int short_seek_threshold;

        [NativeTypeName("const char *")]
        public sbyte* protocol_whitelist;

        [NativeTypeName("const char *")]
        public sbyte* protocol_blacklist;

        [NativeTypeName("int (*)(void *, uint8_t *, int, enum AVIODataMarkerType, int64_t)")]
        public delegate* unmanaged[Cdecl]<void*, byte*, int, AVIODataMarkerType, long, int> write_data_type;

        public int ignore_boundary_point;

        [NativeTypeName("enum AVIODataMarkerType")]
        public AVIODataMarkerType current_type;

        [NativeTypeName("int64_t")]
        public long last_time;

        [NativeTypeName("int (*)(void *)")]
        public delegate* unmanaged[Cdecl]<void*, int> short_seek_get;

        [NativeTypeName("int64_t")]
        public long written;

        [NativeTypeName("unsigned char *")]
        public byte* buf_ptr_max;

        public int min_packet_size;
    }

    public partial struct AVBPrint
    {
    }

    public static unsafe partial class FFmpegNative
    {
        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_packet(AVIOContext* s, AVPacket* pkt, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_append_packet(AVIOContext* s, AVPacket* pkt, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVRational av_stream_get_r_frame_rate([NativeTypeName("const AVStream *")] AVStream* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_stream_set_r_frame_rate(AVStream* s, AVRational r);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        [Obsolete]
        public static extern sbyte* av_stream_get_recommended_encoder_configuration([NativeTypeName("const AVStream *")] AVStream* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_stream_set_recommended_encoder_configuration(AVStream* s, [NativeTypeName("char *")] sbyte* configuration);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("struct AVCodecParserContext *")]
        public static extern AVCodecParserContext* av_stream_get_parser([NativeTypeName("const AVStream *")] AVStream* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long av_stream_get_end_pts([NativeTypeName("const AVStream *")] AVStream* st);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_format_get_probe_score([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodec* av_format_get_video_codec([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_video_codec(AVFormatContext* s, AVCodec* c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodec* av_format_get_audio_codec([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_audio_codec(AVFormatContext* s, AVCodec* c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodec* av_format_get_subtitle_codec([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_subtitle_codec(AVFormatContext* s, AVCodec* c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVCodec* av_format_get_data_codec([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_data_codec(AVFormatContext* s, AVCodec* c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_format_get_metadata_header_padding([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_metadata_header_padding(AVFormatContext* s, int c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void* av_format_get_opaque([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_opaque(AVFormatContext* s, void* opaque);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("av_format_control_message")]
        [Obsolete]
        public static extern delegate* unmanaged[Cdecl]<AVFormatContext*, int, void*, nuint, int> av_format_get_control_message_cb([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_control_message_cb(AVFormatContext* s, [NativeTypeName("av_format_control_message")] delegate* unmanaged[Cdecl]<AVFormatContext*, int, void*, nuint, int> callback);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("AVOpenCallback")]
        [Obsolete]
        public static extern delegate* unmanaged[Cdecl]<AVFormatContext*, AVIOContext**, sbyte*, int, AVIOInterruptCB*, AVDictionary**, int> av_format_get_open_cb([NativeTypeName("const AVFormatContext *")] AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_format_set_open_cb(AVFormatContext* s, [NativeTypeName("AVOpenCallback")] delegate* unmanaged[Cdecl]<AVFormatContext*, AVIOContext**, sbyte*, int, AVIOInterruptCB*, AVDictionary**, int> callback);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_format_inject_global_side_data(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVDurationEstimationMethod")]
        public static extern AVDurationEstimationMethod av_fmt_ctx_get_duration_estimation_method([NativeTypeName("const AVFormatContext *")] AVFormatContext* ctx);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avformat_version();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avformat_configuration();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avformat_license();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_all();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_input_format(AVInputFormat* format);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void av_register_output_format(AVOutputFormat* format);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_network_init();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_network_deinit();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVInputFormat* av_iformat_next([NativeTypeName("const AVInputFormat *")] AVInputFormat* f);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern AVOutputFormat* av_oformat_next([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* f);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVOutputFormat *")]
        public static extern AVOutputFormat* av_muxer_iterate(void** opaque);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVInputFormat *")]
        public static extern AVInputFormat* av_demuxer_iterate(void** opaque);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFormatContext* avformat_alloc_context();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avformat_free_context(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avformat_get_class();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVStream* avformat_new_stream(AVFormatContext* s, [NativeTypeName("const AVCodec *")] AVCodec* c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_stream_add_side_data(AVStream* st, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, [NativeTypeName("uint8_t *")] byte* data, [NativeTypeName("size_t")] nuint size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_stream_new_side_data(AVStream* stream, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint8_t *")]
        public static extern byte* av_stream_get_side_data([NativeTypeName("const AVStream *")] AVStream* stream, [NativeTypeName("enum AVPacketSideDataType")] AVPacketSideDataType type, int* size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVProgram* av_new_program(AVFormatContext* s, int id);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_alloc_output_context2(AVFormatContext** ctx, AVOutputFormat* oformat, [NativeTypeName("const char *")] sbyte* format_name, [NativeTypeName("const char *")] sbyte* filename);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVInputFormat* av_find_input_format([NativeTypeName("const char *")] sbyte* short_name);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVInputFormat* av_probe_input_format(AVProbeData* pd, int is_opened);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVInputFormat* av_probe_input_format2(AVProbeData* pd, int is_opened, int* score_max);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVInputFormat* av_probe_input_format3(AVProbeData* pd, int is_opened, int* score_ret);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_probe_input_buffer2(AVIOContext* pb, AVInputFormat** fmt, [NativeTypeName("const char *")] sbyte* url, void* logctx, [NativeTypeName("unsigned int")] uint offset, [NativeTypeName("unsigned int")] uint max_probe_size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_probe_input_buffer(AVIOContext* pb, AVInputFormat** fmt, [NativeTypeName("const char *")] sbyte* url, void* logctx, [NativeTypeName("unsigned int")] uint offset, [NativeTypeName("unsigned int")] uint max_probe_size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_open_input(AVFormatContext** ps, [NativeTypeName("const char *")] sbyte* url, AVInputFormat* fmt, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_demuxer_open(AVFormatContext* ic);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_find_stream_info(AVFormatContext* ic, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVProgram* av_find_program_from_stream(AVFormatContext* ic, AVProgram* last, int s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_program_add_stream_index(AVFormatContext* ac, int progid, [NativeTypeName("unsigned int")] uint idx);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_find_best_stream(AVFormatContext* ic, [NativeTypeName("enum AVMediaType")] AVMediaType type, int wanted_stream_nb, int related_stream, AVCodec** decoder_ret, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_read_frame(AVFormatContext* s, AVPacket* pkt);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_seek_frame(AVFormatContext* s, int stream_index, [NativeTypeName("int64_t")] long timestamp, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_seek_file(AVFormatContext* s, int stream_index, [NativeTypeName("int64_t")] long min_ts, [NativeTypeName("int64_t")] long ts, [NativeTypeName("int64_t")] long max_ts, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_flush(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_read_play(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_read_pause(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avformat_close_input(AVFormatContext** s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_write_header(AVFormatContext* s, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_init_output(AVFormatContext* s, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_write_frame(AVFormatContext* s, AVPacket* pkt);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_interleaved_write_frame(AVFormatContext* s, AVPacket* pkt);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_interleaved_write_uncoded_frame(AVFormatContext* s, int stream_index, AVFrame* frame);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_write_uncoded_frame_query(AVFormatContext* s, int stream_index);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_write_trailer(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVOutputFormat* av_guess_format([NativeTypeName("const char *")] sbyte* short_name, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const char *")] sbyte* mime_type);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVCodecID")]
        public static extern AVCodecID av_guess_codec(AVOutputFormat* fmt, [NativeTypeName("const char *")] sbyte* short_name, [NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const char *")] sbyte* mime_type, [NativeTypeName("enum AVMediaType")] AVMediaType type);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_output_timestamp([NativeTypeName("struct AVFormatContext *")] AVFormatContext* s, int stream, [NativeTypeName("int64_t *")] long* dts, [NativeTypeName("int64_t *")] long* wall);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_hex_dump_log(void* avcl, int level, [NativeTypeName("const uint8_t *")] byte* buf, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_pkt_dump_log2(void* avcl, int level, [NativeTypeName("const AVPacket *")] AVPacket* pkt, int dump_payload, [NativeTypeName("const AVStream *")] AVStream* st);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVCodecID")]
        public static extern AVCodecID av_codec_get_id([NativeTypeName("const struct AVCodecTag *const *")] AVCodecTag** tags, [NativeTypeName("unsigned int")] uint tag);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint av_codec_get_tag([NativeTypeName("const struct AVCodecTag *const *")] AVCodecTag** tags, [NativeTypeName("enum AVCodecID")] AVCodecID id);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_codec_get_tag2([NativeTypeName("const struct AVCodecTag *const *")] AVCodecTag** tags, [NativeTypeName("enum AVCodecID")] AVCodecID id, [NativeTypeName("unsigned int *")] uint* tag);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_find_default_stream_index(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_index_search_timestamp(AVStream* st, [NativeTypeName("int64_t")] long timestamp, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_add_index_entry(AVStream* st, [NativeTypeName("int64_t")] long pos, [NativeTypeName("int64_t")] long timestamp, int size, int distance, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_url_split([NativeTypeName("char *")] sbyte* proto, int proto_size, [NativeTypeName("char *")] sbyte* authorization, int authorization_size, [NativeTypeName("char *")] sbyte* hostname, int hostname_size, int* port_ptr, [NativeTypeName("char *")] sbyte* path, int path_size, [NativeTypeName("const char *")] sbyte* url);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void av_dump_format(AVFormatContext* ic, int index, [NativeTypeName("const char *")] sbyte* url, int is_output);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_frame_filename2([NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("const char *")] sbyte* path, int number, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_get_frame_filename([NativeTypeName("char *")] sbyte* buf, int buf_size, [NativeTypeName("const char *")] sbyte* path, int number);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_filename_number_test([NativeTypeName("const char *")] sbyte* filename);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_sdp_create([NativeTypeName("AVFormatContext *[]")] AVFormatContext** ac, int n_files, [NativeTypeName("char *")] sbyte* buf, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int av_match_ext([NativeTypeName("const char *")] sbyte* filename, [NativeTypeName("const char *")] sbyte* extensions);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_query_codec([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* ofmt, [NativeTypeName("enum AVCodecID")] AVCodecID codec_id, int std_compliance);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct AVCodecTag *")]
        public static extern AVCodecTag* avformat_get_riff_video_tags();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct AVCodecTag *")]
        public static extern AVCodecTag* avformat_get_riff_audio_tags();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct AVCodecTag *")]
        public static extern AVCodecTag* avformat_get_mov_video_tags();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const struct AVCodecTag *")]
        public static extern AVCodecTag* avformat_get_mov_audio_tags();

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_guess_sample_aspect_ratio(AVFormatContext* format, AVStream* stream, AVFrame* frame);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_guess_frame_rate(AVFormatContext* ctx, AVStream* stream, AVFrame* frame);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_match_stream_specifier(AVFormatContext* s, AVStream* st, [NativeTypeName("const char *")] sbyte* spec);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_queue_attached_pictures(AVFormatContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int av_apply_bitstream_filters(AVCodecContext* codec, AVPacket* pkt, AVBitStreamFilterContext* bsfc);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avformat_transfer_internal_stream_timing_info([NativeTypeName("const AVOutputFormat *")] AVOutputFormat* ofmt, AVStream* ost, [NativeTypeName("const AVStream *")] AVStream* ist, [NativeTypeName("enum AVTimebaseSource")] AVTimebaseSource copy_tb);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVRational av_stream_get_codec_timebase([NativeTypeName("const AVStream *")] AVStream* st);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avio_find_protocol_name([NativeTypeName("const char *")] sbyte* url);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_check([NativeTypeName("const char *")] sbyte* url, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avpriv_io_move([NativeTypeName("const char *")] sbyte* url_src, [NativeTypeName("const char *")] sbyte* url_dst);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avpriv_io_delete([NativeTypeName("const char *")] sbyte* url);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_open_dir(AVIODirContext** s, [NativeTypeName("const char *")] sbyte* url, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_read_dir(AVIODirContext* s, AVIODirEntry** next);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_close_dir(AVIODirContext** s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_free_directory_entry(AVIODirEntry** entry);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVIOContext* avio_alloc_context([NativeTypeName("unsigned char *")] byte* buffer, int buffer_size, int write_flag, void* opaque, [NativeTypeName("int (*)(void *, uint8_t *, int)")] delegate* unmanaged[Cdecl]<void*, byte*, int, int> read_packet, [NativeTypeName("int (*)(void *, uint8_t *, int)")] delegate* unmanaged[Cdecl]<void*, byte*, int, int> write_packet, [NativeTypeName("int64_t (*)(void *, int64_t, int)")] delegate* unmanaged[Cdecl]<void*, long, int, long> seek);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_context_free(AVIOContext** s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_w8(AVIOContext* s, int b);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_write(AVIOContext* s, [NativeTypeName("const unsigned char *")] byte* buf, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wl64(AVIOContext* s, [NativeTypeName("uint64_t")] ulong val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wb64(AVIOContext* s, [NativeTypeName("uint64_t")] ulong val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wl32(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wb32(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wl24(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wb24(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wl16(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_wb16(AVIOContext* s, [NativeTypeName("unsigned int")] uint val);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_put_str(AVIOContext* s, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_put_str16le(AVIOContext* s, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_put_str16be(AVIOContext* s, [NativeTypeName("const char *")] sbyte* str);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_write_marker(AVIOContext* s, [NativeTypeName("int64_t")] long time, [NativeTypeName("enum AVIODataMarkerType")] AVIODataMarkerType type);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long avio_seek(AVIOContext* s, [NativeTypeName("int64_t")] long offset, int whence);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long avio_skip(AVIOContext* s, [NativeTypeName("int64_t")] long offset);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long avio_size(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_feof(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_printf(AVIOContext* s, [NativeTypeName("const char *")] sbyte* fmt, __arglist);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_print_string_array(AVIOContext* s, [NativeTypeName("const char *[]")] sbyte** strings);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avio_flush(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_read(AVIOContext* s, [NativeTypeName("unsigned char *")] byte* buf, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_read_partial(AVIOContext* s, [NativeTypeName("unsigned char *")] byte* buf, int size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_r8(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rl16(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rl24(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rl32(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong avio_rl64(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rb16(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rb24(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avio_rb32(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("uint64_t")]
        public static extern ulong avio_rb64(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_get_str(AVIOContext* pb, int maxlen, [NativeTypeName("char *")] sbyte* buf, int buflen);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_get_str16le(AVIOContext* pb, int maxlen, [NativeTypeName("char *")] sbyte* buf, int buflen);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_get_str16be(AVIOContext* pb, int maxlen, [NativeTypeName("char *")] sbyte* buf, int buflen);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_open(AVIOContext** s, [NativeTypeName("const char *")] sbyte* url, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_open2(AVIOContext** s, [NativeTypeName("const char *")] sbyte* url, int flags, [NativeTypeName("const AVIOInterruptCB *")] AVIOInterruptCB* int_cb, AVDictionary** options);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_close(AVIOContext* s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_closep(AVIOContext** s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_open_dyn_buf(AVIOContext** s);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_get_dyn_buf(AVIOContext* s, [NativeTypeName("uint8_t **")] byte** pbuffer);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_close_dyn_buf(AVIOContext* s, [NativeTypeName("uint8_t **")] byte** pbuffer);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avio_enum_protocols(void** opaque, int output);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avio_protocol_get_class([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_pause(AVIOContext* h, int pause);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("int64_t")]
        public static extern long avio_seek_time(AVIOContext* h, int stream_index, [NativeTypeName("int64_t")] long timestamp, int flags);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_read_to_bprint(AVIOContext* h, [NativeTypeName("struct AVBPrint *")] AVBPrint* pb, [NativeTypeName("size_t")] nuint max_size);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_accept(AVIOContext* s, AVIOContext** c);

        [DllImport("avformat", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avio_handshake(AVIOContext* c);
    }
}
