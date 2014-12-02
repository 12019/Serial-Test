import CsGL.OpenGL.*;

public class View extends OpenGLControl
{
	GLModel model = new MyModel();

	public void InitGLContext()
	{
		model.Init();
	}
	public void glDraw()
	{
		model.Draw();
	}
}
