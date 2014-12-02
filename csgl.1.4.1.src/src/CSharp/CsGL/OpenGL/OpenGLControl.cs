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
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using CsGL.Util;

namespace CsGL.OpenGL
{
	/**
	* This an example implementation of OpenGLContext as a control.
	* this "an opengl view" which means you could issue OpenGL
	* command in its glDraw() method (called by default OnPaint() implementation).
	* <br>
	* The Context is allocated lazily on demand. Therefore it is not,
	* by default, instanciated in the constructor. If you want to
	* init OpenGL there, call Context.Grab() first.
	* <P>
	* This simple object is not well designed for multithreading. As context
	* could be current in only 1 thread at a time. Yo better design your
	* own widget for multithreaded code.
	*/
	public class OpenGLControl : System.Windows.Forms.Control, IDisposable
	{
		OpenGLContext ctxt;
		
		public OpenGLControl()
		{
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.Opaque, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, false);
		}
		
		/// <summary>
		/// This method is called whenever the ctxt is needed and 
		/// not yet initialized. It return a context which draw 
		/// on the controil and call InitGLContext on it
		/// </summary>
		protected virtual OpenGLContext CreateContext()
		{
			ControlGLContext c = new ControlGLContext(this);
			c.Create(new DisplayType(0,0), null);
			return c;
		}
		/// <summary>
		/// This method destroy the current OpenGLContext. Which would be 
		/// automatically recreated when needed
		/// </summary>
		protected virtual void DisposeContext()
		{
			if(ctxt==null)
				return;
			
			OpenGLContext aCtxt = ctxt;
			ctxt = null;
			aCtxt.Dispose();
		}
		/** just here for backward compatibility. merely dispose the
		 * context */
		public virtual void RecreateContext()
		{
			DisposeContext();
			// ctxt = CreateContext(); // not needed
		}
		
		protected override void Dispose(bool disposing)
		{
			if(disposing && ctxt!=null && ctxt.Valid)
				ctxt.Dispose();
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// return the GL context of this windows. create it if needed.
		/// </summary>
		public OpenGLContext Context 
		{ 
			get 
			{
				if(ctxt==null) {
					ctxt = CreateContext();
					ctxt.Grab();
					InitGLContext();
				}
				return ctxt;
			}
		}
		
		/// <summary>
		/// this method is to be called each time a GL context is created.
		/// for example at the creation of the Control, before printing, etc..
		/// </summary>
		protected virtual void InitGLContext() {}
		
		/// <summary>
		/// call it to SwapBuffer if you are double buffered.
		/// it is also a good idea to do it before doing standart
		/// gdi drawing if you want to use this feature.
		/// </summary>
		protected virtual void SwapBuffer()
		{
			if(ctxt!=null)
				ctxt.SwapBuffer();
		}
		
		/// <summary>
		/// prepare OpenGL for rendering on this window by grabbing context and
		/// call glDraw.
		/// override glDraw to do gl operation.
		/// <p>this method Grab() the control context.
		/// </summary>
		protected override void OnPaint(PaintEventArgs pevent)
		{
			base.OnPaint(pevent);
			Context.Grab();
			glDraw();
			GL.glFinish();
			SwapBuffer();
			OpenGLException.Assert();
		}
		
		/// <summary>
		/// do nothing => avoid flashing. anyway ControlStyles.AllPaintingInWmPaint
		/// is set
		/// </summary>
		protected override void OnPaintBackground(PaintEventArgs pevent)
		{
		}
		
		/// <summary>
		/// the main drawing method. OnPaint prepare context and such stuff.
		/// override this to draw..
		/// </summary>
		public virtual void glDraw() {}
		
		/// <summary>
		/// make this control's OpenGL context the current context for
		/// this thread.
		/// </summary>
		public void GrabContext()
		{
			Context.Grab();
		}
		
		/// <summary>
		/// set glViewport. subclass to set frustrum...
		/// </summary>
		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			
			Size s = Size;
			Context.Grab();
			GL.glViewport(0, 0, s.Width, s.Height);
			Invalidate();
		}
	}
}
