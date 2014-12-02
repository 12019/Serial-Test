using System;
using System.Drawing;
using System.Windows.Forms;
using CsGL.OpenGL;

public class Display
{
	public static void Main()
	{
		Control c = new Control();
		OpenGLContext ctxt = new ControlGLContext(c);
		
		int n = ctxt.NumPixelFormats;
		Console.WriteLine(n + " display found");
		for(int i=0; i<n; i++)
			// if it please me I could create the context ==>
			// ctxt.Create(i, null);
			Console.WriteLine(ctxt.GetPixelFormat(i));
		
		ctxt.Dispose();
	}
}
