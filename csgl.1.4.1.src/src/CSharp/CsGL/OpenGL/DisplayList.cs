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
using System.Runtime.Serialization;

namespace CsGL.OpenGL
{
	/// <summary>
	/// This ContextLocal variable manage DisplayList, you init it
	/// with the number of list needed and it automayically allocate for
	/// you a display list in each context. It do it in a lazy way, i.e.
	/// when asked.
	/// </summary>
	[Serializable]
	public class DisplayList : ContextLocal
	{
		private int size;
		
		public DisplayList(int numList) 
		{
			size = numList;
			if(size < 1)
				throw new ArgumentException("num should be strictly positive");
		}
		
		/// <summary>
		/// Get the list base
		/// </summary>
		public uint Base
		{
			get { return (uint) Value; }
		}
		
		/// <summary>
		/// execute the display list
		/// </summary>
		public void Call() { Call(0); }
		/// <summary>
		/// execute the display list with ID = Base + index
		/// </summary>
		public virtual void Call(uint index) 
		{
			glCallList(Base + index);
		}
		
		/// <summary>
		/// Get the number of display list allocated, or 0 if
		/// Disposed.
		/// </summary>
		public int Size
		{
			get { return size; }
		}
		
		/// <summary>do not set</summary>
		public override object Value { set {} }
		
		/// <summary>
		/// free the list
		/// </summary>
		public override void Dispose(OpenGLContext ctxt)
		{
			if(size < 1)
				return;
			ctxt.Grab();
			glDeleteLists(Base, size);
			size = 0;
		}
		
		protected override object New() 
		{
			uint ret = glGenLists(size);
			OpenGLException.Assert();
			return ret;
		}
		
		public override void GetObjectData(SerializationInfo info, 
		                                  StreamingContext context)
		{
			base.GetObjectData(info, context);
			info.AddValue("size", size);
		}
		
		protected DisplayList(SerializationInfo info, 
		                      StreamingContext context)
		                      : base(info, context)
		{
			size = info.GetInt32("size");
		}
	}
}
