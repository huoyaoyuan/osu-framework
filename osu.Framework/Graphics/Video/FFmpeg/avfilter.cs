// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

// ReSharper disable InconsistentNaming
#pragma warning disable IDE1006 // Naming style
#pragma warning disable IDE0027 // Use expression-body

using System;
using System.Runtime.InteropServices;

namespace osu.Framework.Graphics.Video.FFmpeg
{
    internal partial struct AVFilterPad
    {
    }

    internal partial struct AVFilterFormats
    {
    }

    internal unsafe partial struct AVFilter
    {
        [NativeTypeName("const char *")]
        public sbyte* name;

        [NativeTypeName("const char *")]
        public sbyte* description;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* inputs;

        [NativeTypeName("const AVFilterPad *")]
        public AVFilterPad* outputs;

        [NativeTypeName("const AVClass *")]
        public AVClass* priv_class;

        public int flags;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> preinit;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> init;

        [NativeTypeName("int (*)(AVFilterContext *, AVDictionary **)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, AVDictionary**, int> init_dict;

        [NativeTypeName("void (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, void> uninit;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> query_formats;

        public int priv_size;

        public int flags_internal;

        [NativeTypeName("struct AVFilter *")]
        public AVFilter* next;

        [NativeTypeName("int (*)(AVFilterContext *, const char *, const char *, char *, int, int)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, sbyte*, sbyte*, sbyte*, int, int, int> process_command;

        [NativeTypeName("int (*)(AVFilterContext *, void *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, void*, int> init_opaque;

        [NativeTypeName("int (*)(AVFilterContext *)")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, int> activate;
    }

    internal partial struct AVFilterInternal
    {
    }

    internal unsafe partial struct AVFilterContext
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        [NativeTypeName("const AVFilter *")]
        public AVFilter* filter;

        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterPad* input_pads;

        public AVFilterLink** inputs;

        [NativeTypeName("unsigned int")]
        public uint nb_inputs;

        public AVFilterPad* output_pads;

        public AVFilterLink** outputs;

        [NativeTypeName("unsigned int")]
        public uint nb_outputs;

        public void* priv;

        [NativeTypeName("struct AVFilterGraph *")]
        public AVFilterGraph* graph;

        public int thread_type;

        public AVFilterInternal* @internal;

        [NativeTypeName("struct AVFilterCommand *")]
        public AVFilterCommand* command_queue;

        [NativeTypeName("char *")]
        public sbyte* enable_str;

        public void* enable;

        public double* var_values;

        public int is_disabled;

        public AVBufferRef* hw_device_ctx;

        public int nb_threads;

        [NativeTypeName("unsigned int")]
        public uint ready;

        public int extra_hw_frames;

        internal partial struct AVFilterCommand
        {
        }
    }

    internal unsafe partial struct AVFilterLink
    {
        public AVFilterContext* src;

        public AVFilterPad* srcpad;

        public AVFilterContext* dst;

        public AVFilterPad* dstpad;

        [NativeTypeName("enum AVMediaType")]
        public AVMediaType type;

        public int w;

        public int h;

        public AVRational sample_aspect_ratio;

        [NativeTypeName("uint64_t")]
        public ulong channel_layout;

        public int sample_rate;

        public int format;

        public AVRational time_base;

        public AVFilterFormats* in_formats;

        public AVFilterFormats* out_formats;

        public AVFilterFormats* in_samplerates;

        public AVFilterFormats* out_samplerates;

        [NativeTypeName("struct AVFilterChannelLayouts *")]
        public AVFilterChannelLayouts* in_channel_layouts;

        [NativeTypeName("struct AVFilterChannelLayouts *")]
        public AVFilterChannelLayouts* out_channel_layouts;

        public int request_samples;

        [NativeTypeName("__AnonymousEnum_avfilter_L503_C5")]
        public int init_state;

        [NativeTypeName("struct AVFilterGraph *")]
        public AVFilterGraph* graph;

        [NativeTypeName("int64_t")]
        public long current_pts;

        [NativeTypeName("int64_t")]
        public long current_pts_us;

        public int age_index;

        public AVRational frame_rate;

        public AVFrame* partial_buf;

        public int partial_buf_size;

        public int min_samples;

        public int max_samples;

        public int channels;

        [NativeTypeName("unsigned int")]
        public uint flags;

        [NativeTypeName("int64_t")]
        public long frame_count_in;

        [NativeTypeName("int64_t")]
        public long frame_count_out;

        public void* frame_pool;

        public int frame_wanted_out;

        public AVBufferRef* hw_frames_ctx;

        [NativeTypeName("char[61440]")]
        public fixed sbyte reserved[61440];

        internal partial struct AVFilterChannelLayouts
        {
        }

        internal const int AVLINK_UNINIT = 0;
        internal const int AVLINK_STARTINIT = 1;
        internal const int AVLINK_INIT = 2;
    }

    internal partial struct AVFilterGraphInternal
    {
    }

    internal unsafe partial struct AVFilterGraph
    {
        [NativeTypeName("const AVClass *")]
        public AVClass* av_class;

        public AVFilterContext** filters;

        [NativeTypeName("unsigned int")]
        public uint nb_filters;

        [NativeTypeName("char *")]
        public sbyte* scale_sws_opts;

        [NativeTypeName("char *")]
        [Obsolete]
        public sbyte* resample_lavr_opts;

        public int thread_type;

        public int nb_threads;

        public AVFilterGraphInternal* @internal;

        public void* opaque;

        [NativeTypeName("avfilter_execute_func *")]
        public delegate* unmanaged[Cdecl]<AVFilterContext*, delegate* unmanaged[Cdecl]<AVFilterContext*, void*, int, int, int>, void*, int*, int, int> execute;

        [NativeTypeName("char *")]
        public sbyte* aresample_swr_opts;

        public AVFilterLink** sink_links;

        public int sink_links_count;

        [NativeTypeName("unsigned int")]
        public uint disable_auto_convert;
    }

    internal unsafe partial struct AVFilterInOut
    {
        [NativeTypeName("char *")]
        public sbyte* name;

        public AVFilterContext* filter_ctx;

        public int pad_idx;

        [NativeTypeName("struct AVFilterInOut *")]
        public AVFilterInOut* next;
    }

    internal static unsafe partial class FFmpegNative
    {
        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("unsigned int")]
        public static extern uint avfilter_version();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_configuration();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_license();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_pad_count([NativeTypeName("const AVFilterPad *")] AVFilterPad* pads);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const char *")]
        public static extern sbyte* avfilter_pad_get_name([NativeTypeName("const AVFilterPad *")] AVFilterPad* pads, int pad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("enum AVMediaType")]
        public static extern AVMediaType avfilter_pad_get_type([NativeTypeName("const AVFilterPad *")] AVFilterPad* pads, int pad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_link(AVFilterContext* src, [NativeTypeName("unsigned int")] uint srcpad, AVFilterContext* dst, [NativeTypeName("unsigned int")] uint dstpad);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_link_free(AVFilterLink** link);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avfilter_link_get_channels(AVFilterLink* link);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avfilter_link_set_closed(AVFilterLink* link, int closed);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_config_links(AVFilterContext* filter);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_process_command(AVFilterContext* filter, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, [NativeTypeName("char *")] sbyte* res, int res_len, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFilter *")]
        public static extern AVFilter* av_filter_iterate(void** opaque);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern void avfilter_register_all();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int avfilter_register(AVFilter* filter);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFilter *")]
        [Obsolete]
        public static extern AVFilter* avfilter_next([NativeTypeName("const AVFilter *")] AVFilter* prev);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVFilter *")]
        public static extern AVFilter* avfilter_get_by_name([NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_init_str(AVFilterContext* ctx, [NativeTypeName("const char *")] sbyte* args);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_init_dict(AVFilterContext* ctx, AVDictionary** options);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_free(AVFilterContext* filter);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_insert_filter(AVFilterLink* link, AVFilterContext* filt, [NativeTypeName("unsigned int")] uint filt_srcpad_idx, [NativeTypeName("unsigned int")] uint filt_dstpad_idx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("const AVClass *")]
        public static extern AVClass* avfilter_get_class();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterGraph* avfilter_graph_alloc();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterContext* avfilter_graph_alloc_filter(AVFilterGraph* graph, [NativeTypeName("const AVFilter *")] AVFilter* filter, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterContext* avfilter_graph_get_filter(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* name);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_create_filter(AVFilterContext** filt_ctx, [NativeTypeName("const AVFilter *")] AVFilter* filt, [NativeTypeName("const char *")] sbyte* name, [NativeTypeName("const char *")] sbyte* args, void* opaque, AVFilterGraph* graph_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_graph_set_auto_convert(AVFilterGraph* graph, [NativeTypeName("unsigned int")] uint flags);

        internal const int AVFILTER_AUTO_CONVERT_ALL = 0;
        internal const int AVFILTER_AUTO_CONVERT_NONE = -1;

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_config(AVFilterGraph* graphctx, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_graph_free(AVFilterGraph** graph);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern AVFilterInOut* avfilter_inout_alloc();

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void avfilter_inout_free(AVFilterInOut** inout);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut* inputs, AVFilterInOut* outputs, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse_ptr(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut** inputs, AVFilterInOut** outputs, void* log_ctx);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_parse2(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* filters, AVFilterInOut** inputs, AVFilterInOut** outputs);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_send_command(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* target, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, [NativeTypeName("char *")] sbyte* res, int res_len, int flags);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_queue_command(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* target, [NativeTypeName("const char *")] sbyte* cmd, [NativeTypeName("const char *")] sbyte* arg, int flags, double ts);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [return: NativeTypeName("char *")]
        public static extern sbyte* avfilter_graph_dump(AVFilterGraph* graph, [NativeTypeName("const char *")] sbyte* options);

        [DllImport("avfilter", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int avfilter_graph_request_oldest(AVFilterGraph* graph);
    }
}
