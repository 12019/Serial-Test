#using <mscorlib.dll>
#using <system.dll>
#using <system.drawing.dll>
#using <system.windows.forms.dll>
#using <csgl.dll>

using namespace System;
using namespace System::Windows::Forms;
using namespace CsGL::OpenGL;

__gc class Model : public GL
{
public:
	void Draw()
	{
        glClear(GL_COLOR_BUFFER_BIT | GL_DEPTH_BUFFER_BIT);
        glLoadIdentity();
        glTranslatef(-1.5F, 0.0F, -6.0F);
        glBegin(GL_TRIANGLES);
        glColor3f(1.0F, 0.0F, 0.0F);
        glVertex3f(0.0F, 1.0F, 0.0F);
        glColor3f(0.0F, 1.0F, 0.0F);
        glVertex3f(-1.0F, -1.0F, 0.0F);
        glColor3f(0.0F, 0.0F, 1.0F);
        glVertex3f(1.0F, -1.0F, 0.0F);
        glEnd();
        glTranslatef(3.0F, 0.0F, 0.0F);
        glColor3f(0.5F, 0.5F, 1.0F);
        glBegin(GL_QUADS);
        glVertex3f(-1.0F, 1.0F, 0.0F);
        glVertex3f(1.0F, 1.0F, 0.0F);
        glVertex3f(1.0F, -1.0F, 0.0F);
        glVertex3f(-1.0F, -1.0F, 0.0F);
        glEnd();
	}
};
__gc class GLView : public OpenGLControl
{
	Model* model;
	
public:
	GLView() : model(new Model)
	{
		Dock = DockStyle::Fill;
	}
	virtual void glDraw() 
	{ 
		model->Draw();
	}

protected:
	virtual void OnSizeChanged(EventArgs* e)
	{
		OpenGLControl::OnSizeChanged(e);

        System::Drawing::Size s = Size;
        double aspect_ratio = s.Width / (double) s.Height;

        GL::glMatrixMode(GL::GL_PROJECTION);
        GL::glLoadIdentity();
        GL::gluPerspective(45.0F, aspect_ratio, 0.1F, 100.0F);

        GL::glMatrixMode(GL::GL_MODELVIEW);
        GL::glLoadIdentity();
    }
};

int main(int argc, char **argl)
{
	Form* f = new Form();
	f->Controls->Add(new GLView);
	f->Text = S"CPP demo :-)...";
	Application::Run(f);
	return 0;
}
