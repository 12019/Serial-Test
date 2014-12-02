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
using System.Threading;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CsGL.Util
{
	/**
	 * a form which the screen definition when it's made visible,
	 * and fit to it.
	 */
	public class ScreenForm : Form
	{
		/** create a screen from with the current definition */
		public ScreenForm() : this(ScreenSetting.CurrentDisplay)
		{
		}
		public ScreenForm(int w, int h) : this(new ScreenSetting(w, h))
		{
		}
		public ScreenForm(ScreenSetting ss)
		{
			setting = ss;
			if(!ss.Valid)
				throw new ArgumentException(setting+" Not available");
			
			FormBorderStyle = FormBorderStyle.None;
			Size = new Size(setting.Width, setting.Height);
			Location = new Point(0, 0);
			NotifyVisible += new ShowAction(VisibilityAlert);
			fullscreen = false;
		}
		private ScreenSetting setting;

		/** an helper method to set a Control which span all the control */
		public virtual Control Control
		{
			get {
				return Controls[0];
			}
			set {
				Controls.Clear();
				value.Dock = DockStyle.Fill;
				Controls.Add(value);
			}
		}
		
		protected override void Dispose(bool disposing)
		{
			NotifyVisible -= new ShowAction(VisibilityAlert);
			setFullscreen(false);
			base.Dispose(disposing);
		}
		
		protected override void SetBoundsCore(int x, int y, int w, int h, BoundsSpecified specified)
		{
			base.SetBoundsCore(0, 0, setting.Width, setting.Height, specified);
		}
		protected override void OnLocationChanged(EventArgs e)
		{
			base.SetBoundsCore(0, 0, setting.Width, setting.Height, BoundsSpecified.All);
		}
		protected override void SetVisibleCore(bool val)
		{
			if(val) {
				base.SetBoundsCore(0, 0, setting.Width, setting.Height, BoundsSpecified.All);
				setFullscreen(true);
				base.SetVisibleCore(true);
				VisibilityAlert(this);
			}
			else {
				setFullscreen(false);
				base.SetVisibleCore(false);
			}
		}
		
		private bool fullscreen = false;
		private void setFullscreen(bool b)
		{
			if(b==fullscreen)
				return;
			if(b)
				setting.Set();
			else
				ScreenSetting.Reset();
			fullscreen = b;
		}
		
		delegate void ShowAction(ScreenForm aForm);
		static event ShowAction NotifyVisible;
		void VisibilityAlert(ScreenForm aForm)
		{
			if(aForm == this || !fullscreen)
				return;
				
			fullscreen = false;
			SetVisibleCore(false);
		}
	}
}
