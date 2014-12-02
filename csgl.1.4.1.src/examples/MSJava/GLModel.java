import System.*;
import CsGL.OpenGL.*;

public abstract class GLModel extends GL
{
	public abstract void Draw();
	public abstract void Init();
}

class MyModel extends GLModel
{
	public void Init()
	{
		glMatrixMode(GL_PROJECTION);
		glLoadIdentity();
		gluPerspective(45.0f, 1, 0.1f, 100.0f);
	
		glMatrixMode(GL_MODELVIEW);
		glLoadIdentity();
	}
	public void Draw()
	{
		int i1 = Convert.ToInt32(GL_COLOR_BUFFER_BIT);
		int i2 = Convert.ToInt32(GL_DEPTH_BUFFER_BIT);
		glClear(Convert.ToUInt32(i1|i2));	// Clear Screen And Depth Buffer
		glLoadIdentity();					// Reset The Current Modelview Matrix
		glTranslatef(-1.5f,0.0f,-6.0f);		// Move Left 1.5 Units And Into The Screen 6.0
		glBegin(GL_TRIANGLES);				// Drawing Using Triangles
			glColor3f(1.0f,0.0f,0.0f);		// Set The Color To Red
			glVertex3f( 0.0f, 1.0f, 0.0f);	// Top
			glColor3f(0.0f,1.0f,0.0f);		// Set The Color To Green
			glVertex3f(-1.0f,-1.0f, 0.0f);	// Bottom Left
			glColor3f(0.0f,0.0f,1.0f);		// Set The Color To Blue
			glVertex3f( 1.0f,-1.0f, 0.0f);	// Bottom Right
		glEnd();							// Finished Drawing The Triangle
		glTranslatef(3.0f,0.0f,0.0f);		// Move Right 3 Units
		glColor3f(0.5f,0.5f,1.0f);			// Set The Color To Blue One Time Only
		glBegin(GL_QUADS);					// Draw A Quad
			glVertex3f(-1.0f, 1.0f, 0.0f);	// Top Left
			glVertex3f( 1.0f, 1.0f, 0.0f);	// Top Right
			glVertex3f( 1.0f,-1.0f, 0.0f);	// Bottom Right
			glVertex3f(-1.0f,-1.0f, 0.0f);	// Bottom Left
		glEnd();							// Done Drawing The Quad
	}
}
