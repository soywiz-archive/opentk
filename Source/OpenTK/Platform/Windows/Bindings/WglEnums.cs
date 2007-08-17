namespace OpenTK.Platform.Windows
{
    public static partial class Wgl
    {
        public class Enums
        {
            public enum WGL_ARB_buffer_region
            {
                _DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
                _BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                _FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
                _STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
            }
            
            public enum WGL_EXT_pixel_format
            {
                _BLUE_BITS_EXT = ((int)0x2019),
                _STENCIL_BITS_EXT = ((int)0x2023),
                _RED_BITS_EXT = ((int)0x2015),
                _SWAP_METHOD_EXT = ((int)0x2007),
                _BLUE_SHIFT_EXT = ((int)0x201A),
                _NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                _SHARE_DEPTH_EXT = ((int)0x200C),
                _ACCUM_RED_BITS_EXT = ((int)0x201E),
                _SUPPORT_GDI_EXT = ((int)0x200F),
                _ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                _SHARE_STENCIL_EXT = ((int)0x200D),
                _ALPHA_SHIFT_EXT = ((int)0x201C),
                _NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                _PIXEL_TYPE_EXT = ((int)0x2013),
                _SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                _ACCUM_BITS_EXT = ((int)0x201D),
                _DRAW_TO_WINDOW_EXT = ((int)0x2001),
                _NUMBER_OVERLAYS_EXT = ((int)0x2008),
                _DOUBLE_BUFFER_EXT = ((int)0x2011),
                _ACCELERATION_EXT = ((int)0x2003),
                _DRAW_TO_BITMAP_EXT = ((int)0x2002),
                _FULL_ACCELERATION_EXT = ((int)0x2027),
                _TYPE_COLORINDEX_EXT = ((int)0x202C),
                _ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                _SHARE_ACCUM_EXT = ((int)0x200E),
                _DEPTH_BITS_EXT = ((int)0x2022),
                _NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                _NO_ACCELERATION_EXT = ((int)0x2025),
                _SWAP_UNDEFINED_EXT = ((int)0x202A),
                _ALPHA_BITS_EXT = ((int)0x201B),
                _ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                _NEED_PALETTE_EXT = ((int)0x2004),
                _STEREO_EXT = ((int)0x2012),
                _SWAP_COPY_EXT = ((int)0x2029),
                _AUX_BUFFERS_EXT = ((int)0x2024),
                _TRANSPARENT_EXT = ((int)0x200A),
                _RED_SHIFT_EXT = ((int)0x2016),
                _TRANSPARENT_VALUE_EXT = ((int)0x200B),
                _TYPE_RGBA_EXT = ((int)0x202B),
                _SUPPORT_OPENGL_EXT = ((int)0x2010),
                _SWAP_EXCHANGE_EXT = ((int)0x2028),
                _GENERIC_ACCELERATION_EXT = ((int)0x2026),
                _COLOR_BITS_EXT = ((int)0x2014),
                _GREEN_SHIFT_EXT = ((int)0x2018),
                _GREEN_BITS_EXT = ((int)0x2017),
            }
            
            public enum WGL_ARB_pixel_format
            {
                _SWAP_METHOD_ARB = ((int)0x2007),
                _ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                _GENERIC_ACCELERATION_ARB = ((int)0x2026),
                _FULL_ACCELERATION_ARB = ((int)0x2027),
                _ACCUM_BITS_ARB = ((int)0x201D),
                _ALPHA_SHIFT_ARB = ((int)0x201C),
                _NO_ACCELERATION_ARB = ((int)0x2025),
                _DOUBLE_BUFFER_ARB = ((int)0x2011),
                _DRAW_TO_BITMAP_ARB = ((int)0x2002),
                _SWAP_COPY_ARB = ((int)0x2029),
                _SWAP_EXCHANGE_ARB = ((int)0x2028),
                _NUMBER_OVERLAYS_ARB = ((int)0x2008),
                _PBUFFER_LARGEST_ARB = ((int)0x2033),
                _PIXEL_TYPE_ARB = ((int)0x2013),
                _SHARE_STENCIL_ARB = ((int)0x200D),
                _STEREO_ARB = ((int)0x2012),
                _ALPHA_BITS_ARB = ((int)0x201B),
                _PBUFFER_HEIGHT_ARB = ((int)0x2035),
                _BLUE_BITS_ARB = ((int)0x2019),
                _COLOR_BITS_ARB = ((int)0x2014),
                _SWAP_UNDEFINED_ARB = ((int)0x202A),
                _DEPTH_BITS_ARB = ((int)0x2022),
                _TYPE_COLORINDEX_ARB = ((int)0x202C),
                _DRAW_TO_WINDOW_ARB = ((int)0x2001),
                _SUPPORT_GDI_ARB = ((int)0x200F),
                _SHARE_DEPTH_ARB = ((int)0x200C),
                _NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                _SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                _AUX_BUFFERS_ARB = ((int)0x2024),
                _RED_BITS_ARB = ((int)0x2015),
                _ACCELERATION_ARB = ((int)0x2003),
                _TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                _SUPPORT_OPENGL_ARB = ((int)0x2010),
                _TRANSPARENT_ARB = ((int)0x200A),
                _SHARE_ACCUM_ARB = ((int)0x200E),
                _STENCIL_BITS_ARB = ((int)0x2023),
                _ACCUM_BLUE_BITS_ARB = ((int)0x2020),
                _DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                _TYPE_RGBA_ARB = ((int)0x202B),
                _ACCUM_RED_BITS_ARB = ((int)0x201E),
                _TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                _NEED_PALETTE_ARB = ((int)0x2004),
                _MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                _RED_SHIFT_ARB = ((int)0x2016),
                _TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                _GREEN_BITS_ARB = ((int)0x2017),
                _NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                _TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                _MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                _BLUE_SHIFT_ARB = ((int)0x201A),
                _PBUFFER_WIDTH_ARB = ((int)0x2034),
                _NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                _ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                _MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                _TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                _GREEN_SHIFT_ARB = ((int)0x2018),
            }
            
            public enum WGL_EXT_pbuffer
            {
                _MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                _MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                _DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                _OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                _PBUFFER_LARGEST_EXT = ((int)0x2033),
                _OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                _PBUFFER_HEIGHT_EXT = ((int)0x2035),
                _MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
                _PBUFFER_WIDTH_EXT = ((int)0x2034),
            }
            
            public enum WGL_ARB_pbuffer
            {
                _PBUFFER_WIDTH_ARB = ((int)0x2034),
                _MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                _PBUFFER_LARGEST_ARB = ((int)0x2033),
                _TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                _PBUFFER_HEIGHT_ARB = ((int)0x2035),
                _PBUFFER_LOST_ARB = ((int)0x2036),
                _DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                _TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                _MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                _MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                _TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                _TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                _TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
            }
            
            public enum WGL_EXT_depth_float
            {
                _DEPTH_FLOAT_EXT = ((int)0x2040),
            }
            
            public enum WGL_EXT_multisample
            {
                _SAMPLE_BUFFERS_EXT = ((int)0x2041),
                _SAMPLES_EXT = ((int)0x2042),
            }
            
            public enum WGL_ARB_multisample
            {
                _SAMPLE_BUFFERS_ARB = ((int)0x2041),
                _SAMPLES_ARB = ((int)0x2042),
            }
            
            public enum WGL_EXT_make_current_read
            {
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
            }
            
            public enum WGL_ARB_make_current_read
            {
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
            }
            
            public enum WGL_I3D_genlock
            {
                _GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                _GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                _GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                _GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
                _GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                _GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
                _GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                _GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                _GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
            }
            
            public enum WGL_I3D_gamma
            {
                _GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
                _GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
            }
            
            public enum WGL_I3D_digital_video_control
            {
                _DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                _DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
                _DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                _DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
            }
            
            public enum WGL_3DFX_multisample
            {
                _SAMPLES_3DFX = ((int)0x2061),
                _SAMPLE_BUFFERS_3DFX = ((int)0x2060),
            }
            
            public enum WGL_ARB_render_texture
            {
                _MIPMAP_LEVEL_ARB = ((int)0x207B),
                _TEXTURE_1D_ARB = ((int)0x2079),
                _BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                _TEXTURE_TARGET_ARB = ((int)0x2073),
                _TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                _TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                _FRONT_RIGHT_ARB = ((int)0x2084),
                _TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                _BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
                _BACK_RIGHT_ARB = ((int)0x2086),
                _AUX0_ARB = ((int)0x2087),
                _AUX3_ARB = ((int)0x208A),
                _CUBE_MAP_FACE_ARB = ((int)0x207C),
                _TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                _AUX4_ARB = ((int)0x208B),
                _NO_TEXTURE_ARB = ((int)0x2077),
                _AUX6_ARB = ((int)0x208D),
                _AUX1_ARB = ((int)0x2088),
                _TEXTURE_RGB_ARB = ((int)0x2075),
                _TEXTURE_FORMAT_ARB = ((int)0x2072),
                _AUX9_ARB = ((int)0x2090),
                _TEXTURE_RGBA_ARB = ((int)0x2076),
                _BACK_LEFT_ARB = ((int)0x2085),
                _MIPMAP_TEXTURE_ARB = ((int)0x2074),
                _TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                _AUX2_ARB = ((int)0x2089),
                _TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                _AUX8_ARB = ((int)0x208F),
                _AUX5_ARB = ((int)0x208C),
                _TEXTURE_2D_ARB = ((int)0x207A),
                _TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                _AUX7_ARB = ((int)0x208E),
                _FRONT_LEFT_ARB = ((int)0x2083),
            }
            
            public enum WGL_NV_render_texture_rectangle
            {
                _BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
                _TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                _BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
            }
            
            public enum WGL_NV_render_depth_texture
            {
                _DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                _DEPTH_COMPONENT_NV = ((int)0x20A7),
                _TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                _BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
                _BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
            }
            
            public enum WGL_NV_float_buffer
            {
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
                _TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                _TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                _TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                _FLOAT_COMPONENTS_NV = ((int)0x20B0),
                _TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
            }
            
            public enum WGL_ARB_pixel_format_float
            {
                _TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
            }
            
            public enum WGL_ATI_pixel_format_float
            {
                _TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
            }
            
            public enum All
            {
                _ACCUM_GREEN_BITS_EXT = ((int)0x201F),
                _MAX_PBUFFER_HEIGHT_EXT = ((int)0x2030),
                _SUPPORT_OPENGL_EXT = ((int)0x2010),
                _ACCUM_ALPHA_BITS_ARB = ((int)0x2021),
                _STEREO_EXT = ((int)0x2012),
                _SUPPORT_GDI_ARB = ((int)0x200F),
                _STENCIL_BITS_ARB = ((int)0x2023),
                _AUX5_ARB = ((int)0x208C),
                _FRONT_RIGHT_ARB = ((int)0x2084),
                _TEXTURE_FLOAT_RGBA_NV = ((int)0x20B8),
                _NEED_PALETTE_EXT = ((int)0x2004),
                _NO_ACCELERATION_ARB = ((int)0x2025),
                _TEXTURE_FORMAT_ARB = ((int)0x2072),
                _SWAP_EXCHANGE_ARB = ((int)0x2028),
                _NO_ACCELERATION_EXT = ((int)0x2025),
                _MAX_PBUFFER_HEIGHT_ARB = ((int)0x2030),
                _DRAW_TO_BITMAP_ARB = ((int)0x2002),
                _TEXTURE_TARGET_ARB = ((int)0x2073),
                _NUMBER_PIXEL_FORMATS_ARB = ((int)0x2000),
                _SWAP_COPY_EXT = ((int)0x2029),
                _SHARE_STENCIL_ARB = ((int)0x200D),
                _BLUE_BITS_EXT = ((int)0x2019),
                _DEPTH_FLOAT_EXT = ((int)0x2040),
                _SAMPLES_EXT = ((int)0x2042),
                _SWAP_METHOD_EXT = ((int)0x2007),
                _TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = ((int)0x2081),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RG_NV = ((int)0x20B2),
                _ALPHA_BITS_ARB = ((int)0x201B),
                _MAX_PBUFFER_WIDTH_EXT = ((int)0x202F),
                _SUPPORT_GDI_EXT = ((int)0x200F),
                _NUMBER_UNDERLAYS_EXT = ((int)0x2009),
                _SWAP_METHOD_ARB = ((int)0x2007),
                _TEXTURE_1D_ARB = ((int)0x2079),
                _SUPPORT_OPENGL_ARB = ((int)0x2010),
                _BIND_TO_TEXTURE_DEPTH_NV = ((int)0x20A3),
                _ALPHA_SHIFT_EXT = ((int)0x201C),
                _AUX4_ARB = ((int)0x208B),
                _GAMMA_EXCLUDE_DESKTOP_I3D = ((int)0x204F),
                _CUBE_MAP_FACE_ARB = ((int)0x207C),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGBA_NV = ((int)0x20B4),
                _DOUBLE_BUFFER_ARB = ((int)0x2011),
                _TEXTURE_RECTANGLE_NV = ((int)0x20A2),
                _SHARE_ACCUM_EXT = ((int)0x200E),
                _BIND_TO_TEXTURE_RECTANGLE_RGBA_NV = ((int)0x20A1),
                _NO_TEXTURE_ARB = ((int)0x2077),
                _SWAP_UNDEFINED_EXT = ((int)0x202A),
                _DEPTH_BUFFER_BIT_ARB = ((int)0x00000004),
                _BIND_TO_TEXTURE_RECTANGLE_RGB_NV = ((int)0x20A0),
                _MIPMAP_TEXTURE_ARB = ((int)0x2074),
                _DEPTH_BITS_EXT = ((int)0x2022),
                _IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
                _AUX6_ARB = ((int)0x208D),
                _TEXTURE_FLOAT_RGB_NV = ((int)0x20B7),
                _TEXTURE_CUBE_MAP_POSITIVE_X_ARB = ((int)0x207D),
                _MIPMAP_LEVEL_ARB = ((int)0x207B),
                _SWAP_LAYER_BUFFERS_ARB = ((int)0x2006),
                _DRAW_TO_BITMAP_EXT = ((int)0x2002),
                _COLOR_BITS_ARB = ((int)0x2014),
                _GREEN_BITS_EXT = ((int)0x2017),
                _PIXEL_TYPE_ARB = ((int)0x2013),
                _GREEN_SHIFT_ARB = ((int)0x2018),
                _PBUFFER_LARGEST_ARB = ((int)0x2033),
                _FRONT_LEFT_ARB = ((int)0x2083),
                _TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = ((int)0x207F),
                _TRANSPARENT_GREEN_VALUE_ARB = ((int)0x2038),
                _AUX7_ARB = ((int)0x208E),
                _SHARE_ACCUM_ARB = ((int)0x200E),
                _TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = ((int)0x207E),
                _DRAW_TO_WINDOW_ARB = ((int)0x2001),
                _COLOR_BITS_EXT = ((int)0x2014),
                _ACCUM_ALPHA_BITS_EXT = ((int)0x2021),
                _TYPE_RGBA_FLOAT_ATI = ((int)0x21A0),
                _TRANSPARENT_ALPHA_VALUE_ARB = ((int)0x203A),
                _TRANSPARENT_EXT = ((int)0x200A),
                _BIND_TO_TEXTURE_RGB_ARB = ((int)0x2070),
                _TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = ((int)0x2080),
                _AUX9_ARB = ((int)0x2090),
                _DIGITAL_VIDEO_CURSOR_ALPHA_VALUE_I3D = ((int)0x2051),
                _MAX_PBUFFER_PIXELS_ARB = ((int)0x202E),
                ERROR_INVALID_PIXEL_TYPE_ARB = ((int)0x2043),
                _ALPHA_SHIFT_ARB = ((int)0x201C),
                _GENLOCK_SOURCE_EXTENAL_FIELD_I3D = ((int)0x2046),
                _TEXTURE_DEPTH_COMPONENT_NV = ((int)0x20A6),
                _DIGITAL_VIDEO_CURSOR_ALPHA_FRAMEBUFFER_I3D = ((int)0x2050),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_R_NV = ((int)0x20B1),
                _TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = ((int)0x2082),
                _BLUE_BITS_ARB = ((int)0x2019),
                _OPTIMAL_PBUFFER_WIDTH_EXT = ((int)0x2031),
                _SAMPLE_BUFFERS_3DFX = ((int)0x2060),
                _MAX_PBUFFER_WIDTH_ARB = ((int)0x202F),
                _GENLOCK_SOURCE_EDGE_BOTH_I3D = ((int)0x204C),
                _PBUFFER_HEIGHT_ARB = ((int)0x2035),
                _GENERIC_ACCELERATION_EXT = ((int)0x2026),
                _TRANSPARENT_INDEX_VALUE_ARB = ((int)0x203B),
                _NUMBER_UNDERLAYS_ARB = ((int)0x2009),
                _AUX_BUFFERS_ARB = ((int)0x2024),
                _FULL_ACCELERATION_ARB = ((int)0x2027),
                _DRAW_TO_PBUFFER_ARB = ((int)0x202D),
                _DIGITAL_VIDEO_GAMMA_CORRECTED_I3D = ((int)0x2053),
                _FRONT_COLOR_BUFFER_BIT_ARB = ((int)0x00000001),
                _TEXTURE_RGB_ARB = ((int)0x2075),
                _AUX8_ARB = ((int)0x208F),
                _ACCUM_BLUE_BITS_EXT = ((int)0x2020),
                _NUMBER_OVERLAYS_EXT = ((int)0x2008),
                _DOUBLE_BUFFER_EXT = ((int)0x2011),
                _SAMPLE_BUFFERS_EXT = ((int)0x2041),
                _SWAP_UNDEFINED_ARB = ((int)0x202A),
                _DIGITAL_VIDEO_CURSOR_INCLUDED_I3D = ((int)0x2052),
                _GENLOCK_SOURCE_EDGE_RISING_I3D = ((int)0x204B),
                _NEED_PALETTE_ARB = ((int)0x2004),
                _DEPTH_BITS_ARB = ((int)0x2022),
                _SWAP_EXCHANGE_EXT = ((int)0x2028),
                _ACCUM_BITS_ARB = ((int)0x201D),
                _TYPE_COLORINDEX_EXT = ((int)0x202C),
                _SWAP_COPY_ARB = ((int)0x2029),
                _AUX1_ARB = ((int)0x2088),
                _TRANSPARENT_ARB = ((int)0x200A),
                _BLUE_SHIFT_ARB = ((int)0x201A),
                _DEPTH_COMPONENT_NV = ((int)0x20A7),
                _SAMPLES_3DFX = ((int)0x2061),
                _GREEN_SHIFT_EXT = ((int)0x2018),
                _PBUFFER_LARGEST_EXT = ((int)0x2033),
                _STENCIL_BUFFER_BIT_ARB = ((int)0x00000008),
                _ACCELERATION_EXT = ((int)0x2003),
                _PBUFFER_WIDTH_EXT = ((int)0x2034),
                _ACCUM_GREEN_BITS_ARB = ((int)0x201F),
                _STEREO_ARB = ((int)0x2012),
                _GENLOCK_SOURCE_DIGITAL_SYNC_I3D = ((int)0x2048),
                _TEXTURE_2D_ARB = ((int)0x207A),
                _RED_SHIFT_ARB = ((int)0x2016),
                _RED_SHIFT_EXT = ((int)0x2016),
                _TRANSPARENT_RED_VALUE_ARB = ((int)0x2037),
                _GREEN_BITS_ARB = ((int)0x2017),
                ERROR_INCOMPATIBLE_DEVICE_CONTEXTS_ARB = ((int)0x2054),
                _TRANSPARENT_VALUE_EXT = ((int)0x200B),
                _GENLOCK_SOURCE_EXTENAL_TTL_I3D = ((int)0x2047),
                _PBUFFER_LOST_ARB = ((int)0x2036),
                _TEXTURE_CUBE_MAP_ARB = ((int)0x2078),
                _PIXEL_TYPE_EXT = ((int)0x2013),
                _TEXTURE_FLOAT_RG_NV = ((int)0x20B6),
                _TRANSPARENT_BLUE_VALUE_ARB = ((int)0x2039),
                _NEED_SYSTEM_PALETTE_EXT = ((int)0x2005),
                _TEXTURE_FLOAT_R_NV = ((int)0x20B5),
                _TEXTURE_RGBA_ARB = ((int)0x2076),
                _GAMMA_TABLE_SIZE_I3D = ((int)0x204E),
                _FULL_ACCELERATION_EXT = ((int)0x2027),
                _RED_BITS_EXT = ((int)0x2015),
                _OPTIMAL_PBUFFER_HEIGHT_EXT = ((int)0x2032),
                _SHARE_STENCIL_EXT = ((int)0x200D),
                _NUMBER_OVERLAYS_ARB = ((int)0x2008),
                _SWAP_LAYER_BUFFERS_EXT = ((int)0x2006),
                _AUX0_ARB = ((int)0x2087),
                _PBUFFER_HEIGHT_EXT = ((int)0x2035),
                _MAX_PBUFFER_PIXELS_EXT = ((int)0x202E),
                _SHARE_DEPTH_EXT = ((int)0x200C),
                _BACK_RIGHT_ARB = ((int)0x2086),
                _DEPTH_TEXTURE_FORMAT_NV = ((int)0x20A5),
                _SHARE_DEPTH_ARB = ((int)0x200C),
                _ACCUM_RED_BITS_EXT = ((int)0x201E),
                _STENCIL_BITS_EXT = ((int)0x2023),
                _GENLOCK_SOURCE_DIGITAL_FIELD_I3D = ((int)0x2049),
                _BLUE_SHIFT_EXT = ((int)0x201A),
                _BACK_COLOR_BUFFER_BIT_ARB = ((int)0x00000002),
                _NEED_SYSTEM_PALETTE_ARB = ((int)0x2005),
                _SAMPLES_ARB = ((int)0x2042),
                _TYPE_RGBA_ARB = ((int)0x202B),
                _AUX2_ARB = ((int)0x2089),
                _TYPE_COLORINDEX_ARB = ((int)0x202C),
                _DRAW_TO_PBUFFER_EXT = ((int)0x202D),
                _ACCUM_BITS_EXT = ((int)0x201D),
                _TYPE_RGBA_EXT = ((int)0x202B),
                _BIND_TO_TEXTURE_RECTANGLE_FLOAT_RGB_NV = ((int)0x20B3),
                _AUX_BUFFERS_EXT = ((int)0x2024),
                _PBUFFER_WIDTH_ARB = ((int)0x2034),
                _GENLOCK_SOURCE_EDGE_FALLING_I3D = ((int)0x204A),
                ERROR_INVALID_PIXEL_TYPE_EXT = ((int)0x2043),
                _IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
                _ALPHA_BITS_EXT = ((int)0x201B),
                _GENERIC_ACCELERATION_ARB = ((int)0x2026),
                _NUMBER_PIXEL_FORMATS_EXT = ((int)0x2000),
                _ACCUM_BLUE_BITS_ARB = ((int)0x2020),
                _ACCUM_RED_BITS_ARB = ((int)0x201E),
                _AUX3_ARB = ((int)0x208A),
                _GENLOCK_SOURCE_MULTIVIEW_I3D = ((int)0x2044),
                _TYPE_RGBA_FLOAT_ARB = ((int)0x21A0),
                _ACCELERATION_ARB = ((int)0x2003),
                _GENLOCK_SOURCE_EXTENAL_SYNC_I3D = ((int)0x2045),
                _RED_BITS_ARB = ((int)0x2015),
                _SAMPLE_BUFFERS_ARB = ((int)0x2041),
                _BIND_TO_TEXTURE_RECTANGLE_DEPTH_NV = ((int)0x20A4),
                _DRAW_TO_WINDOW_EXT = ((int)0x2001),
                _BACK_LEFT_ARB = ((int)0x2085),
                _BIND_TO_TEXTURE_RGBA_ARB = ((int)0x2071),
                _FLOAT_COMPONENTS_NV = ((int)0x20B0),
            }
            
            public enum WGL_ARB_extensions_string
            {
            }
            
            public enum WGL_I3D_image_buffer
            {
                _IMAGE_BUFFER_MIN_ACCESS_I3D = ((int)0x00000001),
                _IMAGE_BUFFER_LOCK_I3D = ((int)0x00000002),
            }
            
            public enum WGL_I3D_swap_frame_lock
            {
            }
            
        }
    }
}
