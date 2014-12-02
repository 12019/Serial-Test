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
using System.Drawing;
using System.Runtime.InteropServices;
using CsGL.Util;

namespace CsGL.OpenGL 
{
	/// <summary>
	/// this class hold any clean (safe) wrapper of OpenGL and GLU code, as these
	/// class hold as close as possible from original C code function.
    /// for any documentation report to OpenGL documentation
	/// </summary>
	[Serializable]
	public abstract class GL : GLUT 
	{
		public void glEnable(uint param, bool toEnable)
		{
			if(toEnable)
				glEnable(param);
			else
				glDisable(param);
		}
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, float[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, int[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, uint[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage1D(uint target, int level, int components, int width, int border, uint format, uint type, float[,] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage2D(uint target, int level, int components, int width, int height, int border, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexImage(uint target, int level, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage2D(uint target, int level, int components, int width, int height, int border, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexImage(uint target, int level, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, uint[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, byte[,,] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexImage2D(uint target, int level, int components, int width, int height, int border, uint format, uint type, uint[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexImage(uint target, int level, uint format, uint type, uint[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, uint[] pixels);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte[] bitmap);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, IntPtr bitmap);
		
		///////////////////////////////////////////////////////////////////////////////////

		// sign of const solution
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexParameteri(uint target, uint pname, uint param);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexParameterfv(uint target, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexParameteriv(uint target, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, out int someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexParameterfv(uint target, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexParameteriv(uint target, uint pname, out int someParams);
	
		// pointer solution
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, byte[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, sbyte[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, short[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, ushort[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, int[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, uint[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, float[] lists);
		[DllImport(OPENGL_LIB, CharSet=CharSet.Unicode)]
		public static extern void glCallLists(int n, uint type, char[] lists);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glCallLists(int n, uint type, [MarshalAs(UnmanagedType.LPWStr)] string lists);
   
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos2dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos2fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos2iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos2sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos3dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos3fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos3iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos3sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos4dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos4fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos4iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRasterPos4sv(short[] v);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, ushort[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, uint[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, IntPtr pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, byte[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, ushort[] pixels);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawPixels(int width, int height, uint format, uint type, uint[] pixels);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGenTextures(int n, uint[] textures);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDeleteTextures(int n,  uint[] textures);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormal3bv(sbyte[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormal3dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormal3fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormal3iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormal3sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex2dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex2fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex2iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex2sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex3dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex3fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex3iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex3sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex4dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex4fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex4iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertex4sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLightModelfv(uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLightModeliv(uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLightfv(uint light, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLightiv(uint light, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3bv(sbyte[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3ubv(byte[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3uiv(uint[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor3usv(ushort[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4bv(sbyte[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4ubv(byte[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4uiv(uint[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColor4usv(ushort[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetBooleanv(uint pname, byte[] someParams );
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetDoublev(uint pname, double[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetFloatv(uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetIntegerv(uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetIntegerv(uint pname, uint[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetBooleanv(uint pname, out byte someParam);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetDoublev(uint pname, out double someParam);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetFloatv(uint pname, out float someParam);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetIntegerv(uint pname, out int someParam);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetIntegerv(uint pname, out uint someParam);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLoadMatrixd(double[] m);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glLoadMatrixf(float[] m);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMultMatrixd(double[] m);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMultMatrixf(float[] m);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEdgeFlagv(ref byte flag);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEdgeFlagv(byte[] flag);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMaterialfv(uint face, uint pname,  ref float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMaterialfv(uint face, uint pname,  float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMaterialfv(uint face, uint pname,  IntPtr someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMaterialiv(uint face, uint pname,  ref int someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMaterialiv(uint face, uint pname,  int[] someParams);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord1dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord1fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord1iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord1sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord2dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord2fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord2iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord2sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord3dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord3fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord3iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord3sv(short[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord4dv(double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord4fv(float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord4iv(int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoord4sv(short[] v);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public new static extern string glGetString(uint name);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glSelectBuffer(int size, uint[] buffer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glSelectBuffer(int size, IntPtr buffer);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glFeedbackBuffer(int size, uint type, float[] buffer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glFeedbackBuffer(int size, uint type, IntPtr buffer);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern byte glAreTexturesResident(int n, out uint textures, out byte residences);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern byte glAreTexturesResident(int n, uint[] textures, byte[] residences);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glPrioritizeTextures(int n, uint[] textures, float[] priorities);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glClipPlane(uint plane, double[] equation);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetClipPlane(uint plane, double[] equation);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEvalCoord2dv(double[] u);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEvalCoord2fv(float[] u);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEvalCoord1dv(double[] u);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEvalCoord1fv(float[] u);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glFogfv(uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glFogiv(uint pname, int[] someParams);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetLightfv(uint light, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetLightiv(uint light, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetLightfv(uint light, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetLightiv(uint light, uint pname, out int someParams);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMaterialfv(uint face, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMaterialiv(uint face, uint pname, out int someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMaterialfv(uint face, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMaterialiv(uint face, uint pname, int[] someParams);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetPolygonStipple(byte[] mask);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glPolygonStipple(byte[] mask);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexEnvfv(uint target, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexEnviv(uint target, uint pname, out int someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexEnvfv(uint target, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexEnviv(uint target, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexEnvfv(uint target, uint pname,  float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexEnviv(uint target, uint pname,  int[] someParams);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGendv(uint coord, uint pname, out double someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGenfv(uint coord, uint pname, out float someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGeniv(uint coord, uint pname, out int someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGendv(uint coord, uint pname, double[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGenfv(uint coord, uint pname, float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetTexGeniv(uint coord, uint pname, int[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexGendv(uint coord, uint pname,  double[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexGenfv(uint coord, uint pname,  float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexGeniv(uint coord, uint pname,  int[] someParams);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexdv(double[] c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexfv(float[] c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexiv(int[] c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexsv(short[] c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexubv(byte[] c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexdv(ref double c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexfv(ref float c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexiv(ref int c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexsv(ref short c);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexubv(ref byte c);
		
		// MAP
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMapdv(uint target, uint query, double[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMapfv(uint target, uint query, float[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetMapiv(uint target, uint query, int[] v);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMap1d(uint target, double u1, double u2, int stride, int order,  double[] points);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMap1f(uint target, float u1, float u2, int stride, int order,  float[] points);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double[] points);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder,  float[] points);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glPixelMapfv(uint map, int mapsize,  float[] values);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glPixelMapuiv(uint map, int mapsize,  uint[] values);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glPixelMapusv(uint map, int mapsize,  ushort[] values);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetPixelMapfv(uint map, float[] values);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetPixelMapuiv(uint map, uint[] values);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetPixelMapusv(uint map, ushort[] values);

		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRectdv(double[] v1, double[] v2);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRectfv(float[] v1, float[] v2);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRectiv(int[] v1, int[] v2);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glRectsv(short[] v1, short[] v2);
		
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexParameterfv(uint target, uint pname,  float[] someParams);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexParameteriv(uint target, uint pname,  int[] someParams);
	
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColorPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glColorPointer(int size, uint type, int stride, float[,] pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glEdgeFlagPointer(int stride,  IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glIndexPointer(uint type, int stride, IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glNormalPointer(uint type, int stride,  IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glTexCoordPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertexPointer(int size, uint type, int stride, IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glVertexPointer(int size, uint type, int stride, float[,] pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glInterleavedArrays(uint format, int stride,  IntPtr pointer);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawElements(uint mode, int count, uint type, IntPtr indices);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glDrawElements(uint mode, int count, uint type, byte[,] indices);
		[DllImport(OPENGL_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void glGetPointerv(uint pname, out IntPtr someParams);

		// -----------------------
		// GLU
		// -----------------------
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public new static extern string gluErrorString(uint error);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public new static extern string gluGetString(uint name);
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPickMatrix(double x, double y, double delX, double delY, int[] viewport);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluScaleImage(uint format, int wIn, int hIn, uint typeIn, IntPtr dataIn, int wOut, int hOut, uint typeOut, IntPtr dataOut);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluScaleImage(uint format, int wIn, int hIn, uint typeIn, IntPtr dataIn, int wOut, int hOut, uint typeOut, byte[] dataOut);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluScaleImage(uint format, int wIn, int hIn, uint typeIn, byte[] dataIn, int wOut, int hOut, uint typeOut, IntPtr dataOut);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluScaleImage(uint format, int wIn, int hIn, uint typeIn, byte[] dataIn, int wOut, int hOut, uint typeOut, byte[] dataOut);
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluProject(double objX, double objY, double objZ, double[] model, double[] proj, int[] view, out double winX, out double winY, out double winZ);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluUnProject(double winX, double winY, double winZ, double[] model, double[] proj, int[] view, out double objX, out double objY, out double objZ);
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild1DMipmaps(uint target, int component, int width, uint format, uint type, IntPtr data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild2DMipmaps(uint target, int component, int width, int height, uint format, uint type, IntPtr data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild2DMipmaps(uint target, int component, int width, int height, uint format, uint type, byte[] data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern int gluBuild2DMipmaps(uint target, int component, int width, int height, uint format, uint type, int[] data);
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluLoadSamplingMatrices(GLUnurbs nurb, float[] model, float[] perspective, int[] view);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsCurve(GLUnurbs nurb, int knotCount, float[] knots, int stride, float[] control, int order, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluNurbsSurface(GLUnurbs nurb, int sKnotCount, float[] sKnots, int tKnotCount, float[] tKnots, int sStride, int tStride, float[] control, int sOrder, int tOrder, uint type);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluGetNurbsProperty(GLUnurbs nurb, uint property, float[] data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluPwlCurve(GLUnurbs nurb, int count, float[] data, int stride, uint type);
		
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessBeginPolygon(GLUtesselator tess, IntPtr data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessVertex(GLUtesselator tess, double[] location, IntPtr data);
		[DllImport(GLU_LIB, CallingConvention=CallingConvention.Winapi)]
		public static extern void gluTessVertex(GLUtesselator tess, IntPtr location, IntPtr data);
	}
}
