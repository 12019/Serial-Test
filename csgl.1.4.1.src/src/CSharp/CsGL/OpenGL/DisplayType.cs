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
using System.Text;
using System.Threading;
using System.Runtime.InteropServices;

namespace CsGL.OpenGL
{
	/**
	 * a class to describe some flag of the OpenGL surface.
	 */
	[Serializable]
	[Flags]
	public enum DisplayFlags : int
	{
		DOUBLEBUFFER    = 0x0001,
		STEREO          = 0x0002,
		DRAW_TO_WINDOW  = 0x0004,
		DRAW_TO_BITMAP  = 0x0008,
		SUPPORT_GDI     = 0x0010,
	}
	
	// this structure is also use in C code
	// defined in csgl_opengl.h file
	/**
	 * This class describe in platform independant way the 
	 * pixel format of the OpenGL view. use to set it at init
	 * time or to get its desciption later on.
	 */
	[Serializable]
    [StructLayout(LayoutKind.Sequential)]
	public struct DisplayType
	{
		public DisplayFlags   flags;
		
		/** specify if you will use RGBA or color-indexed mode */
		public bool isRgba;
		
		/** specify the color depth */
		public  byte cColorBits; 
		
		/** specify the red depth */
		public  byte cRedBits; 
		
		/** specify the green depth */
		public  byte cGreenBits; 
		
		/** specify the blue depth */
		public  byte cBlueBits; 
		
		/** specify the alpha depth */
		public  byte cAlphaBits; 
		
		/** specify the accumulation buffer size */
		public  byte cAccumBits; 
		
		/** specify the number of red bit in accumulation buffer */
		public  byte cAccumRedBits; 
		
		/** specify the number of green bit in accumulation buffer */
		public  byte cAccumGreenBits; 
		
		/** specify the number of blue bit in accumulation buffer */
		public  byte cAccumBlueBits; 
		
		/** specify the number of alpha bit in accumulation buffer */
		public  byte cAccumAlphaBits; 
		
		/** specify the number of bit of the z buffer */
		public  byte cDepthBits; 
		
		/** specify the number of bit of the stencil buffer */
		public  byte cStencilBits; 
		
		
		public DisplayType(byte aCDepth, byte aZDepth) 
			: this(aCDepth, aZDepth, 0, 0)
		{
		}
		            
		public DisplayType(byte aCDepth, byte aZDepth, 
		                   byte aStencilDepth, byte anAccumDepth)
		{
			this = new DisplayType();
			
			flags = DisplayFlags.DOUBLEBUFFER|DisplayFlags.DRAW_TO_WINDOW;
			isRgba = true;
			cColorBits = aCDepth;
			cAccumBits = anAccumDepth;
			cDepthBits = aZDepth;
			cStencilBits = aStencilDepth;
		}
		
		public DisplayType(DisplayFlags someFlags, bool IsRGB)
			: this(someFlags, IsRGB, 0, 0, 0, 0)
		{
		}
		public DisplayType(DisplayFlags someFlags, bool IsRGB,
		                   byte aCDepth, byte aZDepth,
		                   byte aStencilDepth, byte anAccumDepth)
		{
			// init all to 0
			this = new DisplayType();
			
			flags = someFlags;
			isRgba = IsRGB;
			cColorBits = aCDepth;
			cAccumBits = anAccumDepth;
			cDepthBits = aZDepth;
			cStencilBits = aStencilDepth;
		}

		public static string ToString(DisplayFlags flags)
		{
			StringBuilder sb = new StringBuilder();
			int i=0;
			if((flags&DisplayFlags.DOUBLEBUFFER) != 0) {
				i++;
				sb.Append("DOUBLEBUFFER");
			}
			if((flags&DisplayFlags.STEREO) != 0) {
				if(i!=0) sb.Append("|");
				i++;
				sb.Append("STEREO");
			}
			if((flags&DisplayFlags.DRAW_TO_WINDOW) != 0) {
				if(i!=0) sb.Append("|");
				i++;
				sb.Append("DRAW_TO_WINDOW");
			}
			if((flags&DisplayFlags.DRAW_TO_BITMAP) != 0) {
				if(i!=0) sb.Append("|");
				i++;
				sb.Append("DRAW_TO_BITMAP");
			}
			if((flags&DisplayFlags.SUPPORT_GDI) != 0) {
				if(i!=0) sb.Append("|");
				i++;
				sb.Append("SUPPORT_GDI");
			}
			return sb.ToString();
		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.Append("DisplayType\n{");
			sb.AppendFormat("\tflags           : {0}\n", ToString(flags));
			sb.AppendFormat("\tisRgba          : {0}\n", isRgba);
			sb.AppendFormat("\tcColorBits      : {0}\n", cColorBits);
			sb.AppendFormat("\tcRedBits        : {0}\n", cRedBits);
			sb.AppendFormat("\tcGreenBits      : {0}\n", cGreenBits);
			sb.AppendFormat("\tcBlueBits       : {0}\n", cBlueBits);
			sb.AppendFormat("\tcAlphaBits      : {0}\n", cAlphaBits);
			sb.AppendFormat("\tcAccumBits      : {0}\n", cAccumBits);
			sb.AppendFormat("\tcAccumRedBits   : {0}\n", cAccumRedBits);
			sb.AppendFormat("\tcAccumGreenBits : {0}\n", cAccumGreenBits);
			sb.AppendFormat("\tcAccumBlueBits  : {0}\n", cAccumBlueBits);
			sb.AppendFormat("\tcAccumAlphaBits : {0}\n", cAccumAlphaBits);
			sb.AppendFormat("\tcDepthBits      : {0}\n", cDepthBits);
			sb.AppendFormat("\tcStencilBits    : {0}\n", cStencilBits);
			sb.Append("}");
			return sb.ToString();
		}
		
		/**
		 * calculate the score of this display type (that mean
		 * if it has a lot of feature or not), the higher, the more feature.
		 * It return -1 if this display doesn't met the requirement, 
		 * a positive 'score' otherwise.
		 */
		public int GetScore(DisplayType requirement)
		{
			int score = 0;
			
			if(isRgba != requirement.isRgba)
				return -1;
			
			if((flags&requirement.flags) != requirement.flags)
				return -1;

			for(int i=0; i<32; i++)
				if(( ((int)flags) & (1<<i) ) != 0)
					score ++;

			if(cColorBits < requirement.cColorBits)
				return -1;
			score += cColorBits;
			if(cRedBits < requirement.cRedBits)
				return -1;
			score += cRedBits;
			if(cGreenBits < requirement.cGreenBits)
				return -1;
			score += cGreenBits;
			if(cBlueBits < requirement.cBlueBits)
				return -1;
			score += cBlueBits;
			if(cAlphaBits < requirement.cAlphaBits)
				return -1;
			score += cAlphaBits;
			if(cAccumBits < requirement.cAccumBits)
				return -1;
			score += cAccumBits;
			if(cAccumRedBits < requirement.cAccumRedBits)
				return -1;
			score += cAccumRedBits;
			if(cAccumRedBits < requirement.cAccumRedBits)
				return -1;
			score += cAccumRedBits;
			if(cAccumGreenBits < requirement.cAccumGreenBits)
				return -1;
			score += cAccumGreenBits;
			if(cAccumBlueBits < requirement.cAccumBlueBits)
				return -1;
			score += cAccumBlueBits;
			if(cAccumAlphaBits < requirement.cAccumAlphaBits)
				return -1;
			score += cAccumAlphaBits;
			if(cDepthBits < requirement.cDepthBits)
				return -1;
			score += cDepthBits;
			if(cStencilBits < requirement.cStencilBits)
				return -1;
			score += cStencilBits;
			
			return score;
		}
	}
}
