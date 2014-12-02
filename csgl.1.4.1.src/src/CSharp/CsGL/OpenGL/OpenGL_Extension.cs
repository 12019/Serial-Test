// created by GLGenerator on 11/03/2002 00:18:09
// check last release of GLGenerator at http://csgl.sourceforge.net

// generated from a tailored extgl.h 
// hand made modification =>
//	remove some constante & fct already defined
//	call with _getf(name, false) for:
//		wglAllocateMemoryNV
//		wglFreeMemoryNV
using System;
using System.Collections;
using CsGL.OpenGL;
using CsGL.Util;

namespace CsGL.OpenGL
{
	[Serializable]
	public abstract unsafe class OpenGL_Extension : OpenGL
	{
		public const uint GL_RESCALE_NORMAL = 0x803A;
		public const uint GL_CLAMP_TO_EDGE = 0x812F;
		public const uint GL_MAX_ELEMENTS_VERTICES = 0x80E8;
		public const uint GL_MAX_ELEMENTS_INDICES = 0x80E9;
		public const uint GL_BGR = 0x80E0;
		public const uint GL_BGRA = 0x80E1;
		public const uint GL_UNSIGNED_BYTE_3_3_2 = 0x8032;
		public const uint GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;
		public const uint GL_UNSIGNED_SHORT_5_6_5 = 0x8363;
		public const uint GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;
		public const uint GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;
		public const uint GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;
		public const uint GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;
		public const uint GL_UNSIGNED_INT_8_8_8_8 = 0x8035;
		public const uint GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;
		public const uint GL_UNSIGNED_INT_10_10_10_2 = 0x8036;
		public const uint GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;
		public const uint GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;
		public const uint GL_SINGLE_COLOR = 0x81F9;
		public const uint GL_SEPARATE_SPECULAR_COLOR = 0x81FA;
		public const uint GL_TEXTURE_MIN_LOD = 0x813A;
		public const uint GL_TEXTURE_MAX_LOD = 0x813B;
		public const uint GL_TEXTURE_BASE_LEVEL = 0x813C;
		public const uint GL_TEXTURE_MAX_LEVEL = 0x813D;
		public const uint GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;
		public const uint GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;
		public const uint GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;
		public const uint GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;
		public const uint GL_ALIASED_POINT_SIZE_RANGE = 0x846D;
		public const uint GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;
		public const uint GL_PACK_SKIP_IMAGES = 0x806B;
		public const uint GL_PACK_IMAGE_HEIGHT = 0x806C;
		public const uint GL_UNPACK_SKIP_IMAGES = 0x806D;
		public const uint GL_UNPACK_IMAGE_HEIGHT = 0x806E;
		public const uint GL_TEXTURE_3D = 0x806F;
		public const uint GL_PROXY_TEXTURE_3D = 0x8070;
		public const uint GL_TEXTURE_DEPTH = 0x8071;
		public const uint GL_TEXTURE_WRAP_R = 0x8072;
		public const uint GL_MAX_3D_TEXTURE_SIZE = 0x8073;
		public const uint GL_TEXTURE_BINDING_3D = 0x806A;
		public const uint GL_COLOR_TABLE = 0x80D0;
		public const uint GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;
		public const uint GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;
		public const uint GL_PROXY_COLOR_TABLE = 0x80D3;
		public const uint GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;
		public const uint GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;
		public const uint GL_COLOR_TABLE_SCALE = 0x80D6;
		public const uint GL_COLOR_TABLE_BIAS = 0x80D7;
		public const uint GL_COLOR_TABLE_FORMAT = 0x80D8;
		public const uint GL_COLOR_TABLE_WIDTH = 0x80D9;
		public const uint GL_COLOR_TABLE_RED_SIZE = 0x80DA;
		public const uint GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;
		public const uint GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;
		public const uint GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;
		public const uint GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;
		public const uint GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;
		public const uint GL_CONVOLUTION_1D = 0x8010;
		public const uint GL_CONVOLUTION_2D = 0x8011;
		public const uint GL_SEPARABLE_2D = 0x8012;
		public const uint GL_CONVOLUTION_BORDER_MODE = 0x8013;
		public const uint GL_CONVOLUTION_FILTER_SCALE = 0x8014;
		public const uint GL_CONVOLUTION_FILTER_BIAS = 0x8015;
		public const uint GL_REDUCE = 0x8016;
		public const uint GL_CONVOLUTION_FORMAT = 0x8017;
		public const uint GL_CONVOLUTION_WIDTH = 0x8018;
		public const uint GL_CONVOLUTION_HEIGHT = 0x8019;
		public const uint GL_MAX_CONVOLUTION_WIDTH = 0x801A;
		public const uint GL_MAX_CONVOLUTION_HEIGHT = 0x801B;
		public const uint GL_POST_CONVOLUTION_RED_SCALE = 0x801C;
		public const uint GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;
		public const uint GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;
		public const uint GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;
		public const uint GL_POST_CONVOLUTION_RED_BIAS = 0x8020;
		public const uint GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;
		public const uint GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;
		public const uint GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;
		public const uint GL_CONSTANT_BORDER = 0x8151;
		public const uint GL_REPLICATE_BORDER = 0x8153;
		public const uint GL_CONVOLUTION_BORDER_COLOR = 0x8154;
		public const uint GL_COLOR_MATRIX = 0x80B1;
		public const uint GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;
		public const uint GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;
		public const uint GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;
		public const uint GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;
		public const uint GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;
		public const uint GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;
		public const uint GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;
		public const uint GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;
		public const uint GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;
		public const uint GL_HISTOGRAM = 0x8024;
		public const uint GL_PROXY_HISTOGRAM = 0x8025;
		public const uint GL_HISTOGRAM_WIDTH = 0x8026;
		public const uint GL_HISTOGRAM_FORMAT = 0x8027;
		public const uint GL_HISTOGRAM_RED_SIZE = 0x8028;
		public const uint GL_HISTOGRAM_GREEN_SIZE = 0x8029;
		public const uint GL_HISTOGRAM_BLUE_SIZE = 0x802A;
		public const uint GL_HISTOGRAM_ALPHA_SIZE = 0x802B;
		public const uint GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;
		public const uint GL_HISTOGRAM_SINK = 0x802D;
		public const uint GL_MINMAX = 0x802E;
		public const uint GL_MINMAX_FORMAT = 0x802F;
		public const uint GL_MINMAX_SINK = 0x8030;
		public const uint GL_TABLE_TOO_LARGE = 0x8031;
		public const uint GL_BLEND_EQUATION = 0x8009;
		public const uint GL_MIN = 0x8007;
		public const uint GL_MAX = 0x8008;
		public const uint GL_FUNC_ADD = 0x8006;
		public const uint GL_FUNC_SUBTRACT = 0x800A;
		public const uint GL_FUNC_REVERSE_SUBTRACT = 0x800B;
		public const uint GL_BLEND_COLOR = 0x8005;
		public const uint GL_CONSTANT_COLOR = 0x8001;
		public const uint GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;
		public const uint GL_CONSTANT_ALPHA = 0x8003;
		public const uint GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;
		public const uint GL_TEXTURE0 = 0x84C0;
		public const uint GL_TEXTURE1 = 0x84C1;
		public const uint GL_TEXTURE2 = 0x84C2;
		public const uint GL_TEXTURE3 = 0x84C3;
		public const uint GL_TEXTURE4 = 0x84C4;
		public const uint GL_TEXTURE5 = 0x84C5;
		public const uint GL_TEXTURE6 = 0x84C6;
		public const uint GL_TEXTURE7 = 0x84C7;
		public const uint GL_TEXTURE8 = 0x84C8;
		public const uint GL_TEXTURE9 = 0x84C9;
		public const uint GL_TEXTURE10 = 0x84CA;
		public const uint GL_TEXTURE11 = 0x84CB;
		public const uint GL_TEXTURE12 = 0x84CC;
		public const uint GL_TEXTURE13 = 0x84CD;
		public const uint GL_TEXTURE14 = 0x84CE;
		public const uint GL_TEXTURE15 = 0x84CF;
		public const uint GL_TEXTURE16 = 0x84D0;
		public const uint GL_TEXTURE17 = 0x84D1;
		public const uint GL_TEXTURE18 = 0x84D2;
		public const uint GL_TEXTURE19 = 0x84D3;
		public const uint GL_TEXTURE20 = 0x84D4;
		public const uint GL_TEXTURE21 = 0x84D5;
		public const uint GL_TEXTURE22 = 0x84D6;
		public const uint GL_TEXTURE23 = 0x84D7;
		public const uint GL_TEXTURE24 = 0x84D8;
		public const uint GL_TEXTURE25 = 0x84D9;
		public const uint GL_TEXTURE26 = 0x84DA;
		public const uint GL_TEXTURE27 = 0x84DB;
		public const uint GL_TEXTURE28 = 0x84DC;
		public const uint GL_TEXTURE29 = 0x84DD;
		public const uint GL_TEXTURE30 = 0x84DE;
		public const uint GL_TEXTURE31 = 0x84DF;
		public const uint GL_ACTIVE_TEXTURE = 0x84E0;
		public const uint GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;
		public const uint GL_MAX_TEXTURE_UNITS = 0x84E2;
		public const uint GL_NORMAL_MAP = 0x8511;
		public const uint GL_REFLECTION_MAP = 0x8512;
		public const uint GL_TEXTURE_CUBE_MAP = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;
		public const uint GL_COMPRESSED_ALPHA = 0x84E9;
		public const uint GL_COMPRESSED_LUMINANCE = 0x84EA;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;
		public const uint GL_COMPRESSED_INTENSITY = 0x84EC;
		public const uint GL_COMPRESSED_RGB = 0x84ED;
		public const uint GL_COMPRESSED_RGBA = 0x84EE;
		public const uint GL_TEXTURE_COMPRESSION_HINT = 0x84EF;
		public const uint GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSED = 0x86A1;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;
		public const uint GL_MULTISAMPLE = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE = 0x809F;
		public const uint GL_SAMPLE_COVERAGE = 0x80A0;
		public const uint GL_SAMPLE_BUFFERS = 0x80A8;
		public const uint GL_SAMPLES = 0x80A9;
		public const uint GL_SAMPLE_COVERAGE_VALUE = 0x80AA;
		public const uint GL_SAMPLE_COVERAGE_INVERT = 0x80AB;
		public const uint GL_MULTISAMPLE_BIT = 0x20000000;
		public const uint GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;
		public const uint GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;
		public const uint GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;
		public const uint GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;
		public const uint GL_COMBINE = 0x8570;
		public const uint GL_COMBINE_RGB = 0x8571;
		public const uint GL_COMBINE_ALPHA = 0x8572;
		public const uint GL_SOURCE0_RGB = 0x8580;
		public const uint GL_SOURCE1_RGB = 0x8581;
		public const uint GL_SOURCE2_RGB = 0x8582;
		public const uint GL_SOURCE0_ALPHA = 0x8588;
		public const uint GL_SOURCE1_ALPHA = 0x8589;
		public const uint GL_SOURCE2_ALPHA = 0x858A;
		public const uint GL_OPERAND0_RGB = 0x8590;
		public const uint GL_OPERAND1_RGB = 0x8591;
		public const uint GL_OPERAND2_RGB = 0x8592;
		public const uint GL_OPERAND0_ALPHA = 0x8598;
		public const uint GL_OPERAND1_ALPHA = 0x8599;
		public const uint GL_OPERAND2_ALPHA = 0x859A;
		public const uint GL_RGB_SCALE = 0x8573;
		public const uint GL_ADD_SIGNED = 0x8574;
		public const uint GL_INTERPOLATE = 0x8575;
		public const uint GL_SUBTRACT = 0x84E7;
		public const uint GL_CONSTANT = 0x8576;
		public const uint GL_PRIMARY_COLOR = 0x8577;
		public const uint GL_PREVIOUS = 0x8578;
		public const uint GL_DOT3_RGB = 0x86AE;
		public const uint GL_DOT3_RGBA = 0x86AF;
		public const uint GL_CLAMP_TO_BORDER = 0x812D;
		public const uint GL_ARB_multitexture = 1;
		public const uint GL_TEXTURE0_ARB = 0x84C0;
		public const uint GL_TEXTURE1_ARB = 0x84C1;
		public const uint GL_TEXTURE2_ARB = 0x84C2;
		public const uint GL_TEXTURE3_ARB = 0x84C3;
		public const uint GL_TEXTURE4_ARB = 0x84C4;
		public const uint GL_TEXTURE5_ARB = 0x84C5;
		public const uint GL_TEXTURE6_ARB = 0x84C6;
		public const uint GL_TEXTURE7_ARB = 0x84C7;
		public const uint GL_TEXTURE8_ARB = 0x84C8;
		public const uint GL_TEXTURE9_ARB = 0x84C9;
		public const uint GL_TEXTURE10_ARB = 0x84CA;
		public const uint GL_TEXTURE11_ARB = 0x84CB;
		public const uint GL_TEXTURE12_ARB = 0x84CC;
		public const uint GL_TEXTURE13_ARB = 0x84CD;
		public const uint GL_TEXTURE14_ARB = 0x84CE;
		public const uint GL_TEXTURE15_ARB = 0x84CF;
		public const uint GL_TEXTURE16_ARB = 0x84D0;
		public const uint GL_TEXTURE17_ARB = 0x84D1;
		public const uint GL_TEXTURE18_ARB = 0x84D2;
		public const uint GL_TEXTURE19_ARB = 0x84D3;
		public const uint GL_TEXTURE20_ARB = 0x84D4;
		public const uint GL_TEXTURE21_ARB = 0x84D5;
		public const uint GL_TEXTURE22_ARB = 0x84D6;
		public const uint GL_TEXTURE23_ARB = 0x84D7;
		public const uint GL_TEXTURE24_ARB = 0x84D8;
		public const uint GL_TEXTURE25_ARB = 0x84D9;
		public const uint GL_TEXTURE26_ARB = 0x84DA;
		public const uint GL_TEXTURE27_ARB = 0x84DB;
		public const uint GL_TEXTURE28_ARB = 0x84DC;
		public const uint GL_TEXTURE29_ARB = 0x84DD;
		public const uint GL_TEXTURE30_ARB = 0x84DE;
		public const uint GL_TEXTURE31_ARB = 0x84DF;
		public const uint GL_ACTIVE_TEXTURE_ARB = 0x84E0;
		public const uint GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;
		public const uint GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;
		public const uint GL_ARB_transpose_matrix = 1;
		public const uint GL_TRANSPOSE_MODELVIEW_MATRIX_ARB = 0x84E3;
		public const uint GL_TRANSPOSE_PROJECTION_MATRIX_ARB = 0x84E4;
		public const uint GL_TRANSPOSE_TEXTURE_MATRIX_ARB = 0x84E5;
		public const uint GL_TRANSPOSE_COLOR_MATRIX_ARB = 0x84E6;
		public const uint GL_ARB_texture_compression = 1;
		public const uint GL_COMPRESSED_ALPHA_ARB = 0x84E9;
		public const uint GL_COMPRESSED_LUMINANCE_ARB = 0x84EA;
		public const uint GL_COMPRESSED_LUMINANCE_ALPHA_ARB = 0x84EB;
		public const uint GL_COMPRESSED_INTENSITY_ARB = 0x84EC;
		public const uint GL_COMPRESSED_RGB_ARB = 0x84ED;
		public const uint GL_COMPRESSED_RGBA_ARB = 0x84EE;
		public const uint GL_TEXTURE_COMPRESSION_HINT_ARB = 0x84EF;
		public const uint GL_TEXTURE_IMAGE_SIZE_ARB = 0x86A0;
		public const uint GL_TEXTURE_COMPRESSED_ARB = 0x86A1;
		public const uint GL_NUM_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A2;
		public const uint GL_COMPRESSED_TEXTURE_FORMATS_ARB = 0x86A3;
		public const uint GL_ARB_texture_cube_map = 1;
		public const uint GL_NORMAL_MAP_ARB = 0x8511;
		public const uint GL_REFLECTION_MAP_ARB = 0x8512;
		public const uint GL_TEXTURE_CUBE_MAP_ARB = 0x8513;
		public const uint GL_TEXTURE_BINDING_CUBE_MAP_ARB = 0x8514;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_X_ARB = 0x8515;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_X_ARB = 0x8516;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Y_ARB = 0x8517;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Y_ARB = 0x8518;
		public const uint GL_TEXTURE_CUBE_MAP_POSITIVE_Z_ARB = 0x8519;
		public const uint GL_TEXTURE_CUBE_MAP_NEGATIVE_Z_ARB = 0x851A;
		public const uint GL_PROXY_TEXTURE_CUBE_MAP_ARB = 0x851B;
		public const uint GL_MAX_CUBE_MAP_TEXTURE_SIZE_ARB = 0x851C;
		public const uint GL_SGIX_shadow = 1;
		public const uint GL_TEXTURE_COMPARE_SGIX = 0x819A;
		public const uint GL_TEXTURE_COMPARE_OPERATOR_SGIX = 0x819B;
		public const uint GL_TEXTURE_LEQUAL_R_SGIX = 0x819C;
		public const uint GL_TEXTURE_GEQUAL_R_SGIX = 0x819D;
		public const uint GL_SGIX_depth_texture = 1;
		public const uint GL_DEPTH_COMPONENT16_SGIX = 0x81A5;
		public const uint GL_DEPTH_COMPONENT24_SGIX = 0x81A6;
		public const uint GL_DEPTH_COMPONENT32_SGIX = 0x81A7;
		public const uint GL_EXT_compiled_vertex_array = 1;
		public const uint GL_ARRAY_ELEMENT_LOCK_FIRST_EXT = 0x81A8;
		public const uint GL_ARRAY_ELEMENT_LOCK_COUNT_EXT = 0x81A9;
		public const uint GL_ARB_texture_env_combine = 1;
		public const uint GL_COMBINE_ARB = 0x8570;
		public const uint GL_COMBINE_RGB_ARB = 0x8571;
		public const uint GL_COMBINE_ALPHA_ARB = 0x8572;
		public const uint GL_RGB_SCALE_ARB = 0x8573;
		public const uint GL_ADD_SIGNED_ARB = 0x8574;
		public const uint GL_INTERPOLATE_ARB = 0x8575;
		public const uint GL_CONSTANT_ARB = 0x8576;
		public const uint GL_PRIMARY_COLOR_ARB = 0x8577;
		public const uint GL_PREVIOUS_ARB = 0x8578;
		public const uint GL_SOURCE0_RGB_ARB = 0x8580;
		public const uint GL_SOURCE1_RGB_ARB = 0x8581;
		public const uint GL_SOURCE2_RGB_ARB = 0x8582;
		public const uint GL_SOURCE0_ALPHA_ARB = 0x8588;
		public const uint GL_SOURCE1_ALPHA_ARB = 0x8589;
		public const uint GL_SOURCE2_ALPHA_ARB = 0x858A;
		public const uint GL_OPERAND0_RGB_ARB = 0x8590;
		public const uint GL_OPERAND1_RGB_ARB = 0x8591;
		public const uint GL_OPERAND2_RGB_ARB = 0x8592;
		public const uint GL_OPERAND0_ALPHA_ARB = 0x8598;
		public const uint GL_OPERAND1_ALPHA_ARB = 0x8599;
		public const uint GL_OPERAND2_ALPHA_ARB = 0x859A;
		public const uint GL_ARB_texture_env_dot3 = 1;
		public const uint GL_DOT3_RGB_ARB = 0x86AE;
		public const uint GL_DOT3_RGBA_ARB = 0x86AF;
		public const uint GL_ARB_texture_border_clamp = 1;
		public const uint GL_CLAMP_TO_BORDER_ARB = 0x812D;
		public const uint GL_ARB_texture_env_add = 1;
		public const uint GL_EXT_secondary_color = 1;
		public const uint GL_COLOR_SUM_EXT = 0x8458;
		public const uint GL_CURRENT_SECONDARY_COLOR_EXT = 0x8459;
		public const uint GL_SECONDARY_COLOR_ARRAY_SIZE_EXT = 0x845A;
		public const uint GL_SECONDARY_COLOR_ARRAY_TYPE_EXT = 0x845B;
		public const uint GL_SECONDARY_COLOR_ARRAY_STRIDE_EXT = 0x845C;
		public const uint GL_SECONDARY_COLOR_ARRAY_POINTER_EXT = 0x845D;
		public const uint GL_SECONDARY_COLOR_ARRAY_EXT = 0x845E;
		public const uint GL_EXT_fog_coord = 1;
		public const uint GL_FOG_COORDINATE_SOURCE_EXT = 0x8450;
		public const uint GL_FOG_COORDINATE_EXT = 0x8451;
		public const uint GL_FRAGMENT_DEPTH_EXT = 0x8452;
		public const uint GL_CURRENT_FOG_COORDINATE_EXT = 0x8453;
		public const uint GL_FOG_COORDINATE_ARRAY_TYPE_EXT = 0x8454;
		public const uint GL_FOG_COORDINATE_ARRAY_STRIDE_EXT = 0x8455;
		public const uint GL_FOG_COORDINATE_ARRAY_POINTER_EXT = 0x8456;
		public const uint GL_FOG_COORDINATE_ARRAY_EXT = 0x8457;
		public const uint GL_NV_vertex_array_range = 1;
		public const uint GL_VERTEX_ARRAY_RANGE_NV = 0x851D;
		public const uint GL_VERTEX_ARRAY_RANGE_LENGTH_NV = 0x851E;
		public const uint GL_VERTEX_ARRAY_RANGE_VALID_NV = 0x851F;
		public const uint GL_MAX_VERTEX_ARRAY_RANGE_ELEMENT_NV = 0x8520;
		public const uint GL_VERTEX_ARRAY_RANGE_POINTER_NV = 0x8521;
		public const uint GL_NV_vertex_array_range2 = 1;
		public const uint GL_VERTEX_ARRAY_RANGE_WITHOUT_FLUSH_NV = 0x8533;
		public const uint GL_EXT_point_parameters = 1;
		public const uint GL_POINT_SIZE_MIN_EXT = 0x8126;
		public const uint GL_POINT_SIZE_MAX_EXT = 0x8127;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE_EXT = 0x8128;
		public const uint GL_DISTANCE_ATTENUATION_EXT = 0x8129;
		public const uint GL_NV_register_combiners = 1;
		public const uint GL_REGISTER_COMBINERS_NV = 0x8522;
		public const uint GL_COMBINER0_NV = 0x8550;
		public const uint GL_COMBINER1_NV = 0x8551;
		public const uint GL_COMBINER2_NV = 0x8552;
		public const uint GL_COMBINER3_NV = 0x8553;
		public const uint GL_COMBINER4_NV = 0x8554;
		public const uint GL_COMBINER5_NV = 0x8555;
		public const uint GL_COMBINER6_NV = 0x8556;
		public const uint GL_COMBINER7_NV = 0x8557;
		public const uint GL_VARIABLE_A_NV = 0x8523;
		public const uint GL_VARIABLE_B_NV = 0x8524;
		public const uint GL_VARIABLE_C_NV = 0x8525;
		public const uint GL_VARIABLE_D_NV = 0x8526;
		public const uint GL_VARIABLE_E_NV = 0x8527;
		public const uint GL_VARIABLE_F_NV = 0x8528;
		public const uint GL_VARIABLE_G_NV = 0x8529;
		public const uint GL_CONSTANT_COLOR0_NV = 0x852A;
		public const uint GL_CONSTANT_COLOR1_NV = 0x852B;
		public const uint GL_PRIMARY_COLOR_NV = 0x852C;
		public const uint GL_SECONDARY_COLOR_NV = 0x852D;
		public const uint GL_SPARE0_NV = 0x852E;
		public const uint GL_SPARE1_NV = 0x852F;
		public const uint GL_UNSIGNED_IDENTITY_NV = 0x8536;
		public const uint GL_UNSIGNED_INVERT_NV = 0x8537;
		public const uint GL_EXPAND_NORMAL_NV = 0x8538;
		public const uint GL_EXPAND_NEGATE_NV = 0x8539;
		public const uint GL_HALF_BIAS_NORMAL_NV = 0x853A;
		public const uint GL_HALF_BIAS_NEGATE_NV = 0x853B;
		public const uint GL_SIGNED_IDENTITY_NV = 0x853C;
		public const uint GL_SIGNED_NEGATE_NV = 0x853D;
		public const uint GL_E_TIMES_F_NV = 0x8531;
		public const uint GL_SPARE0_PLUS_SECONDARY_COLOR_NV = 0x8532;
		public const uint GL_SCALE_BY_TWO_NV = 0x853E;
		public const uint GL_SCALE_BY_FOUR_NV = 0x853F;
		public const uint GL_SCALE_BY_ONE_HALF_NV = 0x8540;
		public const uint GL_BIAS_BY_NEGATIVE_ONE_HALF_NV = 0x8541;
		public const uint GL_DISCARD_NV = 0x8530;
		public const uint GL_COMBINER_INPUT_NV = 0x8542;
		public const uint GL_COMBINER_MAPPING_NV = 0x8543;
		public const uint GL_COMBINER_COMPONENT_USAGE_NV = 0x8544;
		public const uint GL_COMBINER_AB_DOT_PRODUCT_NV = 0x8545;
		public const uint GL_COMBINER_CD_DOT_PRODUCT_NV = 0x8546;
		public const uint GL_COMBINER_MUX_SUM_NV = 0x8547;
		public const uint GL_COMBINER_SCALE_NV = 0x8548;
		public const uint GL_COMBINER_BIAS_NV = 0x8549;
		public const uint GL_COMBINER_AB_OUTPUT_NV = 0x854A;
		public const uint GL_COMBINER_CD_OUTPUT_NV = 0x854B;
		public const uint GL_COMBINER_SUM_OUTPUT_NV = 0x854C;
		public const uint GL_NUM_GENERAL_COMBINERS_NV = 0x854E;
		public const uint GL_COLOR_SUM_CLAMP_NV = 0x854F;
		public const uint GL_MAX_GENERAL_COMBINERS_NV = 0x854D;
		public const uint GL_ARB_multisample = 1;
		public const uint GL_MULTISAMPLE_ARB = 0x809D;
		public const uint GL_SAMPLE_ALPHA_TO_COVERAGE_ARB = 0x809E;
		public const uint GL_SAMPLE_ALPHA_TO_ONE_ARB = 0x809F;
		public const uint GL_SAMPLE_COVERAGE_ARB = 0x80A0;
		public const uint GL_SAMPLE_BUFFERS_ARB = 0x80A8;
		public const uint GL_SAMPLES_ARB = 0x80A9;
		public const uint GL_SAMPLE_COVERAGE_VALUE_ARB = 0x80AA;
		public const uint GL_SAMPLE_COVERAGE_INVERT_ARB = 0x80AB;
		public const uint GL_MULTISAMPLE_BIT_ARB = 0x20000000;
		public const uint GL_NV_texture_shader = 1;
		public const uint GL_TEXTURE_SHADER_NV = 0x86DE;
		public const uint GL_RGBA_UNSIGNED_DOT_PRODUCT_MAPPING_NV = 0x86D9;
		public const uint GL_SHADER_OPERATION_NV = 0x86DF;
		public const uint GL_CULL_MODES_NV = 0x86E0;
		public const uint GL_OFFSET_TEXTURE_MATRIX_NV = 0x86E1;
		public const uint GL_OFFSET_TEXTURE_SCALE_NV = 0x86E2;
		public const uint GL_OFFSET_TEXTURE_BIAS_NV = 0x86E3;
		public const uint GL_PREVIOUS_TEXTURE_INPUT_NV = 0x86E4;
		public const uint GL_CONST_EYE_NV = 0x86E5;
		public const uint GL_SHADER_CONSISTENT_NV = 0x86DD;
		public const uint GL_PASS_THROUGH_NV = 0x86E6;
		public const uint GL_CULL_FRAGMENT_NV = 0x86E7;
		public const uint GL_OFFSET_TEXTURE_2D_NV = 0x86E8;
		public const uint GL_OFFSET_TEXTURE_RECTANGLE_NV = 0x864C;
		public const uint GL_OFFSET_TEXTURE_RECTANGLE_SCALE_NV = 0x864D;
		public const uint GL_DEPENDENT_AR_TEXTURE_2D_NV = 0x86E9;
		public const uint GL_DEPENDENT_GB_TEXTURE_2D_NV = 0x86EA;
		public const uint GL_DOT_PRODUCT_NV = 0x86EC;
		public const uint GL_DOT_PRODUCT_DEPTH_REPLACE_NV = 0x86ED;
		public const uint GL_DOT_PRODUCT_TEXTURE_2D_NV = 0x86EE;
		public const uint GL_DOT_PRODUCT_TEXTURE_RECTANGLE_NV = 0x864E;
		public const uint GL_DOT_PRODUCT_TEXTURE_CUBE_MAP_NV = 0x86F0;
		public const uint GL_DOT_PRODUCT_DIFFUSE_CUBE_MAP_NV = 0x86F1;
		public const uint GL_DOT_PRODUCT_REFLECT_CUBE_MAP_NV = 0x86F2;
		public const uint GL_DOT_PRODUCT_CONST_EYE_REFLECT_CUBE_MAP_NV = 0x86F3;
		public const uint GL_HILO_NV = 0x86F4;
		public const uint GL_DSDT_NV = 0x86F5;
		public const uint GL_DSDT_MAG_NV = 0x86F6;
		public const uint GL_DSDT_MAG_VIB_NV = 0x86F7;
		public const uint GL_UNSIGNED_INT_S8_S8_8_8_NV = 0x86DA;
		public const uint GL_UNSIGNED_INT_8_8_S8_S8_REV_NV = 0x86DB;
		public const uint GL_SIGNED_RGBA_NV = 0x86FB;
		public const uint GL_SIGNED_RGBA8_NV = 0x86FC;
		public const uint GL_SIGNED_RGB_NV = 0x86FE;
		public const uint GL_SIGNED_RGB8_NV = 0x86FF;
		public const uint GL_SIGNED_LUMINANCE_NV = 0x8701;
		public const uint GL_SIGNED_LUMINANCE8_NV = 0x8702;
		public const uint GL_SIGNED_LUMINANCE_ALPHA_NV = 0x8703;
		public const uint GL_SIGNED_LUMINANCE8_ALPHA8_NV = 0x8704;
		public const uint GL_SIGNED_ALPHA_NV = 0x8705;
		public const uint GL_SIGNED_ALPHA8_NV = 0x8706;
		public const uint GL_SIGNED_INTENSITY_NV = 0x8707;
		public const uint GL_SIGNED_INTENSITY8_NV = 0x8708;
		public const uint GL_SIGNED_RGB_UNSIGNED_ALPHA_NV = 0x870C;
		public const uint GL_SIGNED_RGB8_UNSIGNED_ALPHA8_NV = 0x870D;
		public const uint GL_HILO16_NV = 0x86F8;
		public const uint GL_SIGNED_HILO_NV = 0x86F9;
		public const uint GL_SIGNED_HILO16_NV = 0x86FA;
		public const uint GL_DSDT8_NV = 0x8709;
		public const uint GL_DSDT8_MAG8_NV = 0x870A;
		public const uint GL_DSDT_MAG_INTENSITY_NV = 0x86DC;
		public const uint GL_DSDT8_MAG8_INTENSITY8_NV = 0x870B;
		public const uint GL_HI_SCALE_NV = 0x870E;
		public const uint GL_LO_SCALE_NV = 0x870F;
		public const uint GL_DS_SCALE_NV = 0x8710;
		public const uint GL_DT_SCALE_NV = 0x8711;
		public const uint GL_MAGNITUDE_SCALE_NV = 0x8712;
		public const uint GL_VIBRANCE_SCALE_NV = 0x8713;
		public const uint GL_HI_BIAS_NV = 0x8714;
		public const uint GL_LO_BIAS_NV = 0x8715;
		public const uint GL_DS_BIAS_NV = 0x8716;
		public const uint GL_DT_BIAS_NV = 0x8717;
		public const uint GL_MAGNITUDE_BIAS_NV = 0x8718;
		public const uint GL_VIBRANCE_BIAS_NV = 0x8719;
		public const uint GL_TEXTURE_BORDER_VALUES_NV = 0x871A;
		public const uint GL_TEXTURE_HI_SIZE_NV = 0x871B;
		public const uint GL_TEXTURE_LO_SIZE_NV = 0x871C;
		public const uint GL_TEXTURE_DS_SIZE_NV = 0x871D;
		public const uint GL_TEXTURE_DT_SIZE_NV = 0x871E;
		public const uint GL_TEXTURE_MAG_SIZE_NV = 0x871F;
		public const uint GL_NV_texture_rectangle = 1;
		public const uint GL_TEXTURE_RECTANGLE_NV = 0x84F5;
		public const uint GL_TEXTURE_BINDING_RECTANGLE_NV = 0x84F6;
		public const uint GL_PROXY_TEXTURE_RECTANGLE_NV = 0x84F7;
		public const uint GL_MAX_RECTANGLE_TEXTURE_SIZE_NV = 0x84F8;
		public const uint GL_NV_texture_env_combine4 = 1;
		public const uint GL_COMBINE4_NV = 0x8503;
		public const uint GL_SOURCE3_RGB_NV = 0x8583;
		public const uint GL_SOURCE3_ALPHA_NV = 0x858B;
		public const uint GL_OPERAND3_RGB_NV = 0x8593;
		public const uint GL_OPERAND3_ALPHA_NV = 0x859B;
		public const uint GL_NV_fog_distance = 1;
		public const uint GL_FOG_DISTANCE_MODE_NV = 0x855A;
		public const uint GL_EYE_RADIAL_NV = 0x855B;
		public const uint GL_EYE_PLANE_ABSOLUTE_NV = 0x855C;
		public const uint GL_EXT_texture_filter_anisotropic = 1;
		public const uint GL_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FE;
		public const uint GL_MAX_TEXTURE_MAX_ANISOTROPY_EXT = 0x84FF;
		public const uint GL_SGIS_generate_mipmap = 1;
		public const uint GL_GENERATE_MIPMAP_SGIS = 0x8191;
		public const uint GL_GENERATE_MIPMAP_HINT_SGIS = 0x8192;
		public const uint GL_NV_texgen_reflection = 1;
		public const uint GL_NORMAL_MAP_NV = 0x8511;
		public const uint GL_REFLECTION_MAP_NV = 0x8512;
		public const uint GL_EXT_vertex_weighting = 1;
		public const uint GL_MODELVIEW0_STACK_DEPTH_EXT = 0x0BA3;
		public const uint GL_MODELVIEW1_STACK_DEPTH_EXT = 0x8502;
		public const uint GL_MODELVIEW0_MATRIX_EXT = 0x0BA6;
		public const uint GL_MODELVIEW1_MATRIX_EXT = 0x8506;
		public const uint GL_VERTEX_WEIGHTING_EXT = 0x8509;
		public const uint GL_MODELVIEW0_EXT = 0x1700;
		public const uint GL_MODELVIEW1_EXT = 0x850A;
		public const uint GL_CURRENT_VERTEX_WEIGHT_EXT = 0x850B;
		public const uint GL_VERTEX_WEIGHT_ARRAY_EXT = 0x850C;
		public const uint GL_VERTEX_WEIGHT_ARRAY_SIZE_EXT = 0x850D;
		public const uint GL_VERTEX_WEIGHT_ARRAY_TYPE_EXT = 0x850E;
		public const uint GL_VERTEX_WEIGHT_ARRAY_STRIDE_EXT = 0x850F;
		public const uint GL_VERTEX_WEIGHT_ARRAY_POINTER_EXT = 0x8510;
		public const uint GL_NV_vertex_program = 1;
		public const uint GL_VERTEX_PROGRAM_NV = 0x8620;
		public const uint GL_VERTEX_PROGRAM_POINT_SIZE_NV = 0x8642;
		public const uint GL_VERTEX_PROGRAM_TWO_SIDE_NV = 0x8643;
		public const uint GL_VERTEX_STATE_PROGRAM_NV = 0x8621;
		public const uint GL_ATTRIB_ARRAY_SIZE_NV = 0x8623;
		public const uint GL_ATTRIB_ARRAY_STRIDE_NV = 0x8624;
		public const uint GL_ATTRIB_ARRAY_TYPE_NV = 0x8625;
		public const uint GL_CURRENT_ATTRIB_NV = 0x8626;
		public const uint GL_PROGRAM_PARAMETER_NV = 0x8644;
		public const uint GL_ATTRIB_ARRAY_POINTER_NV = 0x8645;
		public const uint GL_PROGRAM_TARGET_NV = 0x8646;
		public const uint GL_PROGRAM_LENGTH_NV = 0x8627;
		public const uint GL_PROGRAM_RESIDENT_NV = 0x8647;
		public const uint GL_PROGRAM_STRING_NV = 0x8628;
		public const uint GL_TRACK_MATRIX_NV = 0x8648;
		public const uint GL_TRACK_MATRIX_TRANSFORM_NV = 0x8649;
		public const uint GL_MAX_TRACK_MATRIX_STACK_DEPTH_NV = 0x862E;
		public const uint GL_MAX_TRACK_MATRICES_NV = 0x862F;
		public const uint GL_CURRENT_MATRIX_STACK_DEPTH_NV = 0x8640;
		public const uint GL_CURRENT_MATRIX_NV = 0x8641;
		public const uint GL_VERTEX_PROGRAM_BINDING_NV = 0x864A;
		public const uint GL_PROGRAM_ERROR_POSITION_NV = 0x864B;
		public const uint GL_MODELVIEW_PROJECTION_NV = 0x8629;
		public const uint GL_MATRIX0_NV = 0x8630;
		public const uint GL_MATRIX1_NV = 0x8631;
		public const uint GL_MATRIX2_NV = 0x8632;
		public const uint GL_MATRIX3_NV = 0x8633;
		public const uint GL_MATRIX4_NV = 0x8634;
		public const uint GL_MATRIX5_NV = 0x8635;
		public const uint GL_MATRIX6_NV = 0x8636;
		public const uint GL_MATRIX7_NV = 0x8637;
		public const uint GL_IDENTITY_NV = 0x862A;
		public const uint GL_INVERSE_NV = 0x862B;
		public const uint GL_TRANSPOSE_NV = 0x862C;
		public const uint GL_INVERSE_TRANSPOSE_NV = 0x862D;
		public const uint GL_VERTEX_ATTRIB_ARRAY0_NV = 0x8650;
		public const uint GL_VERTEX_ATTRIB_ARRAY1_NV = 0x8651;
		public const uint GL_VERTEX_ATTRIB_ARRAY2_NV = 0x8652;
		public const uint GL_VERTEX_ATTRIB_ARRAY3_NV = 0x8653;
		public const uint GL_VERTEX_ATTRIB_ARRAY4_NV = 0x8654;
		public const uint GL_VERTEX_ATTRIB_ARRAY5_NV = 0x8655;
		public const uint GL_VERTEX_ATTRIB_ARRAY6_NV = 0x8656;
		public const uint GL_VERTEX_ATTRIB_ARRAY7_NV = 0x8657;
		public const uint GL_VERTEX_ATTRIB_ARRAY8_NV = 0x8658;
		public const uint GL_VERTEX_ATTRIB_ARRAY9_NV = 0x8659;
		public const uint GL_VERTEX_ATTRIB_ARRAY10_NV = 0x865A;
		public const uint GL_VERTEX_ATTRIB_ARRAY11_NV = 0x865B;
		public const uint GL_VERTEX_ATTRIB_ARRAY12_NV = 0x865C;
		public const uint GL_VERTEX_ATTRIB_ARRAY13_NV = 0x865D;
		public const uint GL_VERTEX_ATTRIB_ARRAY14_NV = 0x865E;
		public const uint GL_VERTEX_ATTRIB_ARRAY15_NV = 0x865F;
		public const uint GL_MAP1_VERTEX_ATTRIB0_4_NV = 0x8660;
		public const uint GL_MAP1_VERTEX_ATTRIB1_4_NV = 0x8661;
		public const uint GL_MAP1_VERTEX_ATTRIB2_4_NV = 0x8662;
		public const uint GL_MAP1_VERTEX_ATTRIB3_4_NV = 0x8663;
		public const uint GL_MAP1_VERTEX_ATTRIB4_4_NV = 0x8664;
		public const uint GL_MAP1_VERTEX_ATTRIB5_4_NV = 0x8665;
		public const uint GL_MAP1_VERTEX_ATTRIB6_4_NV = 0x8666;
		public const uint GL_MAP1_VERTEX_ATTRIB7_4_NV = 0x8667;
		public const uint GL_MAP1_VERTEX_ATTRIB8_4_NV = 0x8668;
		public const uint GL_MAP1_VERTEX_ATTRIB9_4_NV = 0x8669;
		public const uint GL_MAP1_VERTEX_ATTRIB10_4_NV = 0x866A;
		public const uint GL_MAP1_VERTEX_ATTRIB11_4_NV = 0x866B;
		public const uint GL_MAP1_VERTEX_ATTRIB12_4_NV = 0x866C;
		public const uint GL_MAP1_VERTEX_ATTRIB13_4_NV = 0x866D;
		public const uint GL_MAP1_VERTEX_ATTRIB14_4_NV = 0x866E;
		public const uint GL_MAP1_VERTEX_ATTRIB15_4_NV = 0x866F;
		public const uint GL_MAP2_VERTEX_ATTRIB0_4_NV = 0x8670;
		public const uint GL_MAP2_VERTEX_ATTRIB1_4_NV = 0x8671;
		public const uint GL_MAP2_VERTEX_ATTRIB2_4_NV = 0x8672;
		public const uint GL_MAP2_VERTEX_ATTRIB3_4_NV = 0x8673;
		public const uint GL_MAP2_VERTEX_ATTRIB4_4_NV = 0x8674;
		public const uint GL_MAP2_VERTEX_ATTRIB5_4_NV = 0x8675;
		public const uint GL_MAP2_VERTEX_ATTRIB6_4_NV = 0x8676;
		public const uint GL_MAP2_VERTEX_ATTRIB7_4_NV = 0x8677;
		public const uint GL_MAP2_VERTEX_ATTRIB8_4_NV = 0x8678;
		public const uint GL_MAP2_VERTEX_ATTRIB9_4_NV = 0x8679;
		public const uint GL_MAP2_VERTEX_ATTRIB10_4_NV = 0x867A;
		public const uint GL_MAP2_VERTEX_ATTRIB11_4_NV = 0x867B;
		public const uint GL_MAP2_VERTEX_ATTRIB12_4_NV = 0x867C;
		public const uint GL_MAP2_VERTEX_ATTRIB13_4_NV = 0x867D;
		public const uint GL_MAP2_VERTEX_ATTRIB14_4_NV = 0x867E;
		public const uint GL_MAP2_VERTEX_ATTRIB15_4_NV = 0x867F;
		public const uint GL_NV_fance = 1;
		public const uint GL_ALL_COMPLETED_NV = 0x84F2;
		public const uint GL_FENCE_STATUS_NV = 0x84F3;
		public const uint GL_FENCE_CONDITION_NV = 0x84F4;
		public const uint GL_DOT_PRODUCT_TEXTURE_3D_NV = 0x86EF;
		public const uint GL_NV_blend_square = 1;
		public const uint GL_NV_light_max_exponent = 1;
		public const uint GL_MAX_SHININESS_NV = 0x8504;
		public const uint GL_MAX_SPOT_EXPONENT_NV = 0x8505;
		public const uint GL_NV_packed_depth_stencil = 1;
		public const uint GL_DEPTH_STENCIL_NV = 0x84F9;
		public const uint GL_UNSIGNED_INT_24_8_NV = 0x84FA;
		public const uint GL_PER_STAGE_CONSTANTS_NV = 0x8535;
		public const uint GL_EXT_abgr = 1;
		public const uint GL_ABGR_EXT = 0x8000;
		public const uint GL_EXT_stencil_wrap = 1;
		public const uint GL_INCR_WRAP_EXT = 0x8507;
		public const uint GL_DECR_WRAP_EXT = 0x8508;
		public const uint GL_EXT_texture_lod_bias = 1;
		public const uint GL_TEXTURE_FILTER_CONTROL_EXT = 0x8500;
		public const uint GL_TEXTURE_LOD_BIAS_EXT = 0x8501;
		public const uint GL_MAX_TEXTURE_LOD_BIAS_EXT = 0x84FD;
		public const uint GL_NV_evaluators = 1;
		public const uint GL_EVAL_2D_NV = 0x86C0;
		public const uint GL_EVAL_TRIANGULAR_2D_NV = 0x86C1;
		public const uint GL_MAP_TESSELLATION_NV = 0x86C2;
		public const uint GL_MAP_ATTRIB_U_ORDER_NV = 0x86C3;
		public const uint GL_MAP_ATTRIB_V_ORDER_NV = 0x86C4;
		public const uint GL_EVAL_FRACTIONAL_TESSELLATION_NV = 0x86C5;
		public const uint GL_EVAL_VERTEX_ATTRIB0_NV = 0x86C6;
		public const uint GL_EVAL_VERTEX_ATTRIB1_NV = 0x86C7;
		public const uint GL_EVAL_VERTEX_ATTRIB2_NV = 0x86C8;
		public const uint GL_EVAL_VERTEX_ATTRIB3_NV = 0x86C9;
		public const uint GL_EVAL_VERTEX_ATTRIB4_NV = 0x86CA;
		public const uint GL_EVAL_VERTEX_ATTRIB5_NV = 0x86CB;
		public const uint GL_EVAL_VERTEX_ATTRIB6_NV = 0x86CC;
		public const uint GL_EVAL_VERTEX_ATTRIB7_NV = 0x86CD;
		public const uint GL_EVAL_VERTEX_ATTRIB8_NV = 0x86CE;
		public const uint GL_EVAL_VERTEX_ATTRIB9_NV = 0x86CF;
		public const uint GL_EVAL_VERTEX_ATTRIB10_NV = 0x86D0;
		public const uint GL_EVAL_VERTEX_ATTRIB11_NV = 0x86D1;
		public const uint GL_EVAL_VERTEX_ATTRIB12_NV = 0x86D2;
		public const uint GL_EVAL_VERTEX_ATTRIB13_NV = 0x86D3;
		public const uint GL_EVAL_VERTEX_ATTRIB14_NV = 0x86D4;
		public const uint GL_EVAL_VERTEX_ATTRIB15_NV = 0x86D5;
		public const uint GL_MAX_MAP_TESSELLATION_NV = 0x86D6;
		public const uint GL_MAX_RATIONAL_EVAL_ORDER_NV = 0x86D7;
		public const uint GL_NV_copy_depth_to_color = 1;
		public const uint GL_DEPTH_STENCIL_TO_RGBA_NV = 0x886E;
		public const uint GL_DEPTH_STENCIL_TO_BGRA_NV = 0x886F;
		public const uint GL_ATI_pn_triangles = 1;
		public const uint GL_PN_TRIANGLES_ATI = 0x87F0;
		public const uint GL_MAX_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F1;
		public const uint GL_PN_TRIANGLES_POINT_MODE_ATI = 0x87F2;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_ATI = 0x87F3;
		public const uint GL_PN_TRIANGLES_TESSELATION_LEVEL_ATI = 0x87F4;
		public const uint GL_PN_TRIANGLES_POINT_MODE_LINEAR_ATI = 0x87F5;
		public const uint GL_PN_TRIANGLES_POINT_MODE_CUBIC_ATI = 0x87F6;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_LINEAR_ATI = 0x87F7;
		public const uint GL_PN_TRIANGLES_NORMAL_MODE_QUADRATIC_ATI = 0x87F8;
		public const uint GL_ARB_point_parameters = 1;
		public const uint GL_POINT_SIZE_MIN_ARB = 0x8126;
		public const uint GL_POINT_SIZE_MAX_ARB = 0x8127;
		public const uint GL_POINT_FADE_THRESHOLD_SIZE_ARB = 0x8128;
		public const uint GL_POINT_DISTANCE_ATTENUATION_ARB = 0x8129;
		public const uint GL_ARB_texture_env_crossbar = 1;
		public const uint GL_ARB_vertex_blend = 1;
		public const uint GL_MAX_VERTEX_UNITS_ARB = 0x86A4;
		public const uint GL_ACTIVE_VERTEX_UNITS_ARB = 0x86A5;
		public const uint GL_WEIGHT_SUM_UNITY_ARB = 0x86A6;
		public const uint GL_VERTEX_BLEND_ARB = 0x86A7;
		public const uint GL_CURRENT_WEIGHT_ARB = 0x86A8;
		public const uint GL_WEIGHT_ARRAY_TYPE_ARB = 0x86A9;
		public const uint GL_WEIGHT_ARRAY_STRIDE_ARB = 0x86AA;
		public const uint GL_WEIGHT_ARRAY_SIZE_ARB = 0x86AB;
		public const uint GL_WEIGHT_ARRAY_POINTER_ARB = 0x86AC;
		public const uint GL_WEIGHT_ARRAY_ARB = 0x86AD;
		public const uint GL_MODELVIEW0_ARB = 0x1700;
		public const uint GL_MODELVIEW1_ARB = 0x850a;
		public const uint GL_MODELVIEW2_ARB = 0x8722;
		public const uint GL_MODELVIEW3_ARB = 0x8723;
		public const uint GL_MODELVIEW4_ARB = 0x8724;
		public const uint GL_MODELVIEW5_ARB = 0x8725;
		public const uint GL_MODELVIEW6_ARB = 0x8726;
		public const uint GL_MODELVIEW7_ARB = 0x8727;
		public const uint GL_MODELVIEW8_ARB = 0x8728;
		public const uint GL_MODELVIEW9_ARB = 0x8729;
		public const uint GL_MODELVIEW10_ARB = 0x872A;
		public const uint GL_MODELVIEW11_ARB = 0x872B;
		public const uint GL_MODELVIEW12_ARB = 0x872C;
		public const uint GL_MODELVIEW13_ARB = 0x872D;
		public const uint GL_MODELVIEW14_ARB = 0x872E;
		public const uint GL_MODELVIEW15_ARB = 0x872F;
		public const uint GL_MODELVIEW16_ARB = 0x8730;
		public const uint GL_MODELVIEW17_ARB = 0x8731;
		public const uint GL_MODELVIEW18_ARB = 0x8732;
		public const uint GL_MODELVIEW19_ARB = 0x8733;
		public const uint GL_MODELVIEW20_ARB = 0x8734;
		public const uint GL_MODELVIEW21_ARB = 0x8735;
		public const uint GL_MODELVIEW22_ARB = 0x8736;
		public const uint GL_MODELVIEW23_ARB = 0x8737;
		public const uint GL_MODELVIEW24_ARB = 0x8738;
		public const uint GL_MODELVIEW25_ARB = 0x8739;
		public const uint GL_MODELVIEW26_ARB = 0x873A;
		public const uint GL_MODELVIEW27_ARB = 0x873B;
		public const uint GL_MODELVIEW28_ARB = 0x873C;
		public const uint GL_MODELVIEW29_ARB = 0x873D;
		public const uint GL_MODELVIEW30_ARB = 0x873E;
		public const uint GL_MODELVIEW31_ARB = 0x873F;
		public const uint GL_EXT_multi_draw_arrays = 1;
		public const uint GL_ARB_matrix_palette = 1;
		public const uint GL_MATRIX_PALETTE_ARB = 0x8840;
		public const uint GL_MAX_MATRIX_PALETTE_STACK_DEPTH_ARB = 0x8841;
		public const uint GL_MAX_PALETTE_MATRICES_ARB = 0x8842;
		public const uint GL_CURRENT_PALETTE_MATRIX_ARB = 0x8843;
		public const uint GL_MATRIX_INDEX_ARRAY_ARB = 0x8844;
		public const uint GL_CURRENT_MATRIX_INDEX_ARB = 0x8845;
		public const uint GL_MATRIX_INDEX_ARRAY_SIZE_ARB = 0x8846;
		public const uint GL_MATRIX_INDEX_ARRAY_TYPE_ARB = 0x8847;
		public const uint GL_MATRIX_INDEX_ARRAY_STRIDE_ARB = 0x8848;
		public const uint GL_MATRIX_INDEX_ARRAY_POINTER_ARB = 0x8849;
		public const uint GL_EXT_vertex_shader = 1;
		public const uint GL_VERTEX_SHADER_EXT = 0x8780;
		public const uint GL_VERTEX_SHADER_BINDING_EXT = 0x8781;
		public const uint GL_OP_INDEX_EXT = 0x8782;
		public const uint GL_OP_NEGATE_EXT = 0x8783;
		public const uint GL_OP_DOT3_EXT = 0x8784;
		public const uint GL_OP_DOT4_EXT = 0x8785;
		public const uint GL_OP_MUL_EXT = 0x8786;
		public const uint GL_OP_ADD_EXT = 0x8787;
		public const uint GL_OP_MADD_EXT = 0x8788;
		public const uint GL_OP_FRAC_EXT = 0x8789;
		public const uint GL_OP_MAX_EXT = 0x878A;
		public const uint GL_OP_MIN_EXT = 0x878B;
		public const uint GL_OP_SET_GE_EXT = 0x878C;
		public const uint GL_OP_SET_LT_EXT = 0x878D;
		public const uint GL_OP_CLAMP_EXT = 0x878E;
		public const uint GL_OP_FLOOR_EXT = 0x878F;
		public const uint GL_OP_ROUND_EXT = 0x8790;
		public const uint GL_OP_EXP_BASE_2_EXT = 0x8791;
		public const uint GL_OP_LOG_BASE_2_EXT = 0x8792;
		public const uint GL_OP_POWER_EXT = 0x8793;
		public const uint GL_OP_RECIP_EXT = 0x8794;
		public const uint GL_OP_RECIP_SQRT_EXT = 0x8795;
		public const uint GL_OP_SUB_EXT = 0x8796;
		public const uint GL_OP_CROSS_PRODUCT_EXT = 0x8797;
		public const uint GL_OP_MULTIPLY_MATRIX_EXT = 0x8798;
		public const uint GL_OP_MOV_EXT = 0x8799;
		public const uint GL_OUTPUT_VERTEX_EXT = 0x879A;
		public const uint GL_OUTPUT_COLOR0_EXT = 0x879B;
		public const uint GL_OUTPUT_COLOR1_EXT = 0x879C;
		public const uint GL_OUTPUT_TEXTURE_COORD0_EXT = 0x879D;
		public const uint GL_OUTPUT_TEXTURE_COORD1_EXT = 0x879E;
		public const uint GL_OUTPUT_TEXTURE_COORD2_EXT = 0x879F;
		public const uint GL_OUTPUT_TEXTURE_COORD3_EXT = 0x87A0;
		public const uint GL_OUTPUT_TEXTURE_COORD4_EXT = 0x87A1;
		public const uint GL_OUTPUT_TEXTURE_COORD5_EXT = 0x87A2;
		public const uint GL_OUTPUT_TEXTURE_COORD6_EXT = 0x87A3;
		public const uint GL_OUTPUT_TEXTURE_COORD7_EXT = 0x87A4;
		public const uint GL_OUTPUT_TEXTURE_COORD8_EXT = 0x87A5;
		public const uint GL_OUTPUT_TEXTURE_COORD9_EXT = 0x87A6;
		public const uint GL_OUTPUT_TEXTURE_COORD10_EXT = 0x87A7;
		public const uint GL_OUTPUT_TEXTURE_COORD11_EXT = 0x87A8;
		public const uint GL_OUTPUT_TEXTURE_COORD12_EXT = 0x87A9;
		public const uint GL_OUTPUT_TEXTURE_COORD13_EXT = 0x87AA;
		public const uint GL_OUTPUT_TEXTURE_COORD14_EXT = 0x87AB;
		public const uint GL_OUTPUT_TEXTURE_COORD15_EXT = 0x87AC;
		public const uint GL_OUTPUT_TEXTURE_COORD16_EXT = 0x87AD;
		public const uint GL_OUTPUT_TEXTURE_COORD17_EXT = 0x87AE;
		public const uint GL_OUTPUT_TEXTURE_COORD18_EXT = 0x87AF;
		public const uint GL_OUTPUT_TEXTURE_COORD19_EXT = 0x87B0;
		public const uint GL_OUTPUT_TEXTURE_COORD20_EXT = 0x87B1;
		public const uint GL_OUTPUT_TEXTURE_COORD21_EXT = 0x87B2;
		public const uint GL_OUTPUT_TEXTURE_COORD22_EXT = 0x87B3;
		public const uint GL_OUTPUT_TEXTURE_COORD23_EXT = 0x87B4;
		public const uint GL_OUTPUT_TEXTURE_COORD24_EXT = 0x87B5;
		public const uint GL_OUTPUT_TEXTURE_COORD25_EXT = 0x87B6;
		public const uint GL_OUTPUT_TEXTURE_COORD26_EXT = 0x87B7;
		public const uint GL_OUTPUT_TEXTURE_COORD27_EXT = 0x87B8;
		public const uint GL_OUTPUT_TEXTURE_COORD28_EXT = 0x87B9;
		public const uint GL_OUTPUT_TEXTURE_COORD29_EXT = 0x87BA;
		public const uint GL_OUTPUT_TEXTURE_COORD30_EXT = 0x87BB;
		public const uint GL_OUTPUT_TEXTURE_COORD31_EXT = 0x87BC;
		public const uint GL_OUTPUT_FOG_EXT = 0x87BD;
		public const uint GL_SCALAR_EXT = 0x87BE;
		public const uint GL_VECTOR_EXT = 0x87BF;
		public const uint GL_MATRIX_EXT = 0x87C0;
		public const uint GL_VARIANT_EXT = 0x87C1;
		public const uint GL_INVARIANT_EXT = 0x87C2;
		public const uint GL_LOCAL_CONSTANT_EXT = 0x87C3;
		public const uint GL_LOCAL_EXT = 0x87C4;
		public const uint GL_MAX_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87C5;
		public const uint GL_MAX_VERTEX_SHADER_VARIANTS_EXT = 0x87C6;
		public const uint GL_MAX_VERTEX_SHADER_INVARIANTS_EXT = 0x87C7;
		public const uint GL_MAX_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87C8;
		public const uint GL_MAX_VERTEX_SHADER_LOCALS_EXT = 0x87C9;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CA;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_VARIANTS_EXT = 0x87CB;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_INVARIANTS_EXT = 0x87CC;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87CD;
		public const uint GL_MAX_OPTIMIZED_VERTEX_SHADER_LOCALS_EXT = 0x87CE;
		public const uint GL_VERTEX_SHADER_INSTRUCTIONS_EXT = 0x87CF;
		public const uint GL_VERTEX_SHADER_VARIANTS_EXT = 0x87D0;
		public const uint GL_VERTEX_SHADER_INVARIANTS_EXT = 0x87D1;
		public const uint GL_VERTEX_SHADER_LOCAL_CONSTANTS_EXT = 0x87D2;
		public const uint GL_VERTEX_SHADER_LOCALS_EXT = 0x87D3;
		public const uint GL_VERTEX_SHADER_OPTIMIZED_EXT = 0x87D4;
		public const uint GL_X_EXT = 0x87D5;
		public const uint GL_Y_EXT = 0x87D6;
		public const uint GL_Z_EXT = 0x87D7;
		public const uint GL_W_EXT = 0x87D8;
		public const uint GL_NEGATIVE_X_EXT = 0x87D9;
		public const uint GL_NEGATIVE_Y_EXT = 0x87DA;
		public const uint GL_NEGATIVE_Z_EXT = 0x87DB;
		public const uint GL_NEGATIVE_W_EXT = 0x87DC;
		public const uint GL_ZERO_EXT = 0x87DD;
		public const uint GL_ONE_EXT = 0x87DE;
		public const uint GL_NEGATIVE_ONE_EXT = 0x87DF;
		public const uint GL_NORMALIZED_RANGE_EXT = 0x87E0;
		public const uint GL_FULL_RANGE_EXT = 0x87E1;
		public const uint GL_CURRENT_VERTEX_EXT = 0x87E2;
		public const uint GL_MVP_MATRIX_EXT = 0x87E3;
		public const uint GL_VARIANT_VALUE_EXT = 0x87E4;
		public const uint GL_VARIANT_DATATYPE_EXT = 0x87E5;
		public const uint GL_VARIANT_ARRAY_STRIDE_EXT = 0x87E6;
		public const uint GL_VARIANT_ARRAY_TYPE_EXT = 0x87E7;
		public const uint GL_VARIANT_ARRAY_EXT = 0x87E8;
		public const uint GL_VARIANT_ARRAY_POINTER_EXT = 0x87E9;
		public const uint GL_INVARIANT_VALUE_EXT = 0x87EA;
		public const uint GL_INVARIANT_DATATYPE_EXT = 0x87EB;
		public const uint GL_LOCAL_CONSTANT_VALUE_EXT = 0x87EC;
		public const uint GL_LOCAL_CONSTANT_DATATYPE_EXT = 0x87ED;
		public const uint GL_ATI_envmap_bumpmap = 1;
		public const uint GL_BUMP_ROT_MATRIX_ATI = 0x8775;
		public const uint GL_BUMP_ROT_MATRIX_SIZE_ATI = 0x8776;
		public const uint GL_BUMP_NUM_TEX_UNITS_ATI = 0x8777;
		public const uint GL_BUMP_TEX_UNITS_ATI = 0x8778;
		public const uint GL_DUDV_ATI = 0x8779;
		public const uint GL_DU8DV8_ATI = 0x877A;
		public const uint GL_BUMP_ENVMAP_ATI = 0x877B;
		public const uint GL_BUMP_TARGET_ATI = 0x877C;
		public const uint GL_ATI_fragment_shader = 1;
		public const uint GL_FRAGMENT_SHADER_ATI = 0x8920;
		public const uint GL_REG_0_ATI = 0x8921;
		public const uint GL_REG_1_ATI = 0x8922;
		public const uint GL_REG_2_ATI = 0x8923;
		public const uint GL_REG_3_ATI = 0x8924;
		public const uint GL_REG_4_ATI = 0x8925;
		public const uint GL_REG_5_ATI = 0x8926;
		public const uint GL_REG_6_ATI = 0x8927;
		public const uint GL_REG_7_ATI = 0x8928;
		public const uint GL_REG_8_ATI = 0x8929;
		public const uint GL_REG_9_ATI = 0x892A;
		public const uint GL_REG_10_ATI = 0x892B;
		public const uint GL_REG_11_ATI = 0x892C;
		public const uint GL_REG_12_ATI = 0x892D;
		public const uint GL_REG_13_ATI = 0x892E;
		public const uint GL_REG_14_ATI = 0x892F;
		public const uint GL_REG_15_ATI = 0x8930;
		public const uint GL_REG_16_ATI = 0x8931;
		public const uint GL_REG_17_ATI = 0x8932;
		public const uint GL_REG_18_ATI = 0x8933;
		public const uint GL_REG_19_ATI = 0x8934;
		public const uint GL_REG_20_ATI = 0x8935;
		public const uint GL_REG_21_ATI = 0x8936;
		public const uint GL_REG_22_ATI = 0x8937;
		public const uint GL_REG_23_ATI = 0x8938;
		public const uint GL_REG_24_ATI = 0x8939;
		public const uint GL_REG_25_ATI = 0x893A;
		public const uint GL_REG_26_ATI = 0x893B;
		public const uint GL_REG_27_ATI = 0x893C;
		public const uint GL_REG_28_ATI = 0x893D;
		public const uint GL_REG_29_ATI = 0x893E;
		public const uint GL_REG_30_ATI = 0x893F;
		public const uint GL_REG_31_ATI = 0x8940;
		public const uint GL_CON_0_ATI = 0x8941;
		public const uint GL_CON_1_ATI = 0x8942;
		public const uint GL_CON_2_ATI = 0x8943;
		public const uint GL_CON_3_ATI = 0x8944;
		public const uint GL_CON_4_ATI = 0x8945;
		public const uint GL_CON_5_ATI = 0x8946;
		public const uint GL_CON_6_ATI = 0x8947;
		public const uint GL_CON_7_ATI = 0x8948;
		public const uint GL_CON_8_ATI = 0x8949;
		public const uint GL_CON_9_ATI = 0x894A;
		public const uint GL_CON_10_ATI = 0x894B;
		public const uint GL_CON_11_ATI = 0x894C;
		public const uint GL_CON_12_ATI = 0x894D;
		public const uint GL_CON_13_ATI = 0x894E;
		public const uint GL_CON_14_ATI = 0x894F;
		public const uint GL_CON_15_ATI = 0x8950;
		public const uint GL_CON_16_ATI = 0x8951;
		public const uint GL_CON_17_ATI = 0x8952;
		public const uint GL_CON_18_ATI = 0x8953;
		public const uint GL_CON_19_ATI = 0x8954;
		public const uint GL_CON_20_ATI = 0x8955;
		public const uint GL_CON_21_ATI = 0x8956;
		public const uint GL_CON_22_ATI = 0x8957;
		public const uint GL_CON_23_ATI = 0x8958;
		public const uint GL_CON_24_ATI = 0x8959;
		public const uint GL_CON_25_ATI = 0x895A;
		public const uint GL_CON_26_ATI = 0x895B;
		public const uint GL_CON_27_ATI = 0x895C;
		public const uint GL_CON_28_ATI = 0x895D;
		public const uint GL_CON_29_ATI = 0x895E;
		public const uint GL_CON_30_ATI = 0x895F;
		public const uint GL_CON_31_ATI = 0x8960;
		public const uint GL_MOV_ATI = 0x8961;
		public const uint GL_ADD_ATI = 0x8963;
		public const uint GL_MUL_ATI = 0x8964;
		public const uint GL_SUB_ATI = 0x8965;
		public const uint GL_DOT3_ATI = 0x8966;
		public const uint GL_DOT4_ATI = 0x8967;
		public const uint GL_MAD_ATI = 0x8968;
		public const uint GL_LERP_ATI = 0x8969;
		public const uint GL_CND_ATI = 0x896A;
		public const uint GL_CND0_ATI = 0x896B;
		public const uint GL_DOT2_ADD_ATI = 0x896C;
		public const uint GL_SECONDARY_INTERPOLATOR_ATI = 0x896D;
		public const uint GL_NUM_FRAGMENT_REGISTERS_ATI = 0x896E;
		public const uint GL_NUM_FRAGMENT_CONSTANTS_ATI = 0x896F;
		public const uint GL_NUM_PASSES_ATI = 0x8970;
		public const uint GL_NUM_INSTRUCTIONS_PER_PASS_ATI = 0x8971;
		public const uint GL_NUM_INSTRUCTIONS_TOTAL_ATI = 0x8972;
		public const uint GL_NUM_INPUT_INTERPOLATOR_COMPONENTS_ATI = 0x8973;
		public const uint GL_NUM_LOOPBACK_COMPONENTS_ATI = 0x8974;
		public const uint GL_COLOR_ALPHA_PAIRING_ATI = 0x8975;
		public const uint GL_SWIZZLE_STR_ATI = 0x8976;
		public const uint GL_SWIZZLE_STQ_ATI = 0x8977;
		public const uint GL_SWIZZLE_STR_DR_ATI = 0x8978;
		public const uint GL_SWIZZLE_STQ_DQ_ATI = 0x8979;
		public const uint GL_SWIZZLE_STRQ_ATI = 0x897A;
		public const uint GL_SWIZZLE_STRQ_DQ_ATI = 0x897B;
		public const uint GL_RED_BIT_ATI = 0x00000001;
		public const uint GL_GREEN_BIT_ATI = 0x00000002;
		public const uint GL_BLUE_BIT_ATI = 0x00000004;
		public const uint GL_2X_BIT_ATI = 0x00000001;
		public const uint GL_4X_BIT_ATI = 0x00000002;
		public const uint GL_8X_BIT_ATI = 0x00000004;
		public const uint GL_HALF_BIT_ATI = 0x00000008;
		public const uint GL_QUARTER_BIT_ATI = 0x00000010;
		public const uint GL_EIGHTH_BIT_ATI = 0x00000020;
		public const uint GL_SATURATE_BIT_ATI = 0x00000040;
		public const uint GL_COMP_BIT_ATI = 0x00000002;
		public const uint GL_NEGATE_BIT_ATI = 0x00000004;
		public const uint GL_BIAS_BIT_ATI = 0x00000008;
		public const uint GL_ATI_texture_mirror_once = 1;
		public const uint GL_MIRROR_CLAMP_ATI = 0x8742;
		public const uint GL_MIRROR_CLAMP_TO_EDGE_ATI = 0x8743;
		public const uint GL_ATI_element_array = 1;
		public const uint GL_ELEMENT_ARRAY_ATI = 0x8768;
		public const uint GL_ELEMENT_ARRAY_TYPE_ATI = 0x8769;
		public const uint GL_ELEMENT_ARRAY_POINTER_ATI = 0x876A;
		public const uint GL_ATI_vertex_streams = 1;
		public const uint GL_MAX_VERTEX_STREAMS_ATI = 0x876B;
		public const uint GL_VERTEX_SOURCE_ATI = 0x876C;
		public const uint GL_VERTEX_STREAM0_ATI = 0x876D;
		public const uint GL_VERTEX_STREAM1_ATI = 0x876E;
		public const uint GL_VERTEX_STREAM2_ATI = 0x876F;
		public const uint GL_VERTEX_STREAM3_ATI = 0x8770;
		public const uint GL_VERTEX_STREAM4_ATI = 0x8771;
		public const uint GL_VERTEX_STREAM5_ATI = 0x8772;
		public const uint GL_VERTEX_STREAM6_ATI = 0x8773;
		public const uint GL_VERTEX_STREAM7_ATI = 0x8774;
		public const uint GL_ATI_vertex_array_object = 1;
		public const uint GL_STATIC_ATI = 0x8760;
		public const uint GL_DYNAMIC_ATI = 0x8761;
		public const uint GL_PRESERVE_ATI = 0x8762;
		public const uint GL_DISCARD_ATI = 0x8763;
		public const uint GL_OBJECT_BUFFER_SIZE_ATI = 0x8764;
		public const uint GL_OBJECT_BUFFER_USAGE_ATI = 0x8765;
		public const uint GL_ARRAY_OBJECT_BUFFER_ATI = 0x8766;
		public const uint GL_ARRAY_OBJECT_OFFSET_ATI = 0x8767;
		public const uint GL_HP_occlusion_test = 1;
		public const uint GL_OCCLUSION_TEST_HP = 0x8165;

		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, IntPtr indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, byte[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, sbyte[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, short[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, ushort[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, int[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, uint[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, float[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, double[] indices)
		{
			FctInfo fi = _getf("glDrawRangeElements", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count, type, indices);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, void* pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, IntPtr pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, byte[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, sbyte[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, short[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, ushort[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, int[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, uint[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, float[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, double[] pixels)
		{
			FctInfo fi = _getf("glTexImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalFormat, width, height, depth, border, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, IntPtr pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, byte[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, sbyte[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, short[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, ushort[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, int[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, uint[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, float[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, double[] pixels)
		{
			FctInfo fi = _getf("glTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, type, pixels);
		}
		public void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height)
		{
			FctInfo fi = _getf("glCopyTexSubImage3D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, x, y, width, height);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, IntPtr table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, byte[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, sbyte[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, short[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, ushort[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, int[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, uint[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, float[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorTable(uint target, uint internalformat, int width, uint format, uint type, double[] table)
		{
			FctInfo fi = _getf("glColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, table);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, void* data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, IntPtr data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, byte[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, sbyte[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, short[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, ushort[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, int[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, uint[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, float[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorSubTable(uint target, int start, int count, uint format, uint type, double[] data)
		{
			FctInfo fi = _getf("glColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, count, format, type, data);
		}
		public void glColorTableParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glColorTableParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glColorTableParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glColorTableParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glColorTableParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glColorTableParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glCopyColorSubTable(uint target, int start, int x, int y, int width)
		{
			FctInfo fi = _getf("glCopyColorSubTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, start, x, y, width);
		}
		public void glCopyColorTable(uint target, uint internalformat, int x, int y, int width)
		{
			FctInfo fi = _getf("glCopyColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, x, y, width);
		}
		public void glGetColorTable(uint target, uint format, uint type, void* table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, IntPtr table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, byte[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, sbyte[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, short[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, ushort[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, int[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, uint[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, float[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTable(uint target, uint format, uint type, double[] table)
		{
			FctInfo fi = _getf("glGetColorTable", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, table);
		}
		public void glGetColorTableParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetColorTableParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetColorTableParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetColorTableParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetColorTableParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetColorTableParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetColorTableParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetColorTableParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glBlendEquation(uint mode)
		{
			FctInfo fi = _getf("glBlendEquation", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode);
		}
		public void glBlendColor(float red, float green, float blue, float alpha)
		{
			FctInfo fi = _getf("glBlendColor", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue, alpha);
		}
		public void glHistogram(uint target, int width, uint internalformat, byte sink)
		{
			FctInfo fi = _getf("glHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, width, internalformat, sink);
		}
		public void glResetHistogram(uint target)
		{
			FctInfo fi = _getf("glResetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, void* values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, IntPtr values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, byte[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, sbyte[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, short[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, ushort[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, int[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, uint[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, float[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogram(uint target, byte reset, uint format, uint type, double[] values)
		{
			FctInfo fi = _getf("glGetHistogram", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, type, values);
		}
		public void glGetHistogramParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetHistogramParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetHistogramParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetHistogramParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetHistogramParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetHistogramParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetHistogramParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetHistogramParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetHistogramParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetHistogramParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetHistogramParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetHistogramParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMinmax(uint target, uint internalformat, byte sink)
		{
			FctInfo fi = _getf("glMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, sink);
		}
		public void glResetMinmax(uint target)
		{
			FctInfo fi = _getf("glResetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, void* values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, IntPtr values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, byte[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, sbyte[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, short[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, ushort[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, int[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, uint[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, float[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmax(uint target, byte reset, uint format, uint types, double[] values)
		{
			FctInfo fi = _getf("glGetMinmax", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, reset, format, types, values);
		}
		public void glGetMinmaxParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMinmaxParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMinmaxParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMinmaxParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMinmaxParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMinmaxParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetMinmaxParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, IntPtr image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, byte[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, sbyte[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, short[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, ushort[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, int[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, uint[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, float[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, double[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, byte[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, sbyte[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, short[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, ushort[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, int[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, uint[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, float[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, double[] image)
		{
			FctInfo fi = _getf("glConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, image);
		}
		public void glConvolutionParameterf(uint target, uint pname, float Params)
		{
			FctInfo fi = _getf("glConvolutionParameterf", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameteri(uint target, uint pname, int Params)
		{
			FctInfo fi = _getf("glConvolutionParameteri", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glConvolutionParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width)
		{
			FctInfo fi = _getf("glCopyConvolutionFilter1D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, x, y, width);
		}
		public void glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height)
		{
			FctInfo fi = _getf("glCopyConvolutionFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, x, y, width, height);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, void* image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, IntPtr image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, byte[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, sbyte[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, short[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, ushort[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, int[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, uint[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, float[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionFilter(uint target, uint format, uint type, double[] image)
		{
			FctInfo fi = _getf("glGetConvolutionFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, image);
		}
		public void glGetConvolutionParameterfv(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetConvolutionParameterfv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetConvolutionParameterfv(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameterfv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetConvolutionParameteriv(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetConvolutionParameteriv(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetConvolutionParameteriv(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetConvolutionParameteriv", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, IntPtr row, IntPtr column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, byte[] row, byte[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, sbyte[] row, sbyte[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, short[] row, short[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, ushort[] row, ushort[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, int[] row, int[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, uint[] row, uint[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, float[] row, float[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, double[] row, double[] column)
		{
			FctInfo fi = _getf("glSeparableFilter2D", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, internalformat, width, height, format, type, row, column);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, IntPtr row, IntPtr column, IntPtr span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, byte[] row, byte[] column, byte[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, sbyte[] row, sbyte[] column, sbyte[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, short[] row, short[] column, short[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, ushort[] row, ushort[] column, ushort[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, int[] row, int[] column, int[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, uint[] row, uint[] column, uint[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, float[] row, float[] column, float[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glGetSeparableFilter(uint target, uint format, uint type, double[] row, double[] column, double[] span)
		{
			FctInfo fi = _getf("glGetSeparableFilter", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, format, type, row, column, span);
		}
		public void glActiveTextureARB(uint texture)
		{
			FctInfo fi = _getf("glActiveTextureARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(texture);
		}
		public void glClientActiveTextureARB(uint texture)
		{
			FctInfo fi = _getf("glClientActiveTextureARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(texture);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage1DARB(uint target, int level, uint internalformat, int width, int border, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage2DARB(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexImage3DARB(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, internalformat, width, height, depth, border, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage1DARB(uint target, int level, int xoffset, int width, uint format, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage1DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, width, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage2DARB(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage2DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, width, height, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, IntPtr data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, byte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, sbyte[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, short[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, ushort[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, int[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, uint[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, float[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glCompressedTexSubImage3DARB(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, double[] data)
		{
			FctInfo fi = _getf("glCompressedTexSubImage3DARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, level, xoffset, yoffset, zoffset, width, height, depth, format, imageSize, data);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, void* img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, IntPtr img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, byte[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, sbyte[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, short[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, ushort[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, int[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, uint[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, float[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glGetCompressedTexImageARB(uint target, int lod, double[] img)
		{
			FctInfo fi = _getf("glGetCompressedTexImageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, lod, img);
		}
		public void glMultiTexCoord1dARB(uint target, double s)
		{
			FctInfo fi = _getf("glMultiTexCoord1dARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s);
		}
		public void glMultiTexCoord1dvARB(uint target, double* v)
		{
			FctInfo fi = _getf("glMultiTexCoord1dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1dvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord1dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1dvARB(uint target, double[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord1dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1fARB(uint target, float s)
		{
			FctInfo fi = _getf("glMultiTexCoord1fARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s);
		}
		public void glMultiTexCoord1fvARB(uint target, float* v)
		{
			FctInfo fi = _getf("glMultiTexCoord1fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1fvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord1fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1fvARB(uint target, float[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord1fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1iARB(uint target, int s)
		{
			FctInfo fi = _getf("glMultiTexCoord1iARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s);
		}
		public void glMultiTexCoord1ivARB(uint target, int* v)
		{
			FctInfo fi = _getf("glMultiTexCoord1ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1ivARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord1ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1ivARB(uint target, int[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord1ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1sARB(uint target, short s)
		{
			FctInfo fi = _getf("glMultiTexCoord1sARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s);
		}
		public void glMultiTexCoord1svARB(uint target, short* v)
		{
			FctInfo fi = _getf("glMultiTexCoord1svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1svARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord1svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord1svARB(uint target, short[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord1svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2dARB(uint target, double s, double t)
		{
			FctInfo fi = _getf("glMultiTexCoord2dARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t);
		}
		public void glMultiTexCoord2dvARB(uint target, double* v)
		{
			FctInfo fi = _getf("glMultiTexCoord2dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2dvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord2dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2dvARB(uint target, double[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord2dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2fARB(uint target, float s, float t)
		{
			FctInfo fi = _getf("glMultiTexCoord2fARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t);
		}
		public void glMultiTexCoord2fvARB(uint target, float* v)
		{
			FctInfo fi = _getf("glMultiTexCoord2fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2fvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord2fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2fvARB(uint target, float[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord2fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2iARB(uint target, int s, int t)
		{
			FctInfo fi = _getf("glMultiTexCoord2iARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t);
		}
		public void glMultiTexCoord2ivARB(uint target, int* v)
		{
			FctInfo fi = _getf("glMultiTexCoord2ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2ivARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord2ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2ivARB(uint target, int[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord2ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2sARB(uint target, short s, short t)
		{
			FctInfo fi = _getf("glMultiTexCoord2sARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t);
		}
		public void glMultiTexCoord2svARB(uint target, short* v)
		{
			FctInfo fi = _getf("glMultiTexCoord2svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2svARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord2svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord2svARB(uint target, short[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord2svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3dARB(uint target, double s, double t, double r)
		{
			FctInfo fi = _getf("glMultiTexCoord3dARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r);
		}
		public void glMultiTexCoord3dvARB(uint target, double* v)
		{
			FctInfo fi = _getf("glMultiTexCoord3dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3dvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord3dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3dvARB(uint target, double[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord3dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3fARB(uint target, float s, float t, float r)
		{
			FctInfo fi = _getf("glMultiTexCoord3fARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r);
		}
		public void glMultiTexCoord3fvARB(uint target, float* v)
		{
			FctInfo fi = _getf("glMultiTexCoord3fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3fvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord3fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3fvARB(uint target, float[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord3fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3iARB(uint target, int s, int t, int r)
		{
			FctInfo fi = _getf("glMultiTexCoord3iARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r);
		}
		public void glMultiTexCoord3ivARB(uint target, int* v)
		{
			FctInfo fi = _getf("glMultiTexCoord3ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3ivARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord3ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3ivARB(uint target, int[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord3ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3sARB(uint target, short s, short t, short r)
		{
			FctInfo fi = _getf("glMultiTexCoord3sARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r);
		}
		public void glMultiTexCoord3svARB(uint target, short* v)
		{
			FctInfo fi = _getf("glMultiTexCoord3svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3svARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord3svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord3svARB(uint target, short[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord3svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q)
		{
			FctInfo fi = _getf("glMultiTexCoord4dARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r, q);
		}
		public void glMultiTexCoord4dvARB(uint target, double* v)
		{
			FctInfo fi = _getf("glMultiTexCoord4dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4dvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord4dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4dvARB(uint target, double[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord4dvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q)
		{
			FctInfo fi = _getf("glMultiTexCoord4fARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r, q);
		}
		public void glMultiTexCoord4fvARB(uint target, float* v)
		{
			FctInfo fi = _getf("glMultiTexCoord4fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4fvARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord4fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4fvARB(uint target, float[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord4fvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q)
		{
			FctInfo fi = _getf("glMultiTexCoord4iARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r, q);
		}
		public void glMultiTexCoord4ivARB(uint target, int* v)
		{
			FctInfo fi = _getf("glMultiTexCoord4ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4ivARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord4ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4ivARB(uint target, int[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord4ivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q)
		{
			FctInfo fi = _getf("glMultiTexCoord4sARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, s, t, r, q);
		}
		public void glMultiTexCoord4svARB(uint target, short* v)
		{
			FctInfo fi = _getf("glMultiTexCoord4svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4svARB(uint target, IntPtr v)
		{
			FctInfo fi = _getf("glMultiTexCoord4svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glMultiTexCoord4svARB(uint target, short[] v)
		{
			FctInfo fi = _getf("glMultiTexCoord4svARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, v);
		}
		public void glLoadTransposeMatrixdARB(double* m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glLoadTransposeMatrixdARB(IntPtr m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glLoadTransposeMatrixdARB(double[] m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glLoadTransposeMatrixfARB(float* m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glLoadTransposeMatrixfARB(IntPtr m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glLoadTransposeMatrixfARB(float[] m)
		{
			FctInfo fi = _getf("glLoadTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixdARB(double* m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixdARB(IntPtr m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixdARB(double[] m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixdARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixfARB(float* m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixfARB(IntPtr m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glMultTransposeMatrixfARB(float[] m)
		{
			FctInfo fi = _getf("glMultTransposeMatrixfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(m);
		}
		public void glSampleCoverageARB(float value, byte invert)
		{
			FctInfo fi = _getf("glSampleCoverageARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(value, invert);
		}
		public void glLockArraysEXT(int first, int count)
		{
			FctInfo fi = _getf("glLockArraysEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(first, count);
		}
		public void glUnlockArraysEXT()
		{
			FctInfo fi = _getf("glUnlockArraysEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glSecondaryColor3bEXT(byte red, byte green, byte blue)
		{
			FctInfo fi = _getf("glSecondaryColor3bEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(1, 1, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3bvEXT(byte* v)
		{
			FctInfo fi = _getf("glSecondaryColor3bvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3bvEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3bvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3bvEXT(byte[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3bvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3dEXT(double red, double green, double blue)
		{
			FctInfo fi = _getf("glSecondaryColor3dEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3dvEXT(double* v)
		{
			FctInfo fi = _getf("glSecondaryColor3dvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3dvEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3dvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3dvEXT(double[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3dvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3fEXT(float red, float green, float blue)
		{
			FctInfo fi = _getf("glSecondaryColor3fEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3fvEXT(float* v)
		{
			FctInfo fi = _getf("glSecondaryColor3fvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3fvEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3fvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3fvEXT(float[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3fvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3iEXT(int red, int green, int blue)
		{
			FctInfo fi = _getf("glSecondaryColor3iEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3ivEXT(int* v)
		{
			FctInfo fi = _getf("glSecondaryColor3ivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3ivEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3ivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3ivEXT(int[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3ivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3sEXT(short red, short green, short blue)
		{
			FctInfo fi = _getf("glSecondaryColor3sEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3svEXT(short* v)
		{
			FctInfo fi = _getf("glSecondaryColor3svEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3svEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3svEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3svEXT(short[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3svEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3ubEXT(byte red, byte green, byte blue)
		{
			FctInfo fi = _getf("glSecondaryColor3ubEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(1, 1, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3ubvEXT(byte* v)
		{
			FctInfo fi = _getf("glSecondaryColor3ubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3ubvEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3ubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3ubvEXT(byte[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3ubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3uiEXT(uint red, uint green, uint blue)
		{
			FctInfo fi = _getf("glSecondaryColor3uiEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3uivEXT(uint* v)
		{
			FctInfo fi = _getf("glSecondaryColor3uivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3uivEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3uivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3uivEXT(uint[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3uivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3usEXT(ushort red, ushort green, ushort blue)
		{
			FctInfo fi = _getf("glSecondaryColor3usEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(red, green, blue);
		}
		public void glSecondaryColor3usvEXT(ushort* v)
		{
			FctInfo fi = _getf("glSecondaryColor3usvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3usvEXT(IntPtr v)
		{
			FctInfo fi = _getf("glSecondaryColor3usvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColor3usvEXT(ushort[] v)
		{
			FctInfo fi = _getf("glSecondaryColor3usvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(v);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glSecondaryColorPointerEXT(int size, uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glSecondaryColorPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glFogCoordfEXT(float coord)
		{
			FctInfo fi = _getf("glFogCoordfEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoordfvEXT(float* coord)
		{
			FctInfo fi = _getf("glFogCoordfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoordfvEXT(IntPtr coord)
		{
			FctInfo fi = _getf("glFogCoordfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoordfvEXT(float[] coord)
		{
			FctInfo fi = _getf("glFogCoordfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoorddEXT(double coord)
		{
			FctInfo fi = _getf("glFogCoorddEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoorddvEXT(double* coord)
		{
			FctInfo fi = _getf("glFogCoorddvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoorddvEXT(IntPtr coord)
		{
			FctInfo fi = _getf("glFogCoorddvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoorddvEXT(double[] coord)
		{
			FctInfo fi = _getf("glFogCoorddvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(coord);
		}
		public void glFogCoordPointerEXT(uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFogCoordPointerEXT(uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glFogCoordPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, stride, pointer);
		}
		public void glFlushVertexArrayRangeNV()
		{
			FctInfo fi = _getf("glFlushVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glVertexArrayRangeNV(int size, void* pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, IntPtr pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, byte[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, sbyte[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, short[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, ushort[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, int[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, uint[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, float[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public void glVertexArrayRangeNV(int size, double[] pointer)
		{
			FctInfo fi = _getf("glVertexArrayRangeNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, pointer);
		}
		public IntPtr wglAllocateMemoryNV(int size, float readFrequency, float writeFrequency, float priority)
		{
			FctInfo fi = _getf("wglAllocateMemoryNV", false);
			if(fi == null)
				return (IntPtr) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.IntPtrCall(size, readFrequency, writeFrequency, priority);
		}
		public void wglFreeMemoryNV(void* pointer)
		{
			FctInfo fi = _getf("wglFreeMemoryNV", false);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pointer);
		}
		public void wglFreeMemoryNV(IntPtr pointer)
		{
			FctInfo fi = _getf("wglFreeMemoryNV", false);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pointer);
		}
		public void glPointParameterfEXT(uint pname, float param)
		{
			FctInfo fi = _getf("glPointParameterfEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glPointParameterfvEXT(uint pname, float* Params)
		{
			FctInfo fi = _getf("glPointParameterfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glPointParameterfvEXT(uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glPointParameterfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glPointParameterfvEXT(uint pname, float[] Params)
		{
			FctInfo fi = _getf("glPointParameterfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterfvNV(uint pname, float* Params)
		{
			FctInfo fi = _getf("glCombinerParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterfvNV(uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glCombinerParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterfvNV(uint pname, float[] Params)
		{
			FctInfo fi = _getf("glCombinerParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterfNV(uint pname, float param)
		{
			FctInfo fi = _getf("glCombinerParameterfNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glCombinerParameterivNV(uint pname, int* Params)
		{
			FctInfo fi = _getf("glCombinerParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterivNV(uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glCombinerParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameterivNV(uint pname, int[] Params)
		{
			FctInfo fi = _getf("glCombinerParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glCombinerParameteriNV(uint pname, int param)
		{
			FctInfo fi = _getf("glCombinerParameteriNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glCombinerInputNV(uint stage, uint portion, uint variable, uint input, uint mapping, uint componentUsage)
		{
			FctInfo fi = _getf("glCombinerInputNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, input, mapping, componentUsage);
		}
		public void glCombinerOutputNV(uint stage, uint portion, uint abOutput, uint cdOutput, uint sumOutput, uint scale, uint bias, byte abDotProduct, byte cdDotProduct, byte muxSum)
		{
			FctInfo fi = _getf("glCombinerOutputNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, 1, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, abOutput, cdOutput, sumOutput, scale, bias, abDotProduct, cdDotProduct, muxSum);
		}
		public void glFinalCombinerInputNV(uint variable, uint input, uint mapping, uint componentUsage)
		{
			FctInfo fi = _getf("glFinalCombinerInputNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, input, mapping, componentUsage);
		}
		public void glGetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerInputParameterfvNV(uint stage, uint portion, uint variable, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerInputParameterivNV(uint stage, uint portion, uint variable, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, variable, pname, Params);
		}
		public void glGetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetCombinerOutputParameterfvNV(uint stage, uint portion, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetCombinerOutputParameterivNV(uint stage, uint portion, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetCombinerOutputParameterivNV(uint stage, uint portion, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetCombinerOutputParameterivNV(uint stage, uint portion, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetCombinerOutputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, portion, pname, Params);
		}
		public void glGetFinalCombinerInputParameterfvNV(uint variable, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glGetFinalCombinerInputParameterfvNV(uint variable, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glGetFinalCombinerInputParameterfvNV(uint variable, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glGetFinalCombinerInputParameterivNV(uint variable, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glGetFinalCombinerInputParameterivNV(uint variable, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glGetFinalCombinerInputParameterivNV(uint variable, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetFinalCombinerInputParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(variable, pname, Params);
		}
		public void glVertexWeightfEXT(float weight)
		{
			FctInfo fi = _getf("glVertexWeightfEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(weight);
		}
		public void glVertexWeightfvEXT(float* weight)
		{
			FctInfo fi = _getf("glVertexWeightfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(weight);
		}
		public void glVertexWeightfvEXT(IntPtr weight)
		{
			FctInfo fi = _getf("glVertexWeightfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(weight);
		}
		public void glVertexWeightfvEXT(float[] weight)
		{
			FctInfo fi = _getf("glVertexWeightfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(weight);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexWeightPointerEXT(int size, uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glVertexWeightPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glBindProgramNV(uint target, uint id)
		{
			FctInfo fi = _getf("glBindProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id);
		}
		public void glDeleteProgramsNV(int n, uint* ids)
		{
			FctInfo fi = _getf("glDeleteProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glDeleteProgramsNV(int n, IntPtr ids)
		{
			FctInfo fi = _getf("glDeleteProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glDeleteProgramsNV(int n, uint[] ids)
		{
			FctInfo fi = _getf("glDeleteProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glExecuteProgramNV(uint target, uint id, float* Params)
		{
			FctInfo fi = _getf("glExecuteProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, Params);
		}
		public void glExecuteProgramNV(uint target, uint id, IntPtr Params)
		{
			FctInfo fi = _getf("glExecuteProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, Params);
		}
		public void glExecuteProgramNV(uint target, uint id, float[] Params)
		{
			FctInfo fi = _getf("glExecuteProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, Params);
		}
		public void glGenProgramsNV(int n, uint* ids)
		{
			FctInfo fi = _getf("glGenProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glGenProgramsNV(int n, IntPtr ids)
		{
			FctInfo fi = _getf("glGenProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glGenProgramsNV(int n, uint[] ids)
		{
			FctInfo fi = _getf("glGenProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public byte glAreProgramsResidentNV(int n, uint* ids, byte* residences)
		{
			FctInfo fi = _getf("glAreProgramsResidentNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(n, ids, residences);
		}
		public byte glAreProgramsResidentNV(int n, IntPtr ids, IntPtr residences)
		{
			FctInfo fi = _getf("glAreProgramsResidentNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(n, ids, residences);
		}
		public byte glAreProgramsResidentNV(int n, uint[] ids, byte[] residences)
		{
			FctInfo fi = _getf("glAreProgramsResidentNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(n, ids, residences);
		}
		public void glRequestResidentProgramsNV(int n, uint* ids)
		{
			FctInfo fi = _getf("glRequestResidentProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glRequestResidentProgramsNV(int n, IntPtr ids)
		{
			FctInfo fi = _getf("glRequestResidentProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glRequestResidentProgramsNV(int n, uint[] ids)
		{
			FctInfo fi = _getf("glRequestResidentProgramsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, ids);
		}
		public void glGetProgramParameterfvNV(uint target, uint index, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetProgramParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramParameterfvNV(uint target, uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetProgramParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramParameterfvNV(uint target, uint index, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetProgramParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramParameterdvNV(uint target, uint index, uint pname, double* Params)
		{
			FctInfo fi = _getf("glGetProgramParameterdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramParameterdvNV(uint target, uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetProgramParameterdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramParameterdvNV(uint target, uint index, uint pname, double[] Params)
		{
			FctInfo fi = _getf("glGetProgramParameterdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetProgramivNV(uint id, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetProgramivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetProgramivNV(uint id, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetProgramivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetProgramivNV(uint id, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetProgramivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetProgramStringNV(uint id, uint pname, byte* program)
		{
			FctInfo fi = _getf("glGetProgramStringNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, program);
		}
		public void glGetProgramStringNV(uint id, uint pname, IntPtr program)
		{
			FctInfo fi = _getf("glGetProgramStringNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, program);
		}
		public void glGetProgramStringNV(uint id, uint pname, byte[] program)
		{
			FctInfo fi = _getf("glGetProgramStringNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, program);
		}
		public void glGetTrackMatrixivNV(uint target, uint address, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetTrackMatrixivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, address, pname, Params);
		}
		public void glGetTrackMatrixivNV(uint target, uint address, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetTrackMatrixivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, address, pname, Params);
		}
		public void glGetTrackMatrixivNV(uint target, uint address, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetTrackMatrixivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, address, pname, Params);
		}
		public void glGetVertexAttribdvNV(uint index, uint pname, double* Params)
		{
			FctInfo fi = _getf("glGetVertexAttribdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribdvNV(uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetVertexAttribdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribdvNV(uint index, uint pname, double[] Params)
		{
			FctInfo fi = _getf("glGetVertexAttribdvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribfvNV(uint index, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetVertexAttribfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribfvNV(uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetVertexAttribfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribfvNV(uint index, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetVertexAttribfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribivNV(uint index, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetVertexAttribivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribivNV(uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetVertexAttribivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribivNV(uint index, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetVertexAttribivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, Params);
		}
		public void glGetVertexAttribPointervNV(uint index, uint pname, void** pointer)
		{
			FctInfo fi = _getf("glGetVertexAttribPointervNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, pointer);
		}
		public void glGetVertexAttribPointervNV(uint index, uint pname, IntPtr pointer)
		{
			FctInfo fi = _getf("glGetVertexAttribPointervNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, pname, pointer);
		}
		public byte glIsProgramNV(uint id)
		{
			FctInfo fi = _getf("glIsProgramNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(id);
		}
		public void glLoadProgramNV(uint target, uint id, int len, byte* program)
		{
			FctInfo fi = _getf("glLoadProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, len, program);
		}
		public void glLoadProgramNV(uint target, uint id, int len, IntPtr program)
		{
			FctInfo fi = _getf("glLoadProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, len, program);
		}
		public void glLoadProgramNV(uint target, uint id, int len, byte[] program)
		{
			FctInfo fi = _getf("glLoadProgramNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, id, len, program);
		}
		public void glProgramParameter4fNV(uint target, uint index, float x, float y, float z, float w)
		{
			FctInfo fi = _getf("glProgramParameter4fNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, x, y, z, w);
		}
		public void glProgramParameter4dNV(uint target, uint index, double x, double y, double z, double w)
		{
			FctInfo fi = _getf("glProgramParameter4dNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 8, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, x, y, z, w);
		}
		public void glProgramParameter4dvNV(uint target, uint index, double* Params)
		{
			FctInfo fi = _getf("glProgramParameter4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameter4dvNV(uint target, uint index, IntPtr Params)
		{
			FctInfo fi = _getf("glProgramParameter4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameter4dvNV(uint target, uint index, double[] Params)
		{
			FctInfo fi = _getf("glProgramParameter4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameter4fvNV(uint target, uint index, float* Params)
		{
			FctInfo fi = _getf("glProgramParameter4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameter4fvNV(uint target, uint index, IntPtr Params)
		{
			FctInfo fi = _getf("glProgramParameter4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameter4fvNV(uint target, uint index, float[] Params)
		{
			FctInfo fi = _getf("glProgramParameter4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, Params);
		}
		public void glProgramParameters4dvNV(uint target, uint index, uint num, double* Params)
		{
			FctInfo fi = _getf("glProgramParameters4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glProgramParameters4dvNV(uint target, uint index, uint num, IntPtr Params)
		{
			FctInfo fi = _getf("glProgramParameters4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glProgramParameters4dvNV(uint target, uint index, uint num, double[] Params)
		{
			FctInfo fi = _getf("glProgramParameters4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glProgramParameters4fvNV(uint target, uint index, uint num, float* Params)
		{
			FctInfo fi = _getf("glProgramParameters4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glProgramParameters4fvNV(uint target, uint index, uint num, IntPtr Params)
		{
			FctInfo fi = _getf("glProgramParameters4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glProgramParameters4fvNV(uint target, uint index, uint num, float[] Params)
		{
			FctInfo fi = _getf("glProgramParameters4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, num, Params);
		}
		public void glTrackMatrixNV(uint target, uint address, uint matrix, uint transform)
		{
			FctInfo fi = _getf("glTrackMatrixNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, address, matrix, transform);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttribPointerNV(uint index, int size, uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glVertexAttribPointerNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, size, type, stride, pointer);
		}
		public void glVertexAttrib1sNV(uint index, short x)
		{
			FctInfo fi = _getf("glVertexAttrib1sNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x);
		}
		public void glVertexAttrib1fNV(uint index, float x)
		{
			FctInfo fi = _getf("glVertexAttrib1fNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x);
		}
		public void glVertexAttrib1dNV(uint index, double x)
		{
			FctInfo fi = _getf("glVertexAttrib1dNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x);
		}
		public void glVertexAttrib2sNV(uint index, short x, short y)
		{
			FctInfo fi = _getf("glVertexAttrib2sNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y);
		}
		public void glVertexAttrib2fNV(uint index, float x, float y)
		{
			FctInfo fi = _getf("glVertexAttrib2fNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y);
		}
		public void glVertexAttrib2dNV(uint index, double x, double y)
		{
			FctInfo fi = _getf("glVertexAttrib2dNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y);
		}
		public void glVertexAttrib3sNV(uint index, short x, short y, short z)
		{
			FctInfo fi = _getf("glVertexAttrib3sNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z);
		}
		public void glVertexAttrib3fNV(uint index, float x, float y, float z)
		{
			FctInfo fi = _getf("glVertexAttrib3fNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z);
		}
		public void glVertexAttrib3dNV(uint index, double x, double y, double z)
		{
			FctInfo fi = _getf("glVertexAttrib3dNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z);
		}
		public void glVertexAttrib4sNV(uint index, short x, short y, short z, short w)
		{
			FctInfo fi = _getf("glVertexAttrib4sNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z, w);
		}
		public void glVertexAttrib4fNV(uint index, float x, float y, float z, float w)
		{
			FctInfo fi = _getf("glVertexAttrib4fNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z, w);
		}
		public void glVertexAttrib4dNV(uint index, double x, double y, double z, double w)
		{
			FctInfo fi = _getf("glVertexAttrib4dNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z, w);
		}
		public void glVertexAttrib4ubNV(uint index, byte x, byte y, byte z, byte w)
		{
			FctInfo fi = _getf("glVertexAttrib4ubNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 1, 1, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, x, y, z, w);
		}
		public void glVertexAttrib1svNV(uint index, short* v)
		{
			FctInfo fi = _getf("glVertexAttrib1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1svNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1svNV(uint index, short[] v)
		{
			FctInfo fi = _getf("glVertexAttrib1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1fvNV(uint index, float* v)
		{
			FctInfo fi = _getf("glVertexAttrib1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1fvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1fvNV(uint index, float[] v)
		{
			FctInfo fi = _getf("glVertexAttrib1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1dvNV(uint index, double* v)
		{
			FctInfo fi = _getf("glVertexAttrib1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1dvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib1dvNV(uint index, double[] v)
		{
			FctInfo fi = _getf("glVertexAttrib1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2svNV(uint index, short* v)
		{
			FctInfo fi = _getf("glVertexAttrib2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2svNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2svNV(uint index, short[] v)
		{
			FctInfo fi = _getf("glVertexAttrib2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2fvNV(uint index, float* v)
		{
			FctInfo fi = _getf("glVertexAttrib2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2fvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2fvNV(uint index, float[] v)
		{
			FctInfo fi = _getf("glVertexAttrib2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2dvNV(uint index, double* v)
		{
			FctInfo fi = _getf("glVertexAttrib2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2dvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib2dvNV(uint index, double[] v)
		{
			FctInfo fi = _getf("glVertexAttrib2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3svNV(uint index, short* v)
		{
			FctInfo fi = _getf("glVertexAttrib3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3svNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3svNV(uint index, short[] v)
		{
			FctInfo fi = _getf("glVertexAttrib3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3fvNV(uint index, float* v)
		{
			FctInfo fi = _getf("glVertexAttrib3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3fvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3fvNV(uint index, float[] v)
		{
			FctInfo fi = _getf("glVertexAttrib3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3dvNV(uint index, double* v)
		{
			FctInfo fi = _getf("glVertexAttrib3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3dvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib3dvNV(uint index, double[] v)
		{
			FctInfo fi = _getf("glVertexAttrib3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4svNV(uint index, short* v)
		{
			FctInfo fi = _getf("glVertexAttrib4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4svNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4svNV(uint index, short[] v)
		{
			FctInfo fi = _getf("glVertexAttrib4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4fvNV(uint index, float* v)
		{
			FctInfo fi = _getf("glVertexAttrib4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4fvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4fvNV(uint index, float[] v)
		{
			FctInfo fi = _getf("glVertexAttrib4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4dvNV(uint index, double* v)
		{
			FctInfo fi = _getf("glVertexAttrib4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4dvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4dvNV(uint index, double[] v)
		{
			FctInfo fi = _getf("glVertexAttrib4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4ubvNV(uint index, byte* v)
		{
			FctInfo fi = _getf("glVertexAttrib4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4ubvNV(uint index, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttrib4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttrib4ubvNV(uint index, byte[] v)
		{
			FctInfo fi = _getf("glVertexAttrib4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, v);
		}
		public void glVertexAttribs1svNV(uint index, int n, short* v)
		{
			FctInfo fi = _getf("glVertexAttribs1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1svNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1svNV(uint index, int n, short[] v)
		{
			FctInfo fi = _getf("glVertexAttribs1svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1fvNV(uint index, int n, float* v)
		{
			FctInfo fi = _getf("glVertexAttribs1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1fvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1fvNV(uint index, int n, float[] v)
		{
			FctInfo fi = _getf("glVertexAttribs1fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1dvNV(uint index, int n, double* v)
		{
			FctInfo fi = _getf("glVertexAttribs1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1dvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs1dvNV(uint index, int n, double[] v)
		{
			FctInfo fi = _getf("glVertexAttribs1dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2svNV(uint index, int n, short* v)
		{
			FctInfo fi = _getf("glVertexAttribs2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2svNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2svNV(uint index, int n, short[] v)
		{
			FctInfo fi = _getf("glVertexAttribs2svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2fvNV(uint index, int n, float* v)
		{
			FctInfo fi = _getf("glVertexAttribs2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2fvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2fvNV(uint index, int n, float[] v)
		{
			FctInfo fi = _getf("glVertexAttribs2fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2dvNV(uint index, int n, double* v)
		{
			FctInfo fi = _getf("glVertexAttribs2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2dvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs2dvNV(uint index, int n, double[] v)
		{
			FctInfo fi = _getf("glVertexAttribs2dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3svNV(uint index, int n, short* v)
		{
			FctInfo fi = _getf("glVertexAttribs3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3svNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3svNV(uint index, int n, short[] v)
		{
			FctInfo fi = _getf("glVertexAttribs3svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3fvNV(uint index, int n, float* v)
		{
			FctInfo fi = _getf("glVertexAttribs3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3fvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3fvNV(uint index, int n, float[] v)
		{
			FctInfo fi = _getf("glVertexAttribs3fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3dvNV(uint index, int n, double* v)
		{
			FctInfo fi = _getf("glVertexAttribs3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3dvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs3dvNV(uint index, int n, double[] v)
		{
			FctInfo fi = _getf("glVertexAttribs3dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4svNV(uint index, int n, short* v)
		{
			FctInfo fi = _getf("glVertexAttribs4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4svNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4svNV(uint index, int n, short[] v)
		{
			FctInfo fi = _getf("glVertexAttribs4svNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4fvNV(uint index, int n, float* v)
		{
			FctInfo fi = _getf("glVertexAttribs4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4fvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4fvNV(uint index, int n, float[] v)
		{
			FctInfo fi = _getf("glVertexAttribs4fvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4dvNV(uint index, int n, double* v)
		{
			FctInfo fi = _getf("glVertexAttribs4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4dvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4dvNV(uint index, int n, double[] v)
		{
			FctInfo fi = _getf("glVertexAttribs4dvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4ubvNV(uint index, int n, byte* v)
		{
			FctInfo fi = _getf("glVertexAttribs4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4ubvNV(uint index, int n, IntPtr v)
		{
			FctInfo fi = _getf("glVertexAttribs4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glVertexAttribs4ubvNV(uint index, int n, byte[] v)
		{
			FctInfo fi = _getf("glVertexAttribs4ubvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index, n, v);
		}
		public void glGenFencesNV(int n, uint* fences)
		{
			FctInfo fi = _getf("glGenFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glGenFencesNV(int n, IntPtr fences)
		{
			FctInfo fi = _getf("glGenFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glGenFencesNV(int n, uint[] fences)
		{
			FctInfo fi = _getf("glGenFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glDeleteFencesNV(int n, uint* fences)
		{
			FctInfo fi = _getf("glDeleteFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glDeleteFencesNV(int n, IntPtr fences)
		{
			FctInfo fi = _getf("glDeleteFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glDeleteFencesNV(int n, uint[] fences)
		{
			FctInfo fi = _getf("glDeleteFencesNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(n, fences);
		}
		public void glSetFenceNV(uint fence, uint condition)
		{
			FctInfo fi = _getf("glSetFenceNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(fence, condition);
		}
		public byte glTestFenceNV(uint fence)
		{
			FctInfo fi = _getf("glTestFenceNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(fence);
		}
		public void glFinishFenceNV(uint fence)
		{
			FctInfo fi = _getf("glFinishFenceNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(fence);
		}
		public byte glIsFenceNV(uint fence)
		{
			FctInfo fi = _getf("glIsFenceNV", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(fence);
		}
		public void glGetFenceivNV(uint fence, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetFenceivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(fence, pname, Params);
		}
		public void glGetFenceivNV(uint fence, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetFenceivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(fence, pname, Params);
		}
		public void glGetFenceivNV(uint fence, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetFenceivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(fence, pname, Params);
		}
		public void glCombinerStageParameterfvNV(uint stage, uint pname, float* Params)
		{
			FctInfo fi = _getf("glCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glCombinerStageParameterfvNV(uint stage, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glCombinerStageParameterfvNV(uint stage, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glGetCombinerStageParameterfvNV(uint stage, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glGetCombinerStageParameterfvNV(uint stage, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glGetCombinerStageParameterfvNV(uint stage, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetCombinerStageParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stage, pname, Params);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, void* points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, IntPtr points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, byte[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, sbyte[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, short[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, ushort[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, int[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, uint[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, float[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, int uorder, int vorder, byte packed, double[] points)
		{
			FctInfo fi = _getf("glMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, uorder, vorder, packed, points);
		}
		public void glMapParameterivNV(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMapParameterivNV(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMapParameterivNV(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMapParameterfvNV(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMapParameterfvNV(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glMapParameterfvNV(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, void* points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, IntPtr points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, byte[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, sbyte[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, short[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, ushort[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, int[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, uint[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, float[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapControlPointsNV(uint target, uint index, uint type, int ustride, int vstride, byte packed, double[] points)
		{
			FctInfo fi = _getf("glGetMapControlPointsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 1, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, type, ustride, vstride, packed, points);
		}
		public void glGetMapParameterivNV(uint target, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapParameterivNV(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapParameterivNV(uint target, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetMapParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapParameterfvNV(uint target, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapParameterfvNV(uint target, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapParameterfvNV(uint target, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetMapParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, pname, Params);
		}
		public void glGetMapAttribParameterivNV(uint target, uint index, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetMapAttribParameterivNV(uint target, uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetMapAttribParameterivNV(uint target, uint index, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterivNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetMapAttribParameterfvNV(uint target, uint index, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetMapAttribParameterfvNV(uint target, uint index, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glGetMapAttribParameterfvNV(uint target, uint index, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetMapAttribParameterfvNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, index, pname, Params);
		}
		public void glEvalMapsNV(uint target, uint mode)
		{
			FctInfo fi = _getf("glEvalMapsNV", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(target, mode);
		}
		public void glPNTrianglesiATI(uint pname, int param)
		{
			FctInfo fi = _getf("glPNTrianglesiATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glPNTrianglesfATI(uint pname, float param)
		{
			FctInfo fi = _getf("glPNTrianglesfATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glPointParameterfARB(uint pname, float param)
		{
			FctInfo fi = _getf("glPointParameterfARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glPointParameterfvARB(uint pname, float* Params)
		{
			FctInfo fi = _getf("glPointParameterfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glPointParameterfvARB(uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glPointParameterfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glPointParameterfvARB(uint pname, float[] Params)
		{
			FctInfo fi = _getf("glPointParameterfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, Params);
		}
		public void glWeightbvARB(int size, byte* weights)
		{
			FctInfo fi = _getf("glWeightbvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightbvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightbvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightbvARB(int size, byte[] weights)
		{
			FctInfo fi = _getf("glWeightbvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightsvARB(int size, short* weights)
		{
			FctInfo fi = _getf("glWeightsvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightsvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightsvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightsvARB(int size, short[] weights)
		{
			FctInfo fi = _getf("glWeightsvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightivARB(int size, int* weights)
		{
			FctInfo fi = _getf("glWeightivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightivARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightivARB(int size, int[] weights)
		{
			FctInfo fi = _getf("glWeightivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightfvARB(int size, float* weights)
		{
			FctInfo fi = _getf("glWeightfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightfvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightfvARB(int size, float[] weights)
		{
			FctInfo fi = _getf("glWeightfvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightdvARB(int size, double* weights)
		{
			FctInfo fi = _getf("glWeightdvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightdvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightdvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightdvARB(int size, double[] weights)
		{
			FctInfo fi = _getf("glWeightdvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightubvARB(int size, byte* weights)
		{
			FctInfo fi = _getf("glWeightubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightubvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightubvARB(int size, byte[] weights)
		{
			FctInfo fi = _getf("glWeightubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightusvARB(int size, ushort* weights)
		{
			FctInfo fi = _getf("glWeightusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightusvARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightusvARB(int size, ushort[] weights)
		{
			FctInfo fi = _getf("glWeightusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightuivARB(int size, uint* weights)
		{
			FctInfo fi = _getf("glWeightuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightuivARB(int size, IntPtr weights)
		{
			FctInfo fi = _getf("glWeightuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightuivARB(int size, uint[] weights)
		{
			FctInfo fi = _getf("glWeightuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, weights);
		}
		public void glWeightPointerARB(int size, uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glWeightPointerARB(int size, uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glWeightPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glVertexBlendARB(int count)
		{
			FctInfo fi = _getf("glVertexBlendARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(count);
		}
		public void glMultiDrawArraysEXT(uint mode, int* first, int* count, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawArraysEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, first, count, primcount);
		}
		public void glMultiDrawArraysEXT(uint mode, IntPtr first, IntPtr count, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawArraysEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, first, count, primcount);
		}
		public void glMultiDrawArraysEXT(uint mode, int[] first, int[] count, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawArraysEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, first, count, primcount);
		}
		public void glMultiDrawElementsEXT(uint mode, int* count, uint type, void** indices, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawElementsEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, count, type, indices, primcount);
		}
		public void glMultiDrawElementsEXT(uint mode, IntPtr count, uint type, IntPtr indices, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawElementsEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, count, type, indices, primcount);
		}
		public void glMultiDrawElementsEXT(uint mode, int[] count, uint type, IntPtr indices, int primcount)
		{
			FctInfo fi = _getf("glMultiDrawElementsEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, count, type, indices, primcount);
		}
		public void glCurrentPaletteMatrixARB(int index)
		{
			FctInfo fi = _getf("glCurrentPaletteMatrixARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(index);
		}
		public void glMatrixIndexubvARB(int size, byte* indices)
		{
			FctInfo fi = _getf("glMatrixIndexubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexubvARB(int size, IntPtr indices)
		{
			FctInfo fi = _getf("glMatrixIndexubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexubvARB(int size, byte[] indices)
		{
			FctInfo fi = _getf("glMatrixIndexubvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexusvARB(int size, ushort* indices)
		{
			FctInfo fi = _getf("glMatrixIndexusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexusvARB(int size, IntPtr indices)
		{
			FctInfo fi = _getf("glMatrixIndexusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexusvARB(int size, ushort[] indices)
		{
			FctInfo fi = _getf("glMatrixIndexusvARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexuivARB(int size, uint* indices)
		{
			FctInfo fi = _getf("glMatrixIndexuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexuivARB(int size, IntPtr indices)
		{
			FctInfo fi = _getf("glMatrixIndexuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexuivARB(int size, uint[] indices)
		{
			FctInfo fi = _getf("glMatrixIndexuivARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, indices);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, void* pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, IntPtr pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, byte[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, sbyte[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, short[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, ushort[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, int[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, uint[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, float[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glMatrixIndexPointerARB(int size, uint type, int stride, double[] pointer)
		{
			FctInfo fi = _getf("glMatrixIndexPointerARB", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(size, type, stride, pointer);
		}
		public void glBeginVertexShaderEXT()
		{
			FctInfo fi = _getf("glBeginVertexShaderEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glEndVertexShaderEXT()
		{
			FctInfo fi = _getf("glEndVertexShaderEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glBindVertexShaderEXT(uint id)
		{
			FctInfo fi = _getf("glBindVertexShaderEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public uint glGenVertexShadersEXT(uint range)
		{
			FctInfo fi = _getf("glGenVertexShadersEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(range);
		}
		public void glDeleteVertexShaderEXT(uint id)
		{
			FctInfo fi = _getf("glDeleteVertexShaderEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public void glShaderOp1EXT(uint op, uint res, uint arg1)
		{
			FctInfo fi = _getf("glShaderOp1EXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, res, arg1);
		}
		public void glShaderOp2EXT(uint op, uint res, uint arg1, uint arg2)
		{
			FctInfo fi = _getf("glShaderOp2EXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, res, arg1, arg2);
		}
		public void glShaderOp3EXT(uint op, uint res, uint arg1, uint arg2, uint arg3)
		{
			FctInfo fi = _getf("glShaderOp3EXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, res, arg1, arg2, arg3);
		}
		public void glSwizzleEXT(uint res, uint In, uint outX, uint outY, uint outZ, uint outW)
		{
			FctInfo fi = _getf("glSwizzleEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(res, In, outX, outY, outZ, outW);
		}
		public void glWriteMaskEXT(uint res, uint In, uint outX, uint outY, uint outZ, uint outW)
		{
			FctInfo fi = _getf("glWriteMaskEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(res, In, outX, outY, outZ, outW);
		}
		public void glInsertComponentEXT(uint res, uint src, uint num)
		{
			FctInfo fi = _getf("glInsertComponentEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(res, src, num);
		}
		public void glExtractComponentEXT(uint res, uint src, uint num)
		{
			FctInfo fi = _getf("glExtractComponentEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(res, src, num);
		}
		public uint glGenSymbolsEXT(uint dataType, uint storageType, uint range, uint components)
		{
			FctInfo fi = _getf("glGenSymbolsEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(dataType, storageType, range, components);
		}
		public void glSetInvariantEXT(uint id, uint type, void* addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, IntPtr addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, byte[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, sbyte[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, short[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, ushort[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, int[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, uint[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, float[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetInvariantEXT(uint id, uint type, double[] addr)
		{
			FctInfo fi = _getf("glSetInvariantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, void* addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, IntPtr addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, byte[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, sbyte[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, short[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, ushort[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, int[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, uint[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, float[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glSetLocalConstantEXT(uint id, uint type, double[] addr)
		{
			FctInfo fi = _getf("glSetLocalConstantEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, addr);
		}
		public void glVariantbvEXT(uint id, byte* addr)
		{
			FctInfo fi = _getf("glVariantbvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantbvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantbvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantbvEXT(uint id, byte[] addr)
		{
			FctInfo fi = _getf("glVariantbvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantsvEXT(uint id, short* addr)
		{
			FctInfo fi = _getf("glVariantsvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantsvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantsvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantsvEXT(uint id, short[] addr)
		{
			FctInfo fi = _getf("glVariantsvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantivEXT(uint id, int* addr)
		{
			FctInfo fi = _getf("glVariantivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantivEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantivEXT(uint id, int[] addr)
		{
			FctInfo fi = _getf("glVariantivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantfvEXT(uint id, float* addr)
		{
			FctInfo fi = _getf("glVariantfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantfvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantfvEXT(uint id, float[] addr)
		{
			FctInfo fi = _getf("glVariantfvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantdvEXT(uint id, double* addr)
		{
			FctInfo fi = _getf("glVariantdvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantdvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantdvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantdvEXT(uint id, double[] addr)
		{
			FctInfo fi = _getf("glVariantdvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantubvEXT(uint id, byte* addr)
		{
			FctInfo fi = _getf("glVariantubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantubvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantubvEXT(uint id, byte[] addr)
		{
			FctInfo fi = _getf("glVariantubvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantusvEXT(uint id, ushort* addr)
		{
			FctInfo fi = _getf("glVariantusvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantusvEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantusvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantusvEXT(uint id, ushort[] addr)
		{
			FctInfo fi = _getf("glVariantusvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantuivEXT(uint id, uint* addr)
		{
			FctInfo fi = _getf("glVariantuivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantuivEXT(uint id, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantuivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantuivEXT(uint id, uint[] addr)
		{
			FctInfo fi = _getf("glVariantuivEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, void* addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, IntPtr addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, byte[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, sbyte[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, short[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, ushort[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, int[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, uint[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, float[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glVariantPointerEXT(uint id, uint type, uint stride, double[] addr)
		{
			FctInfo fi = _getf("glVariantPointerEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, addr);
		}
		public void glEnableVariantClientStateEXT(uint id)
		{
			FctInfo fi = _getf("glEnableVariantClientStateEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public void glDisableVariantClientStateEXT(uint id)
		{
			FctInfo fi = _getf("glDisableVariantClientStateEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public uint glBindLightParameterEXT(uint light, uint value)
		{
			FctInfo fi = _getf("glBindLightParameterEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(light, value);
		}
		public uint glBindMaterialParameterEXT(uint face, uint value)
		{
			FctInfo fi = _getf("glBindMaterialParameterEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(face, value);
		}
		public uint glBindTexGenParameterEXT(uint unit, uint coord, uint value)
		{
			FctInfo fi = _getf("glBindTexGenParameterEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(unit, coord, value);
		}
		public uint glBindTextureUnitParameterEXT(uint unit, uint value)
		{
			FctInfo fi = _getf("glBindTextureUnitParameterEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(unit, value);
		}
		public uint glBindParameterEXT(uint value)
		{
			FctInfo fi = _getf("glBindParameterEXT", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(value);
		}
		public byte glIsVariantEnabledEXT(uint id, uint cap)
		{
			FctInfo fi = _getf("glIsVariantEnabledEXT", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(id, cap);
		}
		public void glGetVariantBooleanvEXT(uint id, uint value, byte* data)
		{
			FctInfo fi = _getf("glGetVariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantBooleanvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetVariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantBooleanvEXT(uint id, uint value, byte[] data)
		{
			FctInfo fi = _getf("glGetVariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantIntegervEXT(uint id, uint value, int* data)
		{
			FctInfo fi = _getf("glGetVariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantIntegervEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetVariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantIntegervEXT(uint id, uint value, int[] data)
		{
			FctInfo fi = _getf("glGetVariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantFloatvEXT(uint id, uint value, float* data)
		{
			FctInfo fi = _getf("glGetVariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantFloatvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetVariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantFloatvEXT(uint id, uint value, float[] data)
		{
			FctInfo fi = _getf("glGetVariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantPointervEXT(uint id, uint value, void** data)
		{
			FctInfo fi = _getf("glGetVariantPointervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetVariantPointervEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetVariantPointervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantBooleanvEXT(uint id, uint value, byte* data)
		{
			FctInfo fi = _getf("glGetInvariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantBooleanvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetInvariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantBooleanvEXT(uint id, uint value, byte[] data)
		{
			FctInfo fi = _getf("glGetInvariantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantIntegervEXT(uint id, uint value, int* data)
		{
			FctInfo fi = _getf("glGetInvariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantIntegervEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetInvariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantIntegervEXT(uint id, uint value, int[] data)
		{
			FctInfo fi = _getf("glGetInvariantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantFloatvEXT(uint id, uint value, float* data)
		{
			FctInfo fi = _getf("glGetInvariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantFloatvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetInvariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetInvariantFloatvEXT(uint id, uint value, float[] data)
		{
			FctInfo fi = _getf("glGetInvariantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantBooleanvEXT(uint id, uint value, byte* data)
		{
			FctInfo fi = _getf("glGetLocalConstantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantBooleanvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetLocalConstantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantBooleanvEXT(uint id, uint value, byte[] data)
		{
			FctInfo fi = _getf("glGetLocalConstantBooleanvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantIntegervEXT(uint id, uint value, int* data)
		{
			FctInfo fi = _getf("glGetLocalConstantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantIntegervEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetLocalConstantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantIntegervEXT(uint id, uint value, int[] data)
		{
			FctInfo fi = _getf("glGetLocalConstantIntegervEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantFloatvEXT(uint id, uint value, float* data)
		{
			FctInfo fi = _getf("glGetLocalConstantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantFloatvEXT(uint id, uint value, IntPtr data)
		{
			FctInfo fi = _getf("glGetLocalConstantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glGetLocalConstantFloatvEXT(uint id, uint value, float[] data)
		{
			FctInfo fi = _getf("glGetLocalConstantFloatvEXT", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, value, data);
		}
		public void glTexBumpParameterivATI(uint pname, int* param)
		{
			FctInfo fi = _getf("glTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glTexBumpParameterivATI(uint pname, IntPtr param)
		{
			FctInfo fi = _getf("glTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glTexBumpParameterivATI(uint pname, int[] param)
		{
			FctInfo fi = _getf("glTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glTexBumpParameterfvATI(uint pname, float* param)
		{
			FctInfo fi = _getf("glTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glTexBumpParameterfvATI(uint pname, IntPtr param)
		{
			FctInfo fi = _getf("glTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glTexBumpParameterfvATI(uint pname, float[] param)
		{
			FctInfo fi = _getf("glTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterivATI(uint pname, int* param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterivATI(uint pname, IntPtr param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterivATI(uint pname, int[] param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterfvATI(uint pname, float* param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterfvATI(uint pname, IntPtr param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glGetTexBumpParameterfvATI(uint pname, float[] param)
		{
			FctInfo fi = _getf("glGetTexBumpParameterfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public uint glGenFragmentShadersATI(uint range)
		{
			FctInfo fi = _getf("glGenFragmentShadersATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(range);
		}
		public void glBindFragmentShaderATI(uint id)
		{
			FctInfo fi = _getf("glBindFragmentShaderATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public void glDeleteFragmentShaderATI(uint id)
		{
			FctInfo fi = _getf("glDeleteFragmentShaderATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id);
		}
		public void glBeginFragmentShaderATI()
		{
			FctInfo fi = _getf("glBeginFragmentShaderATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glEndFragmentShaderATI()
		{
			FctInfo fi = _getf("glEndFragmentShaderATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize();
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call();
		}
		public void glPassTexCoordATI(uint dst, uint coord, uint swizzle)
		{
			FctInfo fi = _getf("glPassTexCoordATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(dst, coord, swizzle);
		}
		public void glSampleMapATI(uint dst, uint interp, uint swizzle)
		{
			FctInfo fi = _getf("glSampleMapATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(dst, interp, swizzle);
		}
		public void glColorFragmentOp1ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
		{
			FctInfo fi = _getf("glColorFragmentOp1ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod);
		}
		public void glColorFragmentOp2ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
		{
			FctInfo fi = _getf("glColorFragmentOp2ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
		}
		public void glColorFragmentOp3ATI(uint op, uint dst, uint dstMask, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
		{
			FctInfo fi = _getf("glColorFragmentOp3ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMask, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
		}
		public void glAlphaFragmentOp1ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod)
		{
			FctInfo fi = _getf("glAlphaFragmentOp1ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMod, arg1, arg1Rep, arg1Mod);
		}
		public void glAlphaFragmentOp2ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod)
		{
			FctInfo fi = _getf("glAlphaFragmentOp2ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod);
		}
		public void glAlphaFragmentOp3ATI(uint op, uint dst, uint dstMod, uint arg1, uint arg1Rep, uint arg1Mod, uint arg2, uint arg2Rep, uint arg2Mod, uint arg3, uint arg3Rep, uint arg3Mod)
		{
			FctInfo fi = _getf("glAlphaFragmentOp3ATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(op, dst, dstMod, arg1, arg1Rep, arg1Mod, arg2, arg2Rep, arg2Mod, arg3, arg3Rep, arg3Mod);
		}
		public void glSetFragmentShaderConstantATI(uint dst, float* value)
		{
			FctInfo fi = _getf("glSetFragmentShaderConstantATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(dst, value);
		}
		public void glSetFragmentShaderConstantATI(uint dst, IntPtr value)
		{
			FctInfo fi = _getf("glSetFragmentShaderConstantATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(dst, value);
		}
		public void glSetFragmentShaderConstantATI(uint dst, float[] value)
		{
			FctInfo fi = _getf("glSetFragmentShaderConstantATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(dst, value);
		}
		public void glElementPointerATI(uint type, void* pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, IntPtr pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, byte[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, sbyte[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, short[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, ushort[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, int[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, uint[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, float[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glElementPointerATI(uint type, double[] pointer)
		{
			FctInfo fi = _getf("glElementPointerATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(type, pointer);
		}
		public void glDrawElementArrayATI(uint mode, int count)
		{
			FctInfo fi = _getf("glDrawElementArrayATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, count);
		}
		public void glDrawRangeElementArrayATI(uint mode, uint start, uint end, int count)
		{
			FctInfo fi = _getf("glDrawRangeElementArrayATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(mode, start, end, count);
		}
		public void glClientActiveVertexStreamATI(uint stream)
		{
			FctInfo fi = _getf("glClientActiveVertexStreamATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream);
		}
		public void glVertexBlendEnviATI(uint pname, int param)
		{
			FctInfo fi = _getf("glVertexBlendEnviATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glVertexBlendEnvfATI(uint pname, float param)
		{
			FctInfo fi = _getf("glVertexBlendEnvfATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(pname, param);
		}
		public void glVertexStream2sATI(uint stream, short x, short y)
		{
			FctInfo fi = _getf("glVertexStream2sATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y);
		}
		public void glVertexStream2svATI(uint stream, short* v)
		{
			FctInfo fi = _getf("glVertexStream2svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2svATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream2svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2svATI(uint stream, short[] v)
		{
			FctInfo fi = _getf("glVertexStream2svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2iATI(uint stream, int x, int y)
		{
			FctInfo fi = _getf("glVertexStream2iATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y);
		}
		public void glVertexStream2ivATI(uint stream, int* v)
		{
			FctInfo fi = _getf("glVertexStream2ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2ivATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream2ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2ivATI(uint stream, int[] v)
		{
			FctInfo fi = _getf("glVertexStream2ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2fATI(uint stream, float x, float y)
		{
			FctInfo fi = _getf("glVertexStream2fATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y);
		}
		public void glVertexStream2fvATI(uint stream, float* v)
		{
			FctInfo fi = _getf("glVertexStream2fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2fvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream2fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2fvATI(uint stream, float[] v)
		{
			FctInfo fi = _getf("glVertexStream2fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2dATI(uint stream, double x, double y)
		{
			FctInfo fi = _getf("glVertexStream2dATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y);
		}
		public void glVertexStream2dvATI(uint stream, double* v)
		{
			FctInfo fi = _getf("glVertexStream2dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2dvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream2dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream2dvATI(uint stream, double[] v)
		{
			FctInfo fi = _getf("glVertexStream2dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3sATI(uint stream, short x, short y, short z)
		{
			FctInfo fi = _getf("glVertexStream3sATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glVertexStream3svATI(uint stream, short* v)
		{
			FctInfo fi = _getf("glVertexStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3svATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3svATI(uint stream, short[] v)
		{
			FctInfo fi = _getf("glVertexStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3iATI(uint stream, int x, int y, int z)
		{
			FctInfo fi = _getf("glVertexStream3iATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glVertexStream3ivATI(uint stream, int* v)
		{
			FctInfo fi = _getf("glVertexStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3ivATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3ivATI(uint stream, int[] v)
		{
			FctInfo fi = _getf("glVertexStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3fATI(uint stream, float x, float y, float z)
		{
			FctInfo fi = _getf("glVertexStream3fATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glVertexStream3fvATI(uint stream, float* v)
		{
			FctInfo fi = _getf("glVertexStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3fvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3fvATI(uint stream, float[] v)
		{
			FctInfo fi = _getf("glVertexStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3dATI(uint stream, double x, double y, double z)
		{
			FctInfo fi = _getf("glVertexStream3dATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glVertexStream3dvATI(uint stream, double* v)
		{
			FctInfo fi = _getf("glVertexStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3dvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream3dvATI(uint stream, double[] v)
		{
			FctInfo fi = _getf("glVertexStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4sATI(uint stream, short x, short y, short z, short w)
		{
			FctInfo fi = _getf("glVertexStream4sATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z, w);
		}
		public void glVertexStream4svATI(uint stream, short* v)
		{
			FctInfo fi = _getf("glVertexStream4svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4svATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream4svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4svATI(uint stream, short[] v)
		{
			FctInfo fi = _getf("glVertexStream4svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4iATI(uint stream, int x, int y, int z, int w)
		{
			FctInfo fi = _getf("glVertexStream4iATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z, w);
		}
		public void glVertexStream4ivATI(uint stream, int* v)
		{
			FctInfo fi = _getf("glVertexStream4ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4ivATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream4ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4ivATI(uint stream, int[] v)
		{
			FctInfo fi = _getf("glVertexStream4ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4fATI(uint stream, float x, float y, float z, float w)
		{
			FctInfo fi = _getf("glVertexStream4fATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z, w);
		}
		public void glVertexStream4fvATI(uint stream, float* v)
		{
			FctInfo fi = _getf("glVertexStream4fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4fvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream4fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4fvATI(uint stream, float[] v)
		{
			FctInfo fi = _getf("glVertexStream4fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4dATI(uint stream, double x, double y, double z, double w)
		{
			FctInfo fi = _getf("glVertexStream4dATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z, w);
		}
		public void glVertexStream4dvATI(uint stream, double* v)
		{
			FctInfo fi = _getf("glVertexStream4dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4dvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glVertexStream4dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glVertexStream4dvATI(uint stream, double[] v)
		{
			FctInfo fi = _getf("glVertexStream4dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3bATI(uint stream, byte x, byte y, byte z)
		{
			FctInfo fi = _getf("glNormalStream3bATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 1, 1, 1);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glNormalStream3bvATI(uint stream, byte* v)
		{
			FctInfo fi = _getf("glNormalStream3bvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3bvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glNormalStream3bvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3bvATI(uint stream, byte[] v)
		{
			FctInfo fi = _getf("glNormalStream3bvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3sATI(uint stream, short x, short y, short z)
		{
			FctInfo fi = _getf("glNormalStream3sATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 2, 2, 2);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glNormalStream3svATI(uint stream, short* v)
		{
			FctInfo fi = _getf("glNormalStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3svATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glNormalStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3svATI(uint stream, short[] v)
		{
			FctInfo fi = _getf("glNormalStream3svATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3iATI(uint stream, int x, int y, int z)
		{
			FctInfo fi = _getf("glNormalStream3iATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glNormalStream3ivATI(uint stream, int* v)
		{
			FctInfo fi = _getf("glNormalStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3ivATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glNormalStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3ivATI(uint stream, int[] v)
		{
			FctInfo fi = _getf("glNormalStream3ivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3fATI(uint stream, float x, float y, float z)
		{
			FctInfo fi = _getf("glNormalStream3fATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glNormalStream3fvATI(uint stream, float* v)
		{
			FctInfo fi = _getf("glNormalStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3fvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glNormalStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3fvATI(uint stream, float[] v)
		{
			FctInfo fi = _getf("glNormalStream3fvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3dATI(uint stream, double x, double y, double z)
		{
			FctInfo fi = _getf("glNormalStream3dATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 8, 8, 8);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, x, y, z);
		}
		public void glNormalStream3dvATI(uint stream, double* v)
		{
			FctInfo fi = _getf("glNormalStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3dvATI(uint stream, IntPtr v)
		{
			FctInfo fi = _getf("glNormalStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public void glNormalStream3dvATI(uint stream, double[] v)
		{
			FctInfo fi = _getf("glNormalStream3dvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(stream, v);
		}
		public uint glNewObjectBufferATI(int size, void* pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, IntPtr pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, byte[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, sbyte[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, short[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, ushort[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, int[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, uint[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, float[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public uint glNewObjectBufferATI(int size, double[] pointer, uint usage)
		{
			FctInfo fi = _getf("glNewObjectBufferATI", true);
			if(fi == null)
				return (uint) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.uintCall(size, pointer, usage);
		}
		public byte glIsObjectBufferATI(uint buffer)
		{
			FctInfo fi = _getf("glIsObjectBufferATI", true);
			if(fi == null)
				return (byte) 0;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			return CFunction.byteCall(buffer);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, void* pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, IntPtr pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, byte[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, sbyte[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, short[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, ushort[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, int[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, uint[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, float[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glUpdateObjectBufferATI(uint buffer, uint offset, int size, double[] pointer, uint preserve)
		{
			FctInfo fi = _getf("glUpdateObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, IntPtr.Size, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, offset, size, pointer, preserve);
		}
		public void glGetObjectBufferfvATI(uint buffer, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetObjectBufferfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glGetObjectBufferfvATI(uint buffer, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetObjectBufferfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glGetObjectBufferfvATI(uint buffer, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetObjectBufferfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glGetObjectBufferivATI(uint buffer, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetObjectBufferivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glGetObjectBufferivATI(uint buffer, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetObjectBufferivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glGetObjectBufferivATI(uint buffer, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetObjectBufferivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer, pname, Params);
		}
		public void glFreeObjectBufferATI(uint buffer)
		{
			FctInfo fi = _getf("glFreeObjectBufferATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(buffer);
		}
		public void glArrayObjectATI(uint array, int size, uint type, int stride, uint buffer, uint offset)
		{
			FctInfo fi = _getf("glArrayObjectATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, size, type, stride, buffer, offset);
		}
		public void glGetArrayObjectfvATI(uint array, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glGetArrayObjectfvATI(uint array, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glGetArrayObjectfvATI(uint array, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glGetArrayObjectivATI(uint array, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glGetArrayObjectivATI(uint array, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glGetArrayObjectivATI(uint array, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(array, pname, Params);
		}
		public void glVariantArrayObjectATI(uint id, uint type, int stride, uint buffer, uint offset)
		{
			FctInfo fi = _getf("glVariantArrayObjectATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, 4, 4, 4);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, type, stride, buffer, offset);
		}
		public void glGetVariantArrayObjectfvATI(uint id, uint pname, float* Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetVariantArrayObjectfvATI(uint id, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetVariantArrayObjectfvATI(uint id, uint pname, float[] Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectfvATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetVariantArrayObjectivATI(uint id, uint pname, int* Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetVariantArrayObjectivATI(uint id, uint pname, IntPtr Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}
		public void glGetVariantArrayObjectivATI(uint id, uint pname, int[] Params)
		{
			FctInfo fi = _getf("glGetVariantArrayObjectivATI", true);
			if(fi == null)
				return;
			if(fi.stack_size == -1)
				fi.stack_size = CFunction.StackSize(4, 4, IntPtr.Size);
			CFunction.Prepare(fi.function_ptr, fi.stack_size);
			CFunction.Call(id, pname, Params);
		}

		class FctInfo
		{
			public FctInfo(IntPtr p) { function_ptr = p; }
			public IntPtr function_ptr;
			public int    stack_size = -1;
		}
		private ContextLocal _fctsTable;
		private Hashtable    _globalFct;
		private FctInfo      _getf(string name, bool contextLocal)
		{
			Hashtable fcts = null;
			if(contextLocal) {
				if(_fctsTable==null)
					_fctsTable = new ContextLocal();
				fcts = (Hashtable) _fctsTable.Value;
				if(fcts == null) {
					if(OpenGLContext.Current == null)
						return null;
					fcts = new Hashtable();
					_fctsTable.Value = fcts;
				}
			} else {
				if(_globalFct==null)
					_globalFct = new Hashtable();
				fcts = _globalFct;
			}
			FctInfo o = (FctInfo) fcts[name];
			if(o == null) {
				o = new FctInfo(GetProc(name, true));
				fcts[name] = o;
			}
			return o;
		}
	}
}
