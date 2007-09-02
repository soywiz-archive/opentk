namespace OpenTK.Platform.X11
{
    public static partial class Glx
    {
        public class Enums
        {
            public enum GLXStringName
            {
                VENDOR = ((int)0x1),
                EXTENSIONS = ((int)0x3),
                VERSION = ((int)0x2),
            }
            
            public enum GLXErrorCode
            {
                NO_EXTENSION = ((int)3),
                BAD_CONTEXT = ((int)5),
                BAD_HYPERPIPE_SGIX = ((int)92),
                BAD_ATTRIBUTE = ((int)2),
                BAD_SCREEN = ((int)1),
                BAD_HYPERPIPE_CONFIG_SGIX = ((int)91),
                BAD_VALUE = ((int)6),
                BAD_VISUAL = ((int)4),
                BAD_ENUM = ((int)7),
            }
            
            public enum GLXDrawableTypeMask
            {
                PIXMAP_BIT = ((int)0x00000002),
                PBUFFER_BIT = ((int)0x00000004),
                WINDOW_BIT = ((int)0x00000001),
                PBUFFER_BIT_SGIX = ((int)0x00000004),
                PIXMAP_BIT_SGIX = ((int)0x00000002),
                WINDOW_BIT_SGIX = ((int)0x00000001),
            }
            
            public enum GLXRenderTypeMask
            {
                RGBA_BIT = ((int)0x00000001),
                COLOR_INDEX_BIT = ((int)0x00000002),
                RGBA_FLOAT_BIT_ARB = ((int)0x00000004),
                RGBA_BIT_SGIX = ((int)0x00000001),
                COLOR_INDEX_BIT_SGIX = ((int)0x00000002),
            }
            
            public enum GLXSyncType
            {
                SYNC_SWAP_SGIX = ((int)0x00000001),
                SYNC_FRAME_SGIX = ((int)0x00000000),
            }
            
            public enum GLXEventMask
            {
                PBUFFER_CLOBBER_MASK = ((int)0x08000000),
                BUFFER_CLOBBER_MASK_SGIX = ((int)0x08000000),
            }
            
            public enum GLXPbufferClobberMask
            {
                STENCIL_BUFFER_BIT = ((int)0x00000040),
                ACCUM_BUFFER_BIT = ((int)0x00000080),
                FRONT_LEFT_BUFFER_BIT_SGIX = ((int)0x00000001),
                SAMPLE_BUFFERS_BIT_SGIX = ((int)0x00000100),
                DEPTH_BUFFER_BIT = ((int)0x00000020),
                STENCIL_BUFFER_BIT_SGIX = ((int)0x00000040),
                BACK_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000008),
                ACCUM_BUFFER_BIT_SGIX = ((int)0x00000080),
                BACK_LEFT_BUFFER_BIT_SGIX = ((int)0x00000004),
                FRONT_LEFT_BUFFER_BIT = ((int)0x00000001),
                BACK_LEFT_BUFFER_BIT = ((int)0x00000004),
                AUX_BUFFERS_BIT = ((int)0x00000010),
                FRONT_RIGHT_BUFFER_BIT = ((int)0x00000002),
                DEPTH_BUFFER_BIT_SGIX = ((int)0x00000020),
                BACK_RIGHT_BUFFER_BIT = ((int)0x00000008),
                AUX_BUFFERS_BIT_SGIX = ((int)0x00000010),
                FRONT_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000002),
            }
            
            public enum GLXHyperpipeTypeMask
            {
                HYPERPIPE_RENDER_PIPE_SGIX = ((int)0x00000002),
                HYPERPIPE_DISPLAY_PIPE_SGIX = ((int)0x00000001),
            }
            
            public enum GLXHyperpipeAttrib
            {
                PIPE_RECT_LIMITS_SGIX = ((int)0x00000002),
                HYPERPIPE_STEREO_SGIX = ((int)0x00000003),
                HYPERPIPE_PIXEL_AVERAGE_SGIX = ((int)0x00000004),
                PIPE_RECT_SGIX = ((int)0x00000001),
            }
            
            public enum GLXHyperpipeMisc
            {
                HYPERPIPE_PIPE_NAME_LENGTH_SGIX = ((int)80),
            }
            
            public enum GLXAttribute
            {
                RGBA = ((int)4),
                RGBA_FLOAT_TYPE_ARB = ((int)0x20B9),
                X_VISUAL_TYPE_EXT = ((int)0x22),
                TRANSPARENT_TYPE_EXT = ((int)0x23),
                MAX_PBUFFER_WIDTH = ((int)0x8016),
                RENDER_TYPE_SGIX = ((int)0x8011),
                SCREEN = ((int)0x800C),
                TRANSPARENT_RGB = ((int)0x8008),
                DRAWABLE_TYPE = ((int)0x8010),
                TRANSPARENT_INDEX_VALUE_EXT = ((int)0x24),
                SAMPLES = ((int)100001),
                TRANSPARENT_ALPHA_VALUE = ((int)0x28),
                MAX_PBUFFER_PIXELS = ((int)0x8018),
                RED_SIZE = ((int)8),
                TRANSPARENT_RGB_EXT = ((int)0x8008),
                RENDER_TYPE = ((int)0x8011),
                ACCUM_ALPHA_SIZE = ((int)17),
                SHARE_CONTEXT_EXT = ((int)0x800A),
                TRUE_COLOR_EXT = ((int)0x8002),
                ACCUM_BLUE_SIZE = ((int)16),
                PBUFFER_WIDTH = ((int)0x8041),
                SAVED = ((int)0x8021),
                MAX_PBUFFER_WIDTH_SGIX = ((int)0x8016),
                PSEUDO_COLOR = ((int)0x8004),
                SAMPLES_ARB = ((int)100001),
                SAMPLE_BUFFERS_SGIS = ((int)100000),
                BLENDED_RGBA_SGIS = ((int)0x8025),
                RGBA_TYPE = ((int)0x8014),
                COLOR_INDEX_TYPE = ((int)0x8015),
                BLUE_SIZE = ((int)10),
                SLOW_VISUAL_EXT = ((int)0x8001),
                TRANSPARENT_GREEN_VALUE_EXT = ((int)0x26),
                WIDTH = ((int)0x801D),
                AUX_BUFFERS = ((int)7),
                DIRECT_COLOR_EXT = ((int)0x8003),
                MULTISAMPLE_SUB_RECT_WIDTH_SGIS = ((int)0x8026),
                DONT_CARE = unchecked((int)0xFFFFFFFF),
                SAMPLE_BUFFERS = ((int)100000),
                DIRECT_COLOR = ((int)0x8003),
                LARGEST_PBUFFER = ((int)0x801C),
                MAX_PBUFFER_HEIGHT = ((int)0x8017),
                TRANSPARENT_ALPHA_VALUE_EXT = ((int)0x28),
                BUFFER_SIZE = ((int)2),
                DAMAGED = ((int)0x8020),
                CONFIG_CAVEAT = ((int)0x20),
                WINDOW_SGIX = ((int)0x8022),
                MULTISAMPLE_SUB_RECT_HEIGHT_SGIS = ((int)0x8027),
                HEIGHT = ((int)0x801E),
                COLOR_INDEX_TYPE_SGIX = ((int)0x8015),
                DEPTH_SIZE = ((int)12),
                TRANSPARENT_INDEX = ((int)0x8009),
                DRAWABLE_TYPE_SGIX = ((int)0x8010),
                HYPERPIPE_ID_SGIX = ((int)0x8030),
                TRANSPARENT_BLUE_VALUE = ((int)0x27),
                RGBA_TYPE_SGIX = ((int)0x8014),
                TRANSPARENT_INDEX_VALUE = ((int)0x24),
                PSEUDO_COLOR_EXT = ((int)0x8004),
                EVENT_MASK = ((int)0x801F),
                TRANSPARENT_INDEX_EXT = ((int)0x8009),
                NON_CONFORMANT_CONFIG = ((int)0x800D),
                GRAY_SCALE_EXT = ((int)0x8006),
                GRAY_SCALE = ((int)0x8006),
                FLOAT_COMPONENTS_NV = ((int)0x20B0),
                TRANSPARENT_RED_VALUE_EXT = ((int)0x25),
                VISUAL_ID_EXT = ((int)0x800B),
                PRESERVED_CONTENTS_SGIX = ((int)0x801B),
                EVENT_MASK_SGIX = ((int)0x801F),
                X_VISUAL_TYPE = ((int)0x22),
                TRANSPARENT_RED_VALUE = ((int)0x25),
                OPTIMAL_PBUFFER_WIDTH_SGIX = ((int)0x8019),
                DIGITAL_MEDIA_PBUFFER_SGIX = ((int)0x8024),
                STEREO = ((int)6),
                DOUBLEBUFFER = ((int)5),
                NON_CONFORMANT_VISUAL_EXT = ((int)0x800D),
                HEIGHT_SGIX = ((int)0x801E),
                TRUE_COLOR = ((int)0x8002),
                STENCIL_SIZE = ((int)13),
                STATIC_COLOR_EXT = ((int)0x8005),
                LARGEST_PBUFFER_SGIX = ((int)0x801C),
                SAMPLE_BUFFERS_ARB = ((int)100000),
                X_RENDERABLE = ((int)0x8012),
                STATIC_COLOR = ((int)0x8005),
                DAMAGED_SGIX = ((int)0x8020),
                VISUAL_SELECT_GROUP_SGIX = ((int)0x8028),
                USE_GL = ((int)1),
                PBUFFER = ((int)0x8023),
                MAX_PBUFFER_PIXELS_SGIX = ((int)0x8018),
                SAVED_SGIX = ((int)0x8021),
                TRANSPARENT_GREEN_VALUE = ((int)0x26),
                PBUFFER_SGIX = ((int)0x8023),
                ACCUM_GREEN_SIZE = ((int)15),
                GREEN_SIZE = ((int)9),
                STATIC_GRAY = ((int)0x8007),
                VISUAL_ID = ((int)0x800B),
                MAX_PBUFFER_HEIGHT_SGIX = ((int)0x8017),
                LEVEL = ((int)3),
                SLOW_CONFIG = ((int)0x8001),
                NONE_EXT = ((int)0x8000),
                TRANSPARENT_BLUE_VALUE_EXT = ((int)0x27),
                X_RENDERABLE_SGIX = ((int)0x8012),
                ALPHA_SIZE = ((int)11),
                SAMPLES_SGIS = ((int)100001),
                FBCONFIG_ID = ((int)0x8013),
                WIDTH_SGIX = ((int)0x801D),
                PRESERVED_CONTENTS = ((int)0x801B),
                ACCUM_RED_SIZE = ((int)14),
                NONE = ((int)0x8000),
                WINDOW = ((int)0x8022),
                SCREEN_EXT = ((int)0x800C),
                TRANSPARENT_TYPE = ((int)0x23),
                PBUFFER_HEIGHT = ((int)0x8040),
                OPTIMAL_PBUFFER_HEIGHT_SGIX = ((int)0x801A),
                FBCONFIG_ID_SGIX = ((int)0x8013),
                STATIC_GRAY_EXT = ((int)0x8007),
                VISUAL_CAVEAT_EXT = ((int)0x20),
            }
            
            public enum All
            {
                DOUBLEBUFFER = ((int)5),
                DRAWABLE_TYPE_SGIX = ((int)0x8010),
                GLX_3DFX_WINDOW_MODE_MESA = ((int)0x1),
                DIRECT_COLOR = ((int)0x8003),
                LARGEST_PBUFFER = ((int)0x801C),
                ACCUM_RED_SIZE = ((int)14),
                GLX_3DFX_FULLSCREEN_MODE_MESA = ((int)0x2),
                WINDOW_SGIX = ((int)0x8022),
                RGBA_TYPE = ((int)0x8014),
                BAD_VALUE = ((int)6),
                HYPERPIPE_DISPLAY_PIPE_SGIX = ((int)0x00000001),
                TRUE_COLOR_EXT = ((int)0x8002),
                STATIC_COLOR = ((int)0x8005),
                MAX_PBUFFER_WIDTH = ((int)0x8016),
                SWAP_EXCHANGE_OML = ((int)0x8061),
                MAX_PBUFFER_PIXELS_SGIX = ((int)0x8018),
                BAD_ENUM = ((int)7),
                MAX_PBUFFER_PIXELS = ((int)0x8018),
                SHARE_CONTEXT_EXT = ((int)0x800A),
                COLOR_INDEX_BIT = ((int)0x00000002),
                PSEUDO_COLOR = ((int)0x8004),
                SYNC_SWAP_SGIX = ((int)0x00000001),
                MULTISAMPLE_SUB_RECT_HEIGHT_SGIS = ((int)0x8027),
                TRANSPARENT_GREEN_VALUE = ((int)0x26),
                FRONT_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000002),
                FRONT_LEFT_BUFFER_BIT = ((int)0x00000001),
                WIDTH_SGIX = ((int)0x801D),
                HEIGHT = ((int)0x801E),
                TRANSPARENT_RED_VALUE_EXT = ((int)0x25),
                PRESERVED_CONTENTS_SGIX = ((int)0x801B),
                TRANSPARENT_ALPHA_VALUE = ((int)0x28),
                SAMPLE_BUFFERS_SGIS = ((int)100000),
                FLOAT_COMPONENTS_NV = ((int)0x20B0),
                DEPTH_BUFFER_BIT_SGIX = ((int)0x00000020),
                DRAWABLE_TYPE = ((int)0x8010),
                WIDTH = ((int)0x801D),
                DEPTH_SIZE = ((int)12),
                SCREEN_EXT = ((int)0x800C),
                VENDOR = ((int)0x1),
                TRANSPARENT_INDEX_VALUE_EXT = ((int)0x24),
                VISUAL_CAVEAT_EXT = ((int)0x20),
                EVENT_MASK_SGIX = ((int)0x801F),
                ALPHA_SIZE = ((int)11),
                STENCIL_BUFFER_BIT_SGIX = ((int)0x00000040),
                NON_CONFORMANT_CONFIG = ((int)0x800D),
                HYPERPIPE_PIPE_NAME_LENGTH_SGIX = ((int)80),
                HYPERPIPE_PIXEL_AVERAGE_SGIX = ((int)0x00000004),
                RED_SIZE = ((int)8),
                PRESERVED_CONTENTS = ((int)0x801B),
                TRANSPARENT_ALPHA_VALUE_EXT = ((int)0x28),
                TRANSPARENT_INDEX_VALUE = ((int)0x24),
                COLOR_INDEX_TYPE = ((int)0x8015),
                AUX_BUFFERS = ((int)7),
                ACCUM_BUFFER_BIT = ((int)0x00000080),
                USE_GL = ((int)1),
                FBCONFIG_ID = ((int)0x8013),
                DEPTH_BUFFER_BIT = ((int)0x00000020),
                TRANSPARENT_RED_VALUE = ((int)0x25),
                ACCUM_BUFFER_BIT_SGIX = ((int)0x00000080),
                TRANSPARENT_RGB_EXT = ((int)0x8008),
                HYPERPIPE_RENDER_PIPE_SGIX = ((int)0x00000002),
                SAMPLES_SGIS = ((int)100001),
                STENCIL_BUFFER_BIT = ((int)0x00000040),
                STATIC_GRAY_EXT = ((int)0x8007),
                TRANSPARENT_INDEX_EXT = ((int)0x8009),
                PIXMAP_BIT = ((int)0x00000002),
                SWAP_METHOD_OML = ((int)0x8060),
                EVENT_MASK = ((int)0x801F),
                RGBA_TYPE_SGIX = ((int)0x8014),
                SAMPLE_BUFFERS_3DFX = ((int)0x8050),
                WINDOW_BIT_SGIX = ((int)0x00000001),
                SAMPLE_BUFFERS_ARB = ((int)100000),
                WINDOW_BIT = ((int)0x00000001),
                SWAP_COPY_OML = ((int)0x8062),
                ACCUM_ALPHA_SIZE = ((int)17),
                FRONT_LEFT_BUFFER_BIT_SGIX = ((int)0x00000001),
                NONE = ((int)0x8000),
                NONE_EXT = ((int)0x8000),
                X_VISUAL_TYPE = ((int)0x22),
                PBUFFER_BIT_SGIX = ((int)0x00000004),
                SLOW_VISUAL_EXT = ((int)0x8001),
                BAD_HYPERPIPE_CONFIG_SGIX = ((int)91),
                BUFFER_CLOBBER_MASK_SGIX = ((int)0x08000000),
                RGBA_BIT = ((int)0x00000001),
                COLOR_INDEX_BIT_SGIX = ((int)0x00000002),
                TRANSPARENT_TYPE = ((int)0x23),
                X_RENDERABLE = ((int)0x8012),
                NO_EXTENSION = ((int)3),
                DIRECT_COLOR_EXT = ((int)0x8003),
                SLOW_CONFIG = ((int)0x8001),
                SAMPLES = ((int)100001),
                SAVED_SGIX = ((int)0x8021),
                ACCUM_GREEN_SIZE = ((int)15),
                STATIC_GRAY = ((int)0x8007),
                PSEUDO_COLOR_EXT = ((int)0x8004),
                PBUFFER_SGIX = ((int)0x8023),
                CONFIG_CAVEAT = ((int)0x20),
                GRAY_SCALE_EXT = ((int)0x8006),
                TRANSPARENT_GREEN_VALUE_EXT = ((int)0x26),
                VISUAL_ID_EXT = ((int)0x800B),
                MAX_PBUFFER_HEIGHT = ((int)0x8017),
                SAMPLES_ARB = ((int)100001),
                RGBA_FLOAT_BIT_ARB = ((int)0x00000004),
                X_VISUAL_TYPE_EXT = ((int)0x22),
                SCREEN = ((int)0x800C),
                MAX_PBUFFER_WIDTH_SGIX = ((int)0x8016),
                WINDOW = ((int)0x8022),
                SYNC_FRAME_SGIX = ((int)0x00000000),
                TRUE_COLOR = ((int)0x8002),
                BACK_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000008),
                STATIC_COLOR_EXT = ((int)0x8005),
                STENCIL_SIZE = ((int)13),
                DAMAGED_SGIX = ((int)0x8020),
                STEREO = ((int)6),
                PBUFFER_CLOBBER_MASK = ((int)0x08000000),
                BAD_HYPERPIPE_SGIX = ((int)92),
                RENDER_TYPE = ((int)0x8011),
                BLENDED_RGBA_SGIS = ((int)0x8025),
                OPTIMAL_PBUFFER_WIDTH_SGIX = ((int)0x8019),
                PBUFFER_BIT = ((int)0x00000004),
                GRAY_SCALE = ((int)0x8006),
                DAMAGED = ((int)0x8020),
                PIPE_RECT_SGIX = ((int)0x00000001),
                HYPERPIPE_STEREO_SGIX = ((int)0x00000003),
                LEVEL = ((int)3),
                PBUFFER_HEIGHT = ((int)0x8040),
                SWAP_UNDEFINED_OML = ((int)0x8063),
                COLOR_INDEX_TYPE_SGIX = ((int)0x8015),
                BLUE_SIZE = ((int)10),
                SAMPLE_BUFFERS_BIT_SGIX = ((int)0x00000100),
                TRANSPARENT_RGB = ((int)0x8008),
                ACCUM_BLUE_SIZE = ((int)16),
                TRANSPARENT_TYPE_EXT = ((int)0x23),
                RENDER_TYPE_SGIX = ((int)0x8011),
                PIXMAP_BIT_SGIX = ((int)0x00000002),
                LARGEST_PBUFFER_SGIX = ((int)0x801C),
                RGBA_FLOAT_TYPE_ARB = ((int)0x20B9),
                BACK_LEFT_BUFFER_BIT_SGIX = ((int)0x00000004),
                HEIGHT_SGIX = ((int)0x801E),
                BUFFER_SIZE = ((int)2),
                MAX_PBUFFER_HEIGHT_SGIX = ((int)0x8017),
                TRANSPARENT_BLUE_VALUE_EXT = ((int)0x27),
                RGBA = ((int)4),
                X_RENDERABLE_SGIX = ((int)0x8012),
                NON_CONFORMANT_VISUAL_EXT = ((int)0x800D),
                TRANSPARENT_INDEX = ((int)0x8009),
                VISUAL_ID = ((int)0x800B),
                AUX_BUFFERS_BIT_SGIX = ((int)0x00000010),
                BACK_LEFT_BUFFER_BIT = ((int)0x00000004),
                OPTIMAL_PBUFFER_HEIGHT_SGIX = ((int)0x801A),
                SAVED = ((int)0x8021),
                HYPERPIPE_ID_SGIX = ((int)0x8030),
                BAD_VISUAL = ((int)4),
                PBUFFER = ((int)0x8023),
                VERSION = ((int)0x2),
                DONT_CARE = unchecked((int)0xFFFFFFFF),
                AUX_BUFFERS_BIT = ((int)0x00000010),
                PBUFFER_WIDTH = ((int)0x8041),
                GREEN_SIZE = ((int)9),
                BAD_SCREEN = ((int)1),
                BAD_CONTEXT = ((int)5),
                SAMPLE_BUFFERS = ((int)100000),
                SAMPLES_3DFX = ((int)0x8051),
                DIGITAL_MEDIA_PBUFFER_SGIX = ((int)0x8024),
                TRANSPARENT_BLUE_VALUE = ((int)0x27),
                BAD_ATTRIBUTE = ((int)2),
                FBCONFIG_ID_SGIX = ((int)0x8013),
                PIPE_RECT_LIMITS_SGIX = ((int)0x00000002),
                BACK_RIGHT_BUFFER_BIT = ((int)0x00000008),
                RGBA_BIT_SGIX = ((int)0x00000001),
                VISUAL_SELECT_GROUP_SGIX = ((int)0x8028),
                FRONT_RIGHT_BUFFER_BIT = ((int)0x00000002),
                EXTENSIONS = ((int)0x3),
                MULTISAMPLE_SUB_RECT_WIDTH_SGIS = ((int)0x8026),
            }
            
            public enum VERSION_1_3
            {
                FRONT_LEFT_BUFFER_BIT = ((int)0x00000001),
                MAX_PBUFFER_HEIGHT = ((int)0x8017),
                SLOW_CONFIG = ((int)0x8001),
                WIDTH = ((int)0x801D),
                COLOR_INDEX_BIT = ((int)0x00000002),
                WINDOW = ((int)0x8022),
                BACK_LEFT_BUFFER_BIT = ((int)0x00000004),
                NONE = ((int)0x8000),
                PBUFFER_WIDTH = ((int)0x8041),
                PRESERVED_CONTENTS = ((int)0x801B),
                DEPTH_BUFFER_BIT = ((int)0x00000020),
                STATIC_COLOR = ((int)0x8005),
                WINDOW_BIT = ((int)0x00000001),
                PIXMAP_BIT = ((int)0x00000002),
                TRUE_COLOR = ((int)0x8002),
                BACK_RIGHT_BUFFER_BIT = ((int)0x00000008),
                PBUFFER_CLOBBER_MASK = ((int)0x08000000),
                RGBA_BIT = ((int)0x00000001),
                VISUAL_ID = ((int)0x800B),
                STATIC_GRAY = ((int)0x8007),
                TRANSPARENT_RED_VALUE = ((int)0x25),
                SAVED = ((int)0x8021),
                PBUFFER_HEIGHT = ((int)0x8040),
                TRANSPARENT_RGB = ((int)0x8008),
                DRAWABLE_TYPE = ((int)0x8010),
                DIRECT_COLOR = ((int)0x8003),
                AUX_BUFFERS_BIT = ((int)0x00000010),
                COLOR_INDEX_TYPE = ((int)0x8015),
                FBCONFIG_ID = ((int)0x8013),
                TRANSPARENT_GREEN_VALUE = ((int)0x26),
                ACCUM_BUFFER_BIT = ((int)0x00000080),
                SCREEN = ((int)0x800C),
                CONFIG_CAVEAT = ((int)0x20),
                DAMAGED = ((int)0x8020),
                DONT_CARE = unchecked((int)0xFFFFFFFF),
                TRANSPARENT_INDEX_VALUE = ((int)0x24),
                PSEUDO_COLOR = ((int)0x8004),
                GRAY_SCALE = ((int)0x8006),
                RENDER_TYPE = ((int)0x8011),
                X_VISUAL_TYPE = ((int)0x22),
                FRONT_RIGHT_BUFFER_BIT = ((int)0x00000002),
                MAX_PBUFFER_PIXELS = ((int)0x8018),
                TRANSPARENT_TYPE = ((int)0x23),
                EVENT_MASK = ((int)0x801F),
                TRANSPARENT_BLUE_VALUE = ((int)0x27),
                TRANSPARENT_ALPHA_VALUE = ((int)0x28),
                LARGEST_PBUFFER = ((int)0x801C),
                TRANSPARENT_INDEX = ((int)0x8009),
                NON_CONFORMANT_CONFIG = ((int)0x800D),
                HEIGHT = ((int)0x801E),
                PBUFFER_BIT = ((int)0x00000004),
                X_RENDERABLE = ((int)0x8012),
                PBUFFER = ((int)0x8023),
                STENCIL_BUFFER_BIT = ((int)0x00000040),
                MAX_PBUFFER_WIDTH = ((int)0x8016),
                RGBA_TYPE = ((int)0x8014),
            }
            
            public enum VERSION_1_4
            {
                SAMPLES = ((int)100001),
                SAMPLE_BUFFERS = ((int)100000),
            }
            
            public enum ARB_get_proc_address
            {
            }
            
            public enum ARB_multisample
            {
                SAMPLE_BUFFERS_ARB = ((int)100000),
                SAMPLES_ARB = ((int)100001),
            }
            
            public enum ARB_fbconfig_float
            {
                RGBA_FLOAT_BIT_ARB = ((int)0x00000004),
                RGBA_FLOAT_TYPE_ARB = ((int)0x20B9),
            }
            
            public enum SGIS_multisample
            {
                SAMPLES_SGIS = ((int)100001),
                SAMPLE_BUFFERS_SGIS = ((int)100000),
            }
            
            public enum EXT_visual_info
            {
                NONE_EXT = ((int)0x8000),
                GRAY_SCALE_EXT = ((int)0x8006),
                TRANSPARENT_INDEX_EXT = ((int)0x8009),
                TRANSPARENT_TYPE_EXT = ((int)0x23),
                TRANSPARENT_INDEX_VALUE_EXT = ((int)0x24),
                TRANSPARENT_RGB_EXT = ((int)0x8008),
                X_VISUAL_TYPE_EXT = ((int)0x22),
                TRANSPARENT_ALPHA_VALUE_EXT = ((int)0x28),
                PSEUDO_COLOR_EXT = ((int)0x8004),
                TRANSPARENT_BLUE_VALUE_EXT = ((int)0x27),
                TRUE_COLOR_EXT = ((int)0x8002),
                STATIC_GRAY_EXT = ((int)0x8007),
                TRANSPARENT_GREEN_VALUE_EXT = ((int)0x26),
                STATIC_COLOR_EXT = ((int)0x8005),
                TRANSPARENT_RED_VALUE_EXT = ((int)0x25),
                DIRECT_COLOR_EXT = ((int)0x8003),
            }
            
            public enum SGI_swap_control
            {
            }
            
            public enum SGI_video_sync
            {
            }
            
            public enum SGI_make_current_read
            {
            }
            
            public enum SGIX_video_source
            {
            }
            
            public enum EXT_visual_rating
            {
                SLOW_VISUAL_EXT = ((int)0x8001),
                NON_CONFORMANT_VISUAL_EXT = ((int)0x800D),
                NONE_EXT = ((int)EXT_visual_info.NONE_EXT),
                VISUAL_CAVEAT_EXT = ((int)0x20),
            }
            
            public enum EXT_import_context
            {
                SCREEN_EXT = ((int)0x800C),
                VISUAL_ID_EXT = ((int)0x800B),
                SHARE_CONTEXT_EXT = ((int)0x800A),
            }
            
            public enum SGIX_fbconfig
            {
                WINDOW_BIT_SGIX = ((int)0x00000001),
                DRAWABLE_TYPE_SGIX = ((int)0x8010),
                SCREEN_EXT = ((int)EXT_import_context.SCREEN_EXT),
                COLOR_INDEX_BIT_SGIX = ((int)0x00000002),
                PIXMAP_BIT_SGIX = ((int)0x00000002),
                X_RENDERABLE_SGIX = ((int)0x8012),
                RGBA_BIT_SGIX = ((int)0x00000001),
                RENDER_TYPE_SGIX = ((int)0x8011),
                RGBA_TYPE_SGIX = ((int)0x8014),
                FBCONFIG_ID_SGIX = ((int)0x8013),
                COLOR_INDEX_TYPE_SGIX = ((int)0x8015),
            }
            
            public enum SGIX_pbuffer
            {
                HEIGHT_SGIX = ((int)0x801E),
                MAX_PBUFFER_PIXELS_SGIX = ((int)0x8018),
                SAMPLE_BUFFERS_BIT_SGIX = ((int)0x00000100),
                PBUFFER_SGIX = ((int)0x8023),
                STENCIL_BUFFER_BIT_SGIX = ((int)0x00000040),
                LARGEST_PBUFFER_SGIX = ((int)0x801C),
                PRESERVED_CONTENTS_SGIX = ((int)0x801B),
                BACK_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000008),
                ACCUM_BUFFER_BIT_SGIX = ((int)0x00000080),
                BACK_LEFT_BUFFER_BIT_SGIX = ((int)0x00000004),
                DEPTH_BUFFER_BIT_SGIX = ((int)0x00000020),
                FRONT_RIGHT_BUFFER_BIT_SGIX = ((int)0x00000002),
                MAX_PBUFFER_WIDTH_SGIX = ((int)0x8016),
                PBUFFER_BIT_SGIX = ((int)0x00000004),
                WIDTH_SGIX = ((int)0x801D),
                OPTIMAL_PBUFFER_WIDTH_SGIX = ((int)0x8019),
                SAVED_SGIX = ((int)0x8021),
                WINDOW_SGIX = ((int)0x8022),
                MAX_PBUFFER_HEIGHT_SGIX = ((int)0x8017),
                DAMAGED_SGIX = ((int)0x8020),
                EVENT_MASK_SGIX = ((int)0x801F),
                OPTIMAL_PBUFFER_HEIGHT_SGIX = ((int)0x801A),
                FRONT_LEFT_BUFFER_BIT_SGIX = ((int)0x00000001),
                AUX_BUFFERS_BIT_SGIX = ((int)0x00000010),
                BUFFER_CLOBBER_MASK_SGIX = ((int)0x08000000),
            }
            
            public enum SGI_cushion
            {
            }
            
            public enum SGIX_video_resize
            {
                SYNC_SWAP_SGIX = ((int)0x00000001),
                SYNC_FRAME_SGIX = ((int)0x00000000),
            }
            
            public enum SGIX_dmbuffer
            {
                DIGITAL_MEDIA_PBUFFER_SGIX = ((int)0x8024),
            }
            
            public enum SGIX_swap_group
            {
            }
            
            public enum SGIX_swap_barrier
            {
            }
            
            public enum SGIS_blended_overlay
            {
                BLENDED_RGBA_SGIS = ((int)0x8025),
            }
            
            public enum SGIS_shared_multisample
            {
                MULTISAMPLE_SUB_RECT_HEIGHT_SGIS = ((int)0x8027),
                MULTISAMPLE_SUB_RECT_WIDTH_SGIS = ((int)0x8026),
            }
            
            public enum SUN_get_transparent_index
            {
            }
            
            public enum GLX_3DFX_multisample
            {
                SAMPLES_3DFX = ((int)0x8051),
                SAMPLE_BUFFERS_3DFX = ((int)0x8050),
            }
            
            public enum MESA_copy_sub_buffer
            {
            }
            
            public enum MESA_pixmap_colormap
            {
            }
            
            public enum MESA_release_buffers
            {
            }
            
            public enum MESA_set_3dfx_mode
            {
                GLX_3DFX_FULLSCREEN_MODE_MESA = ((int)0x2),
                GLX_3DFX_WINDOW_MODE_MESA = ((int)0x1),
            }
            
            public enum SGIX_visual_select_group
            {
                VISUAL_SELECT_GROUP_SGIX = ((int)0x8028),
            }
            
            public enum OML_swap_method
            {
                SWAP_METHOD_OML = ((int)0x8060),
                SWAP_EXCHANGE_OML = ((int)0x8061),
                SWAP_COPY_OML = ((int)0x8062),
                SWAP_UNDEFINED_OML = ((int)0x8063),
            }
            
            public enum OML_sync_control
            {
            }
            
            public enum NV_float_buffer
            {
                FLOAT_COMPONENTS_NV = ((int)0x20B0),
            }
            
            public enum SGIX_hyperpipe
            {
                PIPE_RECT_LIMITS_SGIX = ((int)0x00000002),
                HYPERPIPE_RENDER_PIPE_SGIX = ((int)0x00000002),
                BAD_HYPERPIPE_SGIX = ((int)92),
                HYPERPIPE_STEREO_SGIX = ((int)0x00000003),
                HYPERPIPE_PIXEL_AVERAGE_SGIX = ((int)0x00000004),
                PIPE_RECT_SGIX = ((int)0x00000001),
                HYPERPIPE_DISPLAY_PIPE_SGIX = ((int)0x00000001),
                HYPERPIPE_ID_SGIX = ((int)0x8030),
                BAD_HYPERPIPE_CONFIG_SGIX = ((int)91),
                HYPERPIPE_PIPE_NAME_LENGTH_SGIX = ((int)80),
            }
            
            public enum MESA_agp_offset
            {
            }
            
        }
    }
}
