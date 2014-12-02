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
	/// This class is usefull to manage OpenGLContext local variable 
	/// such as font, bitmap, ..
	/// </summary>
	[Serializable]
	public class ContextLocal : GL, IDisposable, ISerializable
	{
		public ContextLocal() {}
		~ContextLocal()
		{
			// clean all context
			foreach(OpenGLContext ctxt in OpenGLContext.AllContext)
			{
				if(!ctxt.Valid)
					continue;
				object[] o = (object[]) ctxt.Get(this);
				if(o != null) {
					ctxt.Set(this, null);
					if(o[0] is IDisposable)
						((IDisposable) o[0]).Dispose();
				}
			}
		}
		
		/// <summary>
		/// set and get the current variable local to the current 
		/// context for this thread. The first time the value
		/// is acceded, it is inited with its New() method.
		/// </summary>
		public virtual object Value
		{
			get { return Get(OpenGLContext.Current); }
			set { Set(OpenGLContext.Current, value); }
		}
		
		/**
		* tell wether or not this ContextLocal has already been
		* initialized for current context. allways return false
		* when current context is null. <br>
		* It could be usefull in InitGLContext to test if
		* diplay list as already been initialised in a shared context
		*/
		public virtual bool Inited
		{
			get { 
				OpenGLContext ctxt = OpenGLContext.Current;
				if(ctxt == null)
					return false;
				object[] holder = (object[]) ctxt.Get(this);
				if(holder == null)
					foreach(OpenGLContext c2 in ctxt.SharingContext) {
						holder = (object[]) c2.Get(this);
						if(holder != null) {
							ctxt.Set(this, holder);
							break;
						}
					}
				return holder != null;
			}
		}

		/**
		* return the value local to a given context,
		* allocated on the fly (with New() method), if needed
		*/
		public virtual object Get(OpenGLContext ctxt)
		{
			if(ctxt == null)
				return null;
			object[] holder = (object[]) ctxt.Get(this);
			if(holder==null)
			{
				holder = new object[1];
				ctxt.Set(this, holder);
				// try { // let error raise ...
					holder[0] = New(); 
				// } catch {}
			}
			return holder[0];
		}
		/// <summary>
		/// set the value local to this context
		/// </summary>
		public virtual void Set(OpenGLContext ctxt, object val)
		{
			if(ctxt == null)
				return;
			object[] holder = (object[]) ctxt.Get(this);
			if(holder == null) {
				holder = new object[1];
				ctxt.Set(this, holder);
			}
			holder[0] = val;
		}
		
		/** Dispose the value in all context and remove them from
		 * local values table. <br>
		 * end-user should preferably override the context local version */
		public virtual void Dispose()
		{
			foreach(OpenGLContext ctxt in OpenGLContext.AllContext) {
				Dispose(ctxt);
				ctxt.Set(this, null);
			}
			GC.SuppressFinalize(this);
		}
		
		/** Dispose of the local value for this context */
		public virtual void Dispose(OpenGLContext ctxt)
		{
			if(ctxt==null)
				return;
			object[] o = (object[]) ctxt.Get(this);
			if(o==null)
				return;
			if(o[0] is IDisposable) {
				((IDisposable) o[0]).Dispose();
				GC.SuppressFinalize(o[0]);
			}
		}
		
		/// <summary>
		/// create a new instance when first acceded
		/// </summary>
		protected virtual object New() 
		{
			return null;
		}
		
		public virtual void GetObjectData(SerializationInfo info, 
		                                  StreamingContext context)
		{}
		
		protected ContextLocal(SerializationInfo info, 
		                       StreamingContext context)
		{}
	}
}
