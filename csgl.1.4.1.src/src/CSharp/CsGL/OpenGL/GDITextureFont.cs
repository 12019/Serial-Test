/*
 * BSD Licence:
 * Copyright (c) 2001, Lloyd Dupont (lloyd@galador.net),
 * The CsGL Development Team
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
 * 3. Neither the name of the The CsGL Development Team nor the names of its 
 * contributors may be used to endorse or promote products derived from this 
 * software without specific prior written permission.
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
	[Serializable]
	/**
	 * Create a 3D font from a System.Drawing.Font object. For this
	 * it generate on the fly a texture with the desired list of
	 * character and generate a display list whose character number should
	 * display the related part of the texture. <br>
	 * This font could be writte at any point in the space with
	 * any current projection, it's a simple way to do simple task
	 * with a strings<br>
	 * You could choose is color with a call to glColorXX()
	 * <p>
	 * It could be a good idea to draw string with this font as you do
	 * for transparent object. That is, if you follow OpenGL red book advice,
	 * on a second pass, with all transparent object and with the depth buffer
	 * in read-only mode with: <b>glDepthMask(</b><i>GL_FALSE</i><b>)</b>
	 * <p>
	 * Anyway, ultimately, to make some nice 3D font effect, you should 
	 * draw to a picture and use the picture as a texture.
	 */
	public class GDITextureFont : OpenGLFont
	{
		OpenGLTexture2D texture;

		// font info
		char[] displayed;
		float fwidth, fheight;
		float[] cwidth;
		float[] offset;
		
		/** return the texture used to display char.<br>
		 * It's generated on the fly to fit whatever Font and chars 
		 * you ask for.
		 */
		public OpenGLTexture2D Texture { get { return texture; } }
		
		public override void GetObjectData(SerializationInfo info, 
		                                  StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("texture",   texture);
			info.AddValue("displayed", displayed);
			info.AddValue("cwidth",    cwidth);
			info.AddValue("offset",    offset);
			info.AddValue("fwidth",    fwidth);
			info.AddValue("fheight",   fheight);
		}
		protected GDITextureFont(SerializationInfo info, 
		                      StreamingContext context)
		                      : base(info, context)
		{
			texture   = (OpenGLTexture2D) info.GetValue("texture", typeof(OpenGLTexture2D));
			displayed = (char[])          info.GetValue("displayed", typeof(char[]));
			cwidth    = (float[])         info.GetValue("cwidth", typeof(float[]));
			offset    = (float[])         info.GetValue("offset", typeof(float[]));
			fwidth    = (float)           info.GetDouble("fwidth");
			fheight   = (float)           info.GetInt16("fheight");
		}
		
		/** Initialise an OpenGLFont with the char from  32 to 256 
		 * (ASCII &amp; latin) */
		public GDITextureFont(Font f) : this(f, carray((char)0x20, (char)0x100))
		{
		}
		/** Initialize an OpenGLFont to display a given range of chars */
		public GDITextureFont(Font f, char first, char last) : this(f, carray(first, last))
		{
		}
		/** Initialize an OpenGLFont to display some characters */
		public GDITextureFont(Font f, char[] c) : base((char) 0, (char) 0)
		{
			if(f == null || c == null)
				throw new NullReferenceException();
			displayed = c;
			specialchar(c); // remove annoyous char...
			CreateTexture(f);
		}
		
		public override void Dispose()
		{
			base.Dispose();
			texture.Dispose();
		}
		public override void Dispose(OpenGLContext ctxt)
		{
			base.Dispose(ctxt);
			texture.Dispose(ctxt);
		}
		
		internal static void specialchar(char[] tab)
		{
			char[] spec = new char[] {(char) 0,'\t','\n','\b','\r','\a','\f','\v'};
			int i, j;
			for(i=0; i<tab.Length; i++)
            	for(j=0; j<spec.Length; j++)
					if(spec[j] == tab[i])
						tab[i] = ' ';
		}
		private static char[] carray(char first, char last)
		{
			// create the string array
			int n = last - first + 1;
			char[] c = new char[n];
			int i,j;
			for(i=0,j=first; i<n; i++,j++)
				c[i] = (char) j;
			return c;
		}

		/** return the height of the font */
		public float Height { get { return fheight; } }
		
		/** return the size of a char. 
		 * @param offset the relative start position of the character 
		 * for GDI drawing
		 **/
		public SizeF CharSize(char c, out float offset)
		{
			for(int i=0; i<displayed.Length; i++)
				if(displayed[i]==c)
					return CharSize(i, out offset);
			throw new ArgumentException("no such char '"+c+'\'');
		}
		/** return the size of a char. <br>
		 * The index is in the array of required chars
		 * @param anOffset the relative start position of the character 
		 * for GDI drawing
		 */
		public SizeF CharSize(int index, out float anOffset)
		{
			anOffset = offset[index];
			return new SizeF(cwidth[index], fheight);
		}
		
		/// <summary>
		/// prepare a texture Image from the font
		/// </summary>
		private void CreateTexture(Font font)
		{
			// create the string array
			int i,n = displayed.Length;
			cwidth = new float[n];
			int nx = (int) Math.Sqrt(n);
			
			// get font info
			Bitmap img = new Bitmap(10, 10, PixelFormat.Format32bppArgb);
			Graphics g = Graphics.FromImage(img);
			fwidth = 0;
			fheight = font.Height+1;
			offset = new float[n]; // sorry, GDI is so boring ... :-(
			for(i=0; i<n; i++) {
				cwidth[i] = CharWidth(g, font, displayed[i], out offset[i]);
				if(cwidth[i] > fwidth)
					fwidth = cwidth[i];
			}
			g.Dispose();
			img.Dispose();
			
			int w = (int) Math.Ceiling(fwidth);
			int h = (int) Math.Ceiling(fheight);
			int ny = n / nx + (n%nx == 0 ? 0 : 1);

			// creating the texture
			// use a Square... so texture coordinate are more accurate
			// and char better drawn...
			float W = OpenGLTexture2D.power_of_two(nx * w);
			float H = OpenGLTexture2D.power_of_two(ny * h);
			img = new Bitmap((int)W, (int)H, PixelFormat.Format32bppArgb);
			g = Graphics.FromImage(img);
		    SolidBrush brush = new SolidBrush(Color.White);
			for(i=0; i<n; i++)
				g.DrawString(new String(displayed[i], 1), 
				             font, 
				             brush, 
				             // don't forget, OpenGL yAxis is bottom to top
				             new PointF((i % nx) * w - offset[i], H - (i / nx) * h - h));
			brush.Dispose();
			g.Dispose();
			
			texture = new OpenGLTexture2D(img, 
			                              OpenGLTexture2D.Tex2DType.SIMPLE, 
			                              false);
		}
		/** return the char width, if paint with this graphic object. offset
		 * is the (relative position) to your x-position at which it will be 
		 * drawn */
		public static float CharWidth(Graphics g, Font font, char c, out float offset)
		{
			if(c==' ') {
				offset = 0;
				return 0.8f * g.MeasureString(new String(c, 1), font).Width;
			}
			float f = g.MeasureString(new String(c, 100), font).Width/100;
			offset = (g.MeasureString(new String(c, 1), font).Width-f)/2;
			return f;
		}
		
		/// <summary>
		/// simply call personnal InitRange(font_base, char[])
		/// </summary>
		protected override void InitRange(uint font_base, char first, char last)
		{
			InitRange(font_base, displayed);
		}
		
		/// <summary>
		/// set the display list from the texture
		/// </summary>
		protected virtual void InitRange(uint font_base, char[] c)
		{
			// get font info
			int   i,n = c.Length;
			int   nx  = (int) Math.Sqrt(n);
			int   w   = (int) Math.Ceiling(fwidth);
			int   h   = (int) Math.Ceiling(fheight);
			int   ny  = n / nx + (n%nx == 0 ? 0 : 1);
			float W   = OpenGLTexture2D.power_of_two(nx * w);
			float H   = OpenGLTexture2D.power_of_two(ny * h);

			// generate GL textured characters...
			float w2, tw;
			uint  tid = texture.ID;
			float dv = h/H;
			for (i=0; i<n; i++)
			{
				float u = ((i % nx) * w) / W;
				float v = ((i / nx) * h) / H;
				u -= offset[i]/W;
				w2 = cwidth[i];
				float w0 = -offset[i];
				tw = w2/W;
				tw += 2*offset[i]/W;
				glNewList((uint)(font_base+displayed[i]), GL_COMPILE);
					glBegin(GL_QUADS);
						glTexCoord2f(u , v);
						glVertex2f(w0, 0);
				
						glTexCoord2f(u + tw, v);
						glVertex2f(w2+offset[i],0);
				
						glTexCoord2f(u + tw, v + dv);
						glVertex2f(w2+offset[i],h);
				
						glTexCoord2f(u, v + dv);
						glVertex2f(w0, h);
					glEnd();
					glTranslatef(w2,0,0);
				glEndList();
			}
		}

		/** 
		 * save the current state and update it so font could work
		 **/		
		protected virtual void Push()
		{
			// save modifed data
			glPushAttrib(GL_COLOR_BUFFER_BIT|GL_ENABLE_BIT|GL_DEPTH_BUFFER_BIT);
			glPushMatrix();
			
			// bind the 'font' texture
			glEnable(GL_TEXTURE_2D);
			glBindTexture(GL_TEXTURE_2D, Base);
			
			// enable blending (remove font background)
			glEnable(GL_BLEND);
			glBlendFunc(GL_SRC_ALPHA, GL_ONE);
			
			// transparent drawing
			glDepthMask((byte) GL_FALSE);
		}
		/** restore initial state */
		protected virtual void Pop()
		{
			glPopMatrix();
			glPopAttrib();
			glBindTexture(GL_TEXTURE_2D, 0);
		}
		/** draw a string at the current origin. with a call to glCallLists. */
		public override void DrawString(string s)
		{
			Push();
			glListBase(Base);
			glCallLists(s.Length,GL_UNSIGNED_SHORT,s);
			Pop();
			OpenGLException.Assert();
		}
	}
}
