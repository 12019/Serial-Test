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
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;

namespace CsGL.OpenGL
{
	/// <summary>
	/// This is an helper class to load a 2D texture from an image.
	/// It is a quite simple topics, but quite repetitive so here
	/// is an example implementation.
	/// </summary>
	[Serializable]
	public class OpenGLTexture2D : ContextLocal
	{
		public enum Tex2DType : byte
		{
			SIMPLE,
			MIPMAPED,
			BORDERED
		}
		
		public override void GetObjectData(SerializationInfo info, 
		                                  StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("type", (byte) type);
			info.AddValue("image",    image);
		}
		protected OpenGLTexture2D(SerializationInfo info, 
		                      StreamingContext context)
		                      : base(info, context)
		{
			type = (Tex2DType) info.GetByte("type");
			image    = (Bitmap) info.GetValue("image", typeof(Bitmap));
		}
		
		/// <summary>
		/// Init(new Bitmap(file), false, false)
		/// </summary>
		public OpenGLTexture2D(string file) : this(file, Tex2DType.SIMPLE)
		{
		}
		/// <summary>
		/// Init(new Bitmap(file), border, false)
		/// </summary>
		public OpenGLTexture2D(string file, Tex2DType type)
		{
			Init(new Bitmap(file), type, false);
		}
		/// <summary>
		/// Init(new Bitmap(file), false, false)
		/// </summary>
		public OpenGLTexture2D(Stream file) : this(file, Tex2DType.SIMPLE)
		{
		}
		/// <summary>
		/// Init(new Bitmap(file), border, false)
		/// </summary>
		public OpenGLTexture2D(Stream file, Tex2DType type)
		{
			Init(new Bitmap(file), type, false);
		}
		/// <summary>
		/// Init(img, false, true)
		/// </summary>
		public OpenGLTexture2D(Bitmap img) : this(img, Tex2DType.SIMPLE, true)
		{
		}
		/// <summary>
		/// Init(img, border, true)
		/// </summary>
		public OpenGLTexture2D(Bitmap img, Tex2DType type) : this(img, type, true)
		{
		}
		/// <summary>
		/// Init(img, border, copy)
		/// </summary>
		public OpenGLTexture2D(Bitmap img, Tex2DType type, bool copy)
		{
			Init(img, type, copy);
		}
		
		protected Tex2DType type;
		protected Bitmap image;
		
		/// <param name="aType"> 
		/// tell the type of the texture, wether it fill its border, or
		/// not and wether it is mipmaped or not
		/// </param>
		/// <param name="copy"> 
		/// tell wether or not this texture should consider the image
		/// as a private copy it could modify, or not
		/// </param>
		/// <param name="img"> 
		/// the image to be used as a texture
		/// </param>
		protected void Init(Bitmap img, Tex2DType aType, bool copy)
		{
			type  = aType;
			image = copy ? (Bitmap) img.Clone() : img;
			image.RotateFlip(RotateFlipType.RotateNoneFlipY);
							
			// check OpenGL compliant size
			int sx = image.Width - (IsBorder ? 2 : 0);
			int sy = image.Height - (IsBorder ? 2 : 0);
			int sx2 = power_of_two(sx);
			int sy2 = power_of_two(sy);
			
			// stretch it...
			if(sx != sx2 || sy != sy2) {
				if(IsBorder) {
					sx2 += 2;
					sy2 += 2;
				}
				Bitmap img2 = new Bitmap(image, sx2, sy2);
				image.Dispose();
				image = img2;
			}
		}
		
		public bool IsBorder   { get { return type == Tex2DType.BORDERED; } }
		public bool IsMipmaped { get { return type == Tex2DType.MIPMAPED; } }
		
		/// <summary>
		/// utility fct to return the next power of 2 equal or superior
		/// to a given number. as OpenGL texture should have such a size
		/// </summary>
		public static int power_of_two(int input)
		{
			int val = 1;
			
			while(val < input)
				val <<= 1;
			return val;
		}
		
		/// <summary>
		/// create context local texture, and return its id
		/// </summary>
		protected override object New()
		{
			uint[] texture = new uint[1];
			
			BitmapData tex;
			Rectangle rect;
			rect = new Rectangle(0, 0, image.Width, image.Height);
			tex = image.LockBits(rect, ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

			glGenTextures(texture.Length, texture);
			
			glBindTexture(GL_TEXTURE_2D, texture[0]);
			SetParameter();
			if(IsMipmaped)
				gluBuild2DMipmaps(GL_TEXTURE_2D, (int)GL.GL_RGB8, 
				                  image.Width, image.Height, 
				                  GL.GL_BGRA_EXT, GL.GL_UNSIGNED_BYTE, 
				                  tex.Scan0);
			else
				glTexImage2D(GL_TEXTURE_2D, 0, (int)GL_RGB8, 
			                image.Width, image.Height, 
			                IsBorder ? 1 : 0, GL_BGRA_EXT, GL_UNSIGNED_BYTE, 
			                tex.Scan0);
			
			image.UnlockBits(tex);
			
			OpenGLException.Assert();
			return texture;
		}
		
		/// <summary>
		/// called while initializing this texture, just before call to
		/// glTexImage2D/gluTexImage2D to set filter option...
		/// </summary>
		protected virtual void SetParameter()
		{
			glTexParameteri(GL_TEXTURE_2D,GL_TEXTURE_MAG_FILTER,GL_LINEAR);
			glTexParameteri(GL_TEXTURE_2D,GL_TEXTURE_MIN_FILTER,GL_LINEAR);
		}
		
		/// <summary>
		/// return the texture ID
		/// </summary>
		public uint ID { get { return ((uint[]) Value)[0]; } }
		
		/// <summary>
		/// make this texture the current OpenGL 2D texture.
		/// </summary>
		public void Bind() 
		{
			glBindTexture(GL_TEXTURE_2D, ID);
		}
		
		public override void Dispose(OpenGLContext ctxt)
		{
			uint[] tex = (uint[]) Get(ctxt);
			if(tex == null) // already disposed
				return;
			
			ctxt.Grab();
			glDeleteTextures(tex.Length, tex);
			Set(ctxt, null);
		}
	}
}
