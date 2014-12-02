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
using System.Runtime.Serialization;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;

namespace CsGL.OpenGL
{
	/// <summary>
	/// So how work font object ? it pregenerate your 3D representation of 
	/// your character in a display list, rendering them with glCallLists()
	/// function. Unfortunately C# char are unicode with 65536 possible value.
	/// too much object for memory so you should define a range of predefined 
	/// object when allocating such object. when writting a string, it would
	/// be your responsability to be sure than any char is in the proper range.
	/// There is still work to do when mixing latin char to japanese one...
	/// <P>There is an interesting object <B>GDITextureFont</B> which
	/// is not abstract and create OpenGL font from System.Drawing.Font for
	/// you</P>
    /// <seealso cref="OpenGLFont.InitRange"/>
    /// <seealso cref="GDITextureFont"/>
	/// </summary>
	[Serializable]
	public abstract class OpenGLFont : DisplayList
	{
		char first, last;
		
		public OpenGLFont(char aFirst, char aLast) : base(0x10000)
		{
			first = aFirst;
			last  = aLast;
		}
		public OpenGLFont() : this((char)0x20, (char) 0xFF)
		{
		}
		
		/// <summary>
		/// set the OpenGL coordinate system to 2D (no depth test, Z between -1, 1)
        /// and X-Y coordinate bound to (0,0) - (width, height) 
		/// </summary>
		public virtual void Push3DTo2D()
		{
			glMatrixMode( GL_PROJECTION );
			glPushMatrix();
			
			int[] viewport = new int[4];
			glGetIntegerv(GL_VIEWPORT, viewport);
			glLoadIdentity();
			glOrtho(0, viewport[2], 0, viewport[3], -1, 1);
			
			glMatrixMode(GL_MODELVIEW);
			glPushMatrix();
			
			glLoadIdentity();
			
			glPushAttrib(GL_DEPTH_BUFFER_BIT);
			glDisable(GL_DEPTH_TEST);
		}
		/// <summary>
		/// restore original coordinate system after a call to <code>Push3DTo2D()</code>
		/// </summary>
		public virtual void Pop2DTo3D()
		{
			glPopAttrib();
		    glMatrixMode( GL_MODELVIEW );
			glPopMatrix();
		    glMatrixMode( GL_PROJECTION );
			glPopMatrix();
		    glMatrixMode( GL_MODELVIEW );
		}

		/// <summary>
		/// draw a string at the given position in pixel (control) coordinate
		/// </summary>
		public virtual void Draw2DString(string s, int x, int y)
		{
			Push3DTo2D();
			try 
			{
				glTranslated(x,y,0);
				DrawString(s);
			}
			finally { Pop2DTo3D(); }
		}
		
		/// <summary>
		/// draw a string at the current origin
		/// </summary>
		public virtual void DrawString(string s)
		{
			glPushMatrix();		// store current origin
			glListBase(Base);	// Choose The Font Set (0 or 1)
			glCallLists(s.Length,GL_UNSIGNED_SHORT,s);		// Write The Text To The Screen
			glPopMatrix(); // restore previous camera
		}
		
		protected override object New() 
		{
			uint list = (uint) base.New();
			try { InitRange(list, first, last); }
			catch 
			{
				glDeleteLists(list, 0x10000);
				throw;
			}
			return list;
		}
		
		public override void GetObjectData(SerializationInfo info, 
		                                  StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("first", first);
			info.AddValue("last", last);
		}
		
		protected OpenGLFont(SerializationInfo info, 
		                      StreamingContext context)
		                      : base(info, context)
		{
			first = (char) info.GetInt16("first");
			last  = (char) info.GetInt16("last");
		}
		
		/// <summary>
		/// Here you init a range of character. Obviously you should
		/// call this method to initialize range of character before 
		/// using DrawString
		/// </summary>
		/// <param name="font_base"> 
		/// the base of the OpenGLFont's display list.
		/// </param>
		protected abstract void InitRange(uint font_base, char first, char last);
	}
}
