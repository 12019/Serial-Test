Imports System
Imports CsGL.OpenGL

Public Class Model
    Inherits CsGL.OpenGL.GL

    Public Sub Draw()
		glClear(Convert.ToUInt32(GLFlags.GL_COLOR_BUFFER_BIT Or GLFlags.GL_DEPTH_BUFFER_BIT))
        glLoadIdentity()
        glTranslatef(-1.5F, 0.0F, -6.0F)
        glBegin(Convert.ToUint32(GLFlags.GL_TRIANGLES))
        glColor3f(1.0F, 0.0F, 0.0F)
        glVertex3f(0.0F, 1.0F, 0.0F)
        glColor3f(0.0F, 1.0F, 0.0F)
        glVertex3f(-1.0F, -1.0F, 0.0F)
        glColor3f(0.0F, 0.0F, 1.0F)
        glVertex3f(1.0F, -1.0F, 0.0F)
        glEnd()
        glTranslatef(3.0F, 0.0F, 0.0F)
        glColor3f(0.5F, 0.5F, 1.0F)
        glBegin(Convert.ToUint32(GLFlags.GL_QUADS))
        glVertex3f(-1.0F, 1.0F, 0.0F)
        glVertex3f(1.0F, 1.0F, 0.0F)
        glVertex3f(1.0F, -1.0F, 0.0F)
        glVertex3f(-1.0F, -1.0F, 0.0F)
        glEnd()
    End Sub
End Class
