using System;
using System.Drawing;
using System.Windows.Forms;
using CsGL.OpenGL;
using CsGL.Util;

public class EventDemo : Form
{
	View view = new View();
	public EventDemo()
	{
		Text = "Event demo !";
		view.Dock = DockStyle.Fill;
		Controls.Add(view);
		Size = new Size(500, 400);
		
		Bitmap b = new Bitmap("FingerRight.gif");
		// must be destroyed (Mouse.DestroyCursor)
		// better than Cursors.SomeCursor, he ?
		view.Cursor = Mouse.CreateCursor(b, 18, 8); 
	}
	public static void Main()
	{
		Console.WriteLine("Quit with ALT+F4");
		
		EventDemo ed = new EventDemo();
		ed.Show();
		ed.Location = new Point(100, 100);
		Application.Run(ed);
	}
}
public class View : OpenGLControl
{
	Model model;
	
	public View()
	{
		model = new Model(this);
		Cursor = Cursors.Cross;
	}
	protected override void InitGLContext() 
	{
		model.Init();
	}
	public override void glDraw() 
	{
		model.Draw();
	}
}
public class Model : GL
{
	internal View view;
	internal GDITextureFont font;
	MyMouse mouse;
	MyKeyboard keyboard;
	
	public Model(View aView)
	{
		view = aView;
		font = new GDITextureFont(view.Font);
		mouse = new MyMouse(this);
		keyboard = new MyKeyboard(this);
	}
	public void Init()
	{
		Point p = view.TopLevelControl.Location;
		mouse.WarpAt(350, 300);
	}
	public void Draw()
	{
		glClear(GL_COLOR_BUFFER_BIT);
		font.Draw2DString(keyboard.ToString(), 5, 40);
		font.Draw2DString(mouse.ToString(), 5, 20);
	}
	
	public void Invalidate() { view.Invalidate(); }
}
public class MyMouse : Mouse
{
	Model model;
	public MyMouse(Model m) { model = m; }
	
	string lastEvent;
	public override string ToString()
	{
		string s = "Mouse: "+lastEvent;
		lastEvent = null;
		return s;
	}
	public override void MouseEvent(Event e, int dx, int dy)
	{
		lastEvent = "+("+dx+", "+dy+") "+e;
		model.Invalidate();
	}
}
public class MyKeyboard : Keyboard
{
	Model model;
	public MyKeyboard(Model m) { model = m; }
	
	public override string ToString()
	{
		string s = "Keyboard "+lastEvent+": " +current();
		lastEvent = null;
		return s;
	}
	string lastEvent;
	public override void KeyStateChanged(Event e) 
	{
		lastEvent = e.ToString();
		model.Invalidate();
	}
	string current()
	{
		bool[] b = State;
		string ret = null;
		for(int i=0; i<b.Length; i++) 
			if(b[i]) {
				if(ret==null) ret = "" + (Keys) i;
				else ret += "|" + (Keys) i;
			}
		return ret;
	}
}
