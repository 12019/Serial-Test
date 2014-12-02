using System;
using System.Drawing;
using System.Windows.Forms;
using CsGL.OpenGL;

/**
 * this example demonstrate shared display list and
 * font
 */
public class FDemo : Form
{
	MyView view;
	
	public FDemo()
	{
		Text = "Font & Shared list demo !";
		view = new MyView();
		view.Dock = DockStyle.Fill;
		Controls.Add(view);
	}
	public FDemo(MyView other)
	{
		Text = "Font & Shared list demo !";
		view = new MyView(other);
		view.Dock = DockStyle.Fill;
		Controls.Add(view);
	}
	
	[STAThread]
	public static void Main()
	{
		FDemo f1 = new FDemo();
		FDemo f2 = new FDemo(f1.view); // test shared list
		
		f1.Show();
		//f2.Show();
		
		Application.Run(f1);
	}
}
public class MyView : OpenGLControl
{
	MyView _toShare;
	GDITextureFont myFont;
	
	public MyView() : this(null) {}
	public MyView(MyView toShare) 
	{ 
		_toShare = toShare;
		// here we test  GDITextureFont
		Exception ex=null;
		do
		{
			try { 
				myFont = toShare==null 
					? new GDITextureFont(SelectFont()) 
					: toShare.myFont;
			}
			// some font doesn't support Regular style ...
			catch(Exception anEx) { ex = anEx; }
		}
		while(ex != null);
	}
	public Font SelectFont()
	{
		FontFamily[] ff = FontFamily.Families;
		Random r = new Random();
		return new Font(ff[r.Next()%ff.Length], 8+r.Next()%40);
	}
	
	protected override OpenGLContext CreateContext()
	{
		ControlGLContext c = new ControlGLContext(this);
		OpenGLContext ctxt = _toShare==null ? null : _toShare.Context;
		// here we test sharing of display list between context
		c.Create(new DisplayType(0,32), ctxt);
		return c;
	}
	public override void glDraw()
	{
		GL.glClear(GL.GL_COLOR_BUFFER_BIT | GL.GL_DEPTH_BUFFER_BIT);	// Clear Screen And Depth Buffer
		
	    GL.glLoadIdentity();
		GL.glTranslated(0, 0, -1000);
		GL.glRotated(35, 1, 1.2, 0.2);
		GL.glScaled(2, 2, 2);
		
		for(int i=0; i<6; i++)
		{
			GL.glPushMatrix();
			switch(i) {
				case 0: 
					GL.glColor3f(1, 1, 0);
					break;
				case 1: 
					GL.glColor3f(0, 1, 1);
					GL.glRotated(90, 0, 1, 0); 
					break;
				case 2: 
					GL.glColor3f(1, 0, 1);
					GL.glRotated(180, 0, 1, 0); 
					break;
				case 3: 
					GL.glColor3f(1, 0, 0);
					GL.glRotated(270, 0, 1, 0); 
					break;
				case 4: 
					GL.glColor3f(0, 1, 0);
					GL.glRotated(90, 1, 0, 0); 
					break;
				case 5: 
					GL.glColor3f(0, 0, 1);
					GL.glRotated(-90, 1, 0, 0); 
					break;
			}
			GL.glTranslated(-20, -10, 100);
			
			myFont.DrawString("face "+(i+1));
			GL.glPopMatrix();
		}
		
		GL.glColor3f(1, 1, 0.8f);
		myFont.Draw2DString("Here you go !", 10, 10);
	}
	protected override void InitGLContext() 
	{
		GL.glEnable(GL.GL_DEPTH_TEST);
		GL.glClearColor(0.7f, 0.7f, 0.7f, 1.0f);
	}
	protected override void OnSizeChanged(EventArgs e)
	{
		base.OnSizeChanged(e);
		
		Size s = Size;
		double aspect_ratio = (double)s.Width /(double) s.Height;

	    GL.glMatrixMode(GL.GL_PROJECTION);
	    GL.glLoadIdentity();
		
		// special frustum, to have nice font display
		GL.glFrustum(-s.Width, s.Width, -s.Height, s.Height, 700, 1300);
	
	    GL.glMatrixMode(GL.GL_MODELVIEW);
	    GL.glLoadIdentity();
	}
}
