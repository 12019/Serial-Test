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
 
// should CsGL lookup for best PixelFormat itself,
// or leave it to OpenGL driver ?
// #define SOFTWARE_SEARCH

using System;
using System.Collections;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;

namespace CsGL.OpenGL
{
	/**
	* Though multiplatform, OpenGL has a critical, platform dependant,
	* underlying handle,
	* called the "OpenGL context" which hold any drawing information.
	* It also set your OpenGL capacity (in regards to stencil buffer, 
	* number of color, etc..) at its initialisation time.
	* <p>
	* Any OpenGL command you issue will be excecuted in the current 
	* context or will do nothing if there is no current context. There
	* is only one current context in each thread (a new context 
	* replacing the old one), and a context could be current in only one
	* thread at a time.. 
	* <p>
	* These objects are not functionnal until Create has been called
	* on them.
	* 
	* @see Create
	*/
	public abstract unsafe class OpenGLContext : GL, IDisposable
	{
		// pixel format
		[DllImport(CSGL, EntryPoint="csgl_opengl_getPixelFormat", CallingConvention=CallingConvention.Cdecl)]
		public static extern int GetCurrentPixelFormat(IntPtr gdi);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_getNumFormat", CallingConvention=CallingConvention.Cdecl)]
		public static extern int GetNumPixelFormat(IntPtr gdi);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_getDisplayFromFormat", CallingConvention=CallingConvention.Cdecl)]
		public static extern void GetPixelFormat(IntPtr gdi, int index, out DisplayType setting);
		
		public int NumPixelFormats
		{ 
			get {
				IntPtr gdi = GetNativeGDI();
				try { return GetNumPixelFormat(gdi); }
				finally { ReleaseNativeGDI(gdi); }
			}
		}
		public DisplayType GetPixelFormat(int index)
		{
			IntPtr gdi = GetNativeGDI();
			try { 
				DisplayType ret;
				GetPixelFormat(gdi, index, out ret);
				return ret;
			}
			finally { ReleaseNativeGDI(gdi); }
		}
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_setPixelFormat", CallingConvention=CallingConvention.Cdecl)]
		private static extern void SetPixelFormat(IntPtr gdi, int format);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_setPixelFormatD", CallingConvention=CallingConvention.Cdecl)]
		private static extern void SetPixelFormat(IntPtr gdi, ref DisplayType format);
		
		// GL context
		[DllImport(CSGL, EntryPoint="csgl_opengl_getCurrentCtxt", CallingConvention=CallingConvention.Cdecl)]
		private static extern IntPtr GetCurrentContext();
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_createCtxt", CallingConvention=CallingConvention.Cdecl)]
		private static extern IntPtr CreateContext(IntPtr gdi, IntPtr shareList);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_deleteCtxt", CallingConvention=CallingConvention.Cdecl)]
		private static extern void DeleteContext(IntPtr glctxt);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_grabCtxt", CallingConvention=CallingConvention.Cdecl)]
		private static extern void GrabContext(IntPtr gdi, IntPtr glctxt);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_dropCtxt", CallingConvention=CallingConvention.Cdecl)]
		private static extern void DropContext(IntPtr glctxt);
		
		[DllImport(CSGL, EntryPoint="csgl_opengl_swapBuffer", CallingConvention=CallingConvention.Cdecl)]
		private static extern void SwapContextBuffer(IntPtr gdi, IntPtr glctxt);
		
		// --------------------------------------------------
		private IntPtr hglrc;
		private Palette palette;
		// the list of all context sharing display list together with this one
		private Hashtable sharePool; 
		// for context local storage...
		// this table is shared by context sharing list
		private Hashtable locals;
		
		public IntPtr  Handle { get { return hglrc; } }
		public Palette Palette { get { return palette; } }
		
		/** return a window HDC (yes, HDC, not GDI. maybe an unwise name choice) */
		public abstract IntPtr GetNativeGDI();
		public abstract void ReleaseNativeGDI(IntPtr p);
		/**
		 * create a native OpenGL context.<br>
		 * It's an error to call this method on a context already created,
		 * call recreate instead...
		 * @param display the desired pixel format
		 * @param toShare an other context with whom share display list. 
		 * could be null
		 */
		public virtual void Create(DisplayType display, OpenGLContext toShare)
		{
			if(hglrc!=IntPtr.Zero)
				throw new InvalidOperationException("Already Created..");
			IntPtr gdi = GetNativeGDI();
			try
			{
				SetPixelFormat(gdi, ref display);
				initHGLRC(gdi, toShare);
			}
			finally { ReleaseNativeGDI(gdi); }
		}
		/**
		 * create a native OpenGL context with a given PixelFormat.<br>
		 * It's an error to call this method on a context already created,
		 * call recreate instead...
		 * @param display the required pixel format
		 * @param toShare an other context with whom share display list. 
		 * could be null
		 */
		public virtual void Create(int display, OpenGLContext toShare)
		{
			if(hglrc!=IntPtr.Zero)
				throw new InvalidOperationException("Already Created..");
			IntPtr gdi = GetNativeGDI();
			try
			{
				SetPixelFormat(gdi, display);
				initHGLRC(gdi, toShare);
			}
			finally { ReleaseNativeGDI(gdi); }
		}
		private void initHGLRC(IntPtr gdi, OpenGLContext toShare)
		{
			DisplayType dt;
			GetPixelFormat(gdi, GetCurrentPixelFormat(gdi), out dt);
			Setting = dt;
			if(!Setting.isRgba) {
				int nColor;
				IntPtr p = Palette.csgl_palette_createPalette(ref dt, gdi, out nColor);
				if(p != IntPtr.Zero)
					palette = CreatePalette(p, nColor);
			}
			
			hglrc = CreateContext(gdi, toShare==null ? IntPtr.Zero : toShare.Handle);
			all[hglrc] = this;
			
			if(toShare==null) {
				sharePool = new Hashtable();
				locals = new Hashtable();
			}
			else {
				sharePool = toShare.sharePool;
				locals = toShare.locals;
			}
			sharePool[this] = this;
		}
		
		/** create and return a CsGL palette from a native palette */
		protected virtual Palette CreatePalette(IntPtr pal, int size)
		{
			return new Palette(pal, size, this);
		}
		
		/** swap buffer if the context is multi-bufferred */
		public void SwapBuffer()
		{
			if(hglrc==IntPtr.Zero)
				throw new OpenGLException("OpenGLContext not Valid");
			if((Setting.flags&DisplayFlags.DOUBLEBUFFER)==0)
				return;
			IntPtr gdi = GetNativeGDI();
			try { SwapContextBuffer(gdi, hglrc); }
			finally { ReleaseNativeGDI(gdi); }
		}
		
		/** make this context the current one */
		public void Grab()
		{
			if(hglrc==IntPtr.Zero)
				throw new OpenGLException("OpenGLContext not Valid");
			IntPtr gdi = GetNativeGDI();
			try { GrabContext(gdi, hglrc); }
			finally { ReleaseNativeGDI(gdi); }
		}
		
		/** prevent this context from being the current one.
		 * This method has a performance cost. call it only when necessary.
		 */
		public void Drop()
		{
			if(hglrc==IntPtr.Zero)
				return;
			DropContext(hglrc);
		}
		
		/**
		 * All OpenGLContext present in the application
		 */
		public static ICollection AllContext
		{
			get { return all.Values; }
		}
		/** the list of OpenGLContext sharing display list with this one */
		public ICollection SharingContext
		{
			get { return sharePool.Keys; }
		}
		
		~OpenGLContext() { Dispose(); }
		public virtual void Dispose()
		{
			IntPtr p = hglrc;
			if(p==IntPtr.Zero) // don't dispose twice...
				return;
			try
			{
				GC.SuppressFinalize(this);
				Drop();
				DeleteContext(hglrc);
				hglrc = IntPtr.Zero;
				
				if(palette!=null)
					palette.Dispose();
			}
			finally 
			{ 
				all.Remove(p);
				sharePool.Remove(this);
			}
		}
		
		public virtual bool Valid 
		{ 
			get { return hglrc != IntPtr.Zero; } 
		}
		
		private static Hashtable all = new Hashtable();
		public static OpenGLContext Current
		{
			get {
				IntPtr p = GetCurrentContext();
				if(p == IntPtr.Zero)
					return null;
				return (OpenGLContext) all[p];
			}
			set 
			{ 
				if(value == null) {
					OpenGLContext current = Current;
					if(current != null)
						current.Drop();
				}
				else
					value.Grab();
			}
		}
		public virtual bool IsCurrent
		{
			set {
				if(value)
					Grab();
				else
					Drop();
			}
			get { return this == Current; }
		}
		
		public virtual Bitmap ToImage()
		{
			Grab();
			
			int[] b = new int[16];
			glGetIntegerv(GL_VIEWPORT, b);
			if(b[2]<1 || b[3]<1)
				return null;
			
			Bitmap img = new Bitmap(b[2], b[3], System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			BitmapData tex;
			Rectangle rect = new Rectangle(0, 0, b[2], b[3]);
			tex = img.LockBits(rect, ImageLockMode.ReadWrite, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
			glReadPixels(0, 0, b[2], b[3], GL_BGR_EXT, GL_UNSIGNED_BYTE, tex.Scan0);
			
			img.UnlockBits(tex);
			img.RotateFlip(RotateFlipType.RotateNoneFlipY);
			
			OpenGLException.Assert();
			return img;
		}

		/** store a value in a table local to this context and those
		 * who share display list with it */
		public void Set(object key, object val)  
		{ 
			if(val==null)
				locals.Remove(key);
			else
				locals[key] = val;
		}
		/** retrive a value in a table local to this context and those
		 * who share display list with it */
		public object Get(object key) { return locals[key]; }
		
		/** return the PixelFormat of the underlying control/image */
		public DisplayType PixelFormat {get{ return Setting; }}
		public int PixelFormatIndex
		{
			get {
				IntPtr gdi = GetNativeGDI();
				try { return GetCurrentPixelFormat(gdi); }
				finally { ReleaseNativeGDI(gdi); }
			}
		}
		
		// store like this to provoke an error if asked when no PixelFormat is set
		private object setting;
		private DisplayType Setting
		{
			get { return (DisplayType) setting; }
			set { setting = value; }
		}
	}
}
