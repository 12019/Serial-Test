/*
 * BSD Licence:
 * Copyright (c) 2001, Lloyd Dupont (lloyd@galador.net)
 * <ORGANIZATION> 
 * All rights reserved.
 * 
 *
 * Redistribution and use in source and binary forms, with or without 
 * modification, are permitted provided that the following conditions are met:
 *
 * 1. Redistributions of source code must retain the above copyright notice, 
 * this list of conditions and the following disclaimer.
 * 2. Redistributions in binary form must reproduce the above copyright 
 * notice, this list of conditions and the following disclaimer in the 
 * documentation and/or other materials provided with the distribution.
 * 3. Neither the name of the <ORGANIZATION> nor the names of its contributors
 * may be used to endorse or promote products derived from this software
 * without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED. IN NO EVENT SHALL THE REGENTS OR CONTRIBUTORS BE LIABLE FOR
 * ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL
 * DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR
 * SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER
 * CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT 
 * LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY
 * OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH
 * DAMAGE.
 */
using System;
using System.Text;
using System.Runtime.InteropServices;
using CsGL.Util;
using CsGL.Pointers;

namespace CsGL.OpenGL
{
	[StructLayout(LayoutKind.Sequential)]
	public struct GLUnurbs {public IntPtr data;}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct GLUquadric {public IntPtr data;}
	
	[StructLayout(LayoutKind.Sequential)]
	public struct GLUtesselator {public IntPtr data;}
	
	public delegate void GLUquadricErrorProc(uint type);
	
	public delegate void GLUtessBeginProc(uint type);
	public delegate void GLUtessEdgeFlagProc(byte boolean);
	public delegate void GLUtessVertexProc(IntPtr data);
	public delegate void GLUtessEndProc();
	public delegate void GLUtessErrorProc(uint type);
	public delegate void GLUtessCombineProc([Out][MarshalAs(UnmanagedType.LPArray, SizeConst=3)] double[] d1,
											[Out][MarshalAs(UnmanagedType.LPArray, SizeConst=4)] IntPtr[] d2, 
											[Out][MarshalAs(UnmanagedType.LPArray, SizeConst=4)] float[] d3,
											RPVoid d4);
	public delegate void GLUtessCombineProc2(RDouble d1,
											 RPVoid d2, 
											 RFloat d3,
											 RPVoid d4);
	public delegate void GLUtessBeginDataProc(uint type, IntPtr d);
	public delegate void GLUtessEdgeFlagDataProc(byte boolTest, IntPtr data);
	public delegate void GLUtessVertexDataProc(IntPtr d1, IntPtr d2);
	public delegate void GLUtessEndDataProc(IntPtr p);
	public delegate void GLUtessErrorDataProc(uint type, IntPtr p);
	public delegate void GLUtessCombineDataProc([Out][MarshalAs(UnmanagedType.LPArray, SizeConst=3)]double[] d1,
                                                [Out][MarshalAs(UnmanagedType.LPArray, SizeConst=4)]IntPtr[] d2, 
                                                [Out][MarshalAs(UnmanagedType.LPArray, SizeConst=4)]float[] d3,
                                                RPVoid d4,
                                                IntPtr d5);
	public delegate void GLUtessCombineDataProc2(RDouble d1,
                                                 RPVoid d2, 
                                                 RFloat d3,
                                                 RPVoid d4,
                                                 IntPtr d5);

	/* gluNurbsCallback */
	public delegate void GLUnurbsErrorProc(uint type);
	
	
	/// <summary>
	/// this file is simply an export in C# of function defined GL/glu.h
	/// look at http://www.opengl.org for more info about using OpenGL
    /// and glu library.
	/// </summary>
	[Serializable]
	public abstract unsafe class GLU : OpenGL_Extension
	{
		public const uint GLU_EXT_object_space_tess = 1;
		public const uint GLU_EXT_nurbs_tessellator = 1;
		public const uint GLU_FALSE = 0;
		public const uint GLU_TRUE = 1;
		public const uint GLU_VERSION_1_1 = 1;
		public const uint GLU_VERSION_1_2 = 1;
		public const uint GLU_VERSION = 100800;
		public const uint GLU_EXTENSIONS = 100801;
		public const uint GLU_INVALID_ENUM = 100900;
		public const uint GLU_INVALID_VALUE = 100901;
		public const uint GLU_OUT_OF_MEMORY = 100902;
		public const uint GLU_INCOMPATIBLE_GL_VERSION = 100903;
		public const uint GLU_INVALID_OPERATION = 100904;
		public const uint GLU_OUTLINE_POLYGON = 100240;
		public const uint GLU_OUTLINE_PATCH = 100241;
		public const uint GLU_ERROR = 100103;
		public const uint GLU_NURBS_ERROR1 = 100251;
		public const uint GLU_NURBS_ERROR2 = 100252;
		public const uint GLU_NURBS_ERROR3 = 100253;
		public const uint GLU_NURBS_ERROR4 = 100254;
		public const uint GLU_NURBS_ERROR5 = 100255;
		public const uint GLU_NURBS_ERROR6 = 100256;
		public const uint GLU_NURBS_ERROR7 = 100257;
		public const uint GLU_NURBS_ERROR8 = 100258;
		public const uint GLU_NURBS_ERROR9 = 100259;
		public const uint GLU_NURBS_ERROR10 = 100260;
		public const uint GLU_NURBS_ERROR11 = 100261;
		public const uint GLU_NURBS_ERROR12 = 100262;
		public const uint GLU_NURBS_ERROR13 = 100263;
		public const uint GLU_NURBS_ERROR14 = 100264;
		public const uint GLU_NURBS_ERROR15 = 100265;
		public const uint GLU_NURBS_ERROR16 = 100266;
		public const uint GLU_NURBS_ERROR17 = 100267;
		public const uint GLU_NURBS_ERROR18 = 100268;
		public const uint GLU_NURBS_ERROR19 = 100269;
		public const uint GLU_NURBS_ERROR20 = 100270;
		public const uint GLU_NURBS_ERROR21 = 100271;
		public const uint GLU_NURBS_ERROR22 = 100272;
		public const uint GLU_NURBS_ERROR23 = 100273;
		public const uint GLU_NURBS_ERROR24 = 100274;
		public const uint GLU_NURBS_ERROR25 = 100275;
		public const uint GLU_NURBS_ERROR26 = 100276;
		public const uint GLU_NURBS_ERROR27 = 100277;
		public const uint GLU_NURBS_ERROR28 = 100278;
		public const uint GLU_NURBS_ERROR29 = 100279;
		public const uint GLU_NURBS_ERROR30 = 100280;
		public const uint GLU_NURBS_ERROR31 = 100281;
		public const uint GLU_NURBS_ERROR32 = 100282;
		public const uint GLU_NURBS_ERROR33 = 100283;
		public const uint GLU_NURBS_ERROR34 = 100284;
		public const uint GLU_NURBS_ERROR35 = 100285;
		public const uint GLU_NURBS_ERROR36 = 100286;
		public const uint GLU_NURBS_ERROR37 = 100287;
		public const uint GLU_AUTO_LOAD_MATRIX = 100200;
		public const uint GLU_CULLING = 100201;
		public const uint GLU_SAMPLING_TOLERANCE = 100203;
		public const uint GLU_DISPLAY_MODE = 100204;
		public const uint GLU_PARAMETRIC_TOLERANCE = 100202;
		public const uint GLU_SAMPLING_METHOD = 100205;
		public const uint GLU_U_STEP = 100206;
		public const uint GLU_V_STEP = 100207;
		public const uint GLU_OBJECT_PARAMETRIC_ERROR_EXT = 100208;
		public const uint GLU_OBJECT_PATH_LENGTH_EXT = 100209;
		public const uint GLU_PATH_LENGTH = 100215;
		public const uint GLU_PARAMETRIC_ERROR = 100216;
		public const uint GLU_DOMAIN_DISTANCE = 100217;
		public const uint GLU_MAP1_TRIM_2 = 100210;
		public const uint GLU_MAP1_TRIM_3 = 100211;
		public const uint GLU_POINT = 100010;
		public const uint GLU_LINE = 100011;
		public const uint GLU_FILL = 100012;
		public const uint GLU_SILHOUETTE = 100013;
		public const uint GLU_SMOOTH = 100000;
		public const uint GLU_FLAT = 100001;
		public const uint GLU_NONE = 100002;
		public const uint GLU_OUTSIDE = 100020;
		public const uint GLU_INSIDE = 100021;
		public const uint GLU_TESS_BEGIN = 100100;
		public const uint GLU_BEGIN = 100100;
		public const uint GLU_TESS_VERTEX = 100101;
		public const uint GLU_VERTEX = 100101;
		public const uint GLU_TESS_END = 100102;
		public const uint GLU_END = 100102;
		public const uint GLU_TESS_ERROR = 100103;
		public const uint GLU_TESS_EDGE_FLAG = 100104;
		public const uint GLU_EDGE_FLAG = 100104;
		public const uint GLU_TESS_COMBINE = 100105;
		public const uint GLU_TESS_BEGIN_DATA = 100106;
		public const uint GLU_TESS_VERTEX_DATA = 100107;
		public const uint GLU_TESS_END_DATA = 100108;
		public const uint GLU_TESS_ERROR_DATA = 100109;
		public const uint GLU_TESS_EDGE_FLAG_DATA = 100110;
		public const uint GLU_TESS_COMBINE_DATA = 100111;
		public const uint GLU_NURBS_MODE_EXT = 100160;
		public const uint GLU_NURBS_TESSELLATOR_EXT = 100161;
		public const uint GLU_NURBS_RENDERER_EXT = 100162;
		public const uint GLU_NURBS_BEGIN_EXT = 100164;
		public const uint GLU_NURBS_VERTEX_EXT = 100165;
		public const uint GLU_NURBS_NORMAL_EXT = 100166;
		public const uint GLU_NURBS_COLOR_EXT = 100167;
		public const uint GLU_NURBS_TEX_COORD_EXT = 100168;
		public const uint GLU_NURBS_END_EXT = 100169;
		public const uint GLU_NURBS_BEGIN_DATA_EXT = 100170;
		public const uint GLU_NURBS_VERTEX_DATA_EXT = 100171;
		public const uint GLU_NURBS_NORMAL_DATA_EXT = 100172;
		public const uint GLU_NURBS_COLOR_DATA_EXT = 100173;
		public const uint GLU_NURBS_TEX_COORD_DATA_EXT = 100174;
		public const uint GLU_NURBS_END_DATA_EXT = 100175;
		public const uint GLU_CW = 100120;
		public const uint GLU_CCW = 100121;
		public const uint GLU_INTERIOR = 100122;
		public const uint GLU_EXTERIOR = 100123;
		public const uint GLU_UNKNOWN = 100124;
		public const uint GLU_TESS_WINDING_RULE = 100140;
		public const uint GLU_TESS_BOUNDARY_ONLY = 100141;
		public const uint GLU_TESS_TOLERANCE = 100142;
		public const uint GLU_TESS_ERROR1 = 100151;
		public const uint GLU_TESS_ERROR2 = 100152;
		public const uint GLU_TESS_ERROR3 = 100153;
		public const uint GLU_TESS_ERROR4 = 100154;
		public const uint GLU_TESS_ERROR5 = 100155;
		public const uint GLU_TESS_ERROR6 = 100156;
		public const uint GLU_TESS_ERROR7 = 100157;
		public const uint GLU_TESS_ERROR8 = 100158;
		public const uint GLU_TESS_MISSING_BEGIN_POLYGON = 100151;
		public const uint GLU_TESS_MISSING_BEGIN_CONTOUR = 100152;
		public const uint GLU_TESS_MISSING_END_POLYGON = 100153;
		public const uint GLU_TESS_MISSING_END_CONTOUR = 100154;
		public const uint GLU_TESS_COORD_TOO_LARGE = 100155;
		public const uint GLU_TESS_NEED_COMBINE_CALLBACK = 100156;
		public const uint GLU_TESS_WINDING_ODD = 100130;
		public const uint GLU_TESS_WINDING_NONZERO = 100131;
		public const uint GLU_TESS_WINDING_POSITIVE = 100132;
		public const uint GLU_TESS_WINDING_NEGATIVE = 100133;
		public const uint GLU_TESS_WINDING_ABS_GEQ_TWO = 100134;
		public const double GLU_TESS_MAX_COORD = 1.0e150;
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluBeginCurve(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluBeginPolygon(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluBeginSurface(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluBeginTrim(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild1DMipmaps(uint target, int component, int width, uint format, uint type, void *data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild2DMipmaps(uint target, int component, int width, int height, uint format, uint type, void *data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluCylinder(GLUquadric quad, double myBase, double top, double height, int slices, int stacks);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluDeleteNurbsRenderer(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluDeleteNurbsTessellatorEXT(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluDeleteTess(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluDisk(GLUquadric quad, double inner, double outer, int slices, int loops);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluEndCurve(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluEndPolygon(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluEndSurface(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluEndTrim(GLUnurbs nurb);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern byte * gluErrorString(uint error);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluGetNurbsProperty(GLUnurbs nurb, uint property, float* data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern byte * gluGetString(uint name);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluGetTessProperty(GLUtesselator tess, uint which, double* data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluLoadSamplingMatrices(GLUnurbs nurb,  float *model, float *perspective, int *view);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluLookAt(double eyeX, double eyeY, double eyeZ, double centerX, double centerY, double centerZ, double upX, double upY, double upZ);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern GLUnurbs gluNewNurbsRenderer();
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern GLUquadric gluNewQuadric();
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluDeleteQuadric(GLUquadric quad);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern GLUtesselator gluNewTess();
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNextContour(GLUtesselator tess, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsCallback(GLUnurbs nurb, uint which, void* CallBackFunc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsCallback(GLUnurbs nurb, uint which, GLUnurbsErrorProc CallBackFunc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsCurve(GLUnurbs nurb, int knotCount, float *knots, int stride, float *control, int order, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsProperty(GLUnurbs nurb, uint property, float val);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsSurface(GLUnurbs nurb, int sKnotCount, float* sKnots, int tKnotCount, float* tKnots, int sStride, int tStride, float* control, int sOrder, int tOrder, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluOrtho2D(double left, double right, double bottom, double top);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPartialDisk(GLUquadric quad, double inner, double outer, int slices, int loops, double start, double sweep);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPerspective(double fovy, double aspect, double zNear, double zFar);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPickMatrix(double x, double y, double delX, double delY, int *viewport);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluProject(double objX, double objY, double objZ, double *model, double *proj, int *view, double* winX, double* winY, double* winZ);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPwlCurve(GLUquadric nurb, int count, float* data, int stride, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricCallback(GLUquadric quad, uint which, void* CallBackFunc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricCallback(GLUquadric quad, uint which, GLUquadricErrorProc CallBackFunc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricDrawStyle(GLUquadric quad, uint draw);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricNormals(GLUquadric quad, uint normal);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricOrientation(GLUquadric quad, uint orientation);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluQuadricTexture(GLUquadric quad, byte texture);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluScaleImage(uint format, int wIn, int hIn, uint typeIn, void *dataIn, int wOut, int hOut, uint typeOut, void* dataOut);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluSphere(GLUquadric quad, double radius, int slices, int stacks);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessBeginContour(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessBeginPolygon(GLUtesselator tess, void* data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, void* proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessBeginProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessEdgeFlagProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessVertexProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessEndProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessErrorProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessCombineProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessCombineProc2 proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessBeginDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessEdgeFlagDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessVertexDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessEndDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessErrorDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessCombineDataProc proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessCallback(GLUtesselator tess, uint which, GLUtessCombineDataProc2 proc);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessEndContour(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessEndPolygon(GLUtesselator tess);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessNormal(GLUtesselator tess, double valueX, double valueY, double valueZ);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessProperty(GLUtesselator tess, uint which, double data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessVertex(GLUtesselator tess, double *location, void* data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluUnProject(double winX, double winY, double winZ, double *model, double *proj, int *view, double* objX, double* objY, double* objZ);
	}
}
