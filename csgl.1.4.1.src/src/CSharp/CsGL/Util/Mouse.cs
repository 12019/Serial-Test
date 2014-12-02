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
using System.Collections;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CsGL.Util
{
	/**
	 * a class to access mouse position from anywhere.
	 * You could also use it to pin the mouse in one position
	 * and just use mouse move delta.<br/>
	 * <p>
	 * It also enable you to create System.Drawing.Cursor object
	 * from a System.Drawing.Bitmap image
	 */
	public class Mouse : CsGL.OSLib
	{
		static Mouse() { CSGLInit(); }
		
		[DllImport(CSGL, EntryPoint="csgl_mouse_setPos", CallingConvention=CallingConvention.Cdecl)]
		public static extern void SetPosition(int x, int y);
		
		[DllImport(CSGL, EntryPoint="csgl_mouse_getPos", CallingConvention=CallingConvention.Cdecl)]
		public static extern void GetPosition(out int x, out int y);
		
		// ------------ HOOK & listener ----------
		public enum EventType : byte
		{
			DOWN  = 0,
			UP    = 1,
			MOVE  = 2,
			/** event generated when the mouse wheel is rolled */
			WHEEL = 3
		}
	    [StructLayout(LayoutKind.Sequential)]
		public struct Event
		{
			/** the type of event */
			public EventType type;
			/** current screen coordinat of the mouse */
			public int x,y; 
			/** if event is UP or DOWN indicate the button. mouse wheel is 3 */
			public int button; 
			/** in case of DOWN event indicate the number of clic */
			public int clicCount;
			/** if event is WHEEL the amount scrolled with mouse wheel */
			public int wheel;
			private IntPtr hwnd;
			
			/** the control target by this keyboard event */
			public Control Control
			{
				get { 
					if(hwnd==IntPtr.Zero)
						return null;
					return Control.FromHandle(hwnd); 
				}
			}
			/** the location of the mouse in targeted control coordinate */
			public Point ControlLocation
			{
				get {
					Control c = Control;
					if(c==null)
						return new Point(x, y);
					Point p = c.PointToScreen(new Point(0, 0));
					p.X -= x;
					p.Y -= y;
					return p;
				}
			}
			
			public override string ToString()
			{
				StringBuilder sb = new StringBuilder();
				sb.Append("Mouse+Event(");
				sb.Append(x);
				sb.Append('x');
				sb.Append(y);
				sb.Append(' ');
				sb.Append(type);
				switch(type) {
					case EventType.DOWN:
						sb.Append('_');
						sb.Append(button);
						sb.Append(' ');
						sb.Append(clicCount);
						break;
					case EventType.UP:
						sb.Append('_');
						sb.Append(button);
						break;
					case EventType.WHEEL:
						sb.Append(' ');
						sb.Append(wheel);
						break;
				}
				sb.Append(')');
				return sb.ToString();
			}
		}
		public delegate void Hook(Event me);
		
		[DllImport(CSGL, CallingConvention=CallingConvention.Cdecl)]
		private static extern void csgl_mouse_hook(Hook hook);
		
		static ArrayList hooks;
		public static void AddListener(Hook fct)
		{
			if(hooks==null) {
				CSGLInit();
				hooks = new ArrayList();
				mouseHook = new Hook(SysHook);
				csgl_mouse_hook(mouseHook);
			}
			hooks.Add(fct);
		}
		public static void RemoveListener(Hook fct) 
		{
			if(hooks!=null)
				hooks.Remove(fct);
		}
		private static Hook mouseHook;
		private static void SysHook(Event e)
		{
			foreach(Hook h in hooks)
				try { h(e); }
				catch(Exception ex) {
					Console.Error.WriteLine(ex);
					Console.Error.WriteLine(ex.StackTrace);
				}
		}
		
		// --------- CURSOR method  ----------
		[DllImport(CsGL.OSLib.CSGL, EntryPoint="csgl_mouse_destroyCursor", CallingConvention=CallingConvention.Cdecl)]
		private static extern void DestroyCursor(IntPtr hCursor);
		[DllImport(CsGL.OSLib.CSGL, EntryPoint="csgl_mouse_createCursor", CallingConvention=CallingConvention.Cdecl)]
		private static extern IntPtr CreateCursor(IntPtr hBitmap, int x, int y);

		/** return the maximum size an image should be to be used as a cursor */		
		[DllImport(CsGL.OSLib.CSGL, EntryPoint="csgl_mouse_getCursorSize", CallingConvention=CallingConvention.Cdecl)]
		public static extern void GetMaximumCursorSize(out int x, out int y);

		/**
		 * This method create a cursor from a bitmap. provided you
		 * furnish with a bitmap of an acceptable system size.
		 * <p>
		 * You should call DestroyCursor(..) on this cursor when 
		 * you no longer need it
		 * @param x the x-coordinate of the hot spot
		 * @param y the y-coordinate of the hot spot
		 */
		public static Cursor CreateCursor(Bitmap img, int x, int y)
		{
			return new Cursor(CreateCursor(img.GetHbitmap(), x, y));
		}
		/**
		 * Destroy a cursor. This method should only be called
		 * on unused cursor created by Mouse.CreateCursor(..).
		 * <br>
		 * I am sorry to not provide a more witty implementation
		 * but Cursor is a sealed class, I can't help.
		 */
		public static void DestroyCursor(Cursor cur) 
		{
			DestroyCursor(cur.Handle);
		}
		
		
		// --------- INSTANCE method ---------
		int lastX, lastY;
		bool warp = false;
		private void spyMouse(Event e)
		{
			if(e.button==-1 && lastX==e.x && lastY==e.y)
				return;
			
			int dx = e.x - lastX;
			int dy = e.y - lastY;
			if(warp) {
				if(dx!=0 && dy!=0) {
					SetPosition(lastX, lastY);
					MouseEvent(e, dx, dy);
				}
				if(dx!=0 || dy!=0 || e.type!=EventType.MOVE)
					MouseEvent(e, dx, dy);
			}
			else {
				lastX = e.x;
				lastY = e.y;
				MouseEvent(e, dx, dy);
			}
		}
		public virtual void MouseEvent(Event e, int dx, int dy)
		{
		}
		public void WarpAt(int x, int y)
		{
			lastX = x;
			lastY = y;
			SetPosition(x, y);
			warp = true;
		}
		public void Unwarp() { warp = false; }
		public Mouse()
		{
			AddListener(new Hook(spyMouse));
			GetPosition(out lastX, out lastY);
		}
		~Mouse() { RemoveListener(new Hook(spyMouse)); }
	}
}
