Imports System
Imports CsGL.OpenGL

Public Class GLView
    Inherits OpenGLControl

    Dim model1 As Model

    Public Sub New()
        MyBase.New()
        model1 = New Model()
    End Sub

    Public Overloads Overrides Sub glDraw()
        model1.Draw()
    End Sub

    Protected Overloads Overrides Sub OnSizeChanged(ByVal e As EventArgs)
        MyBase.OnSizeChanged(e)

        Dim aspect_ratio As Double
        Dim s As System.Drawing.Size
        s = Size

        aspect_ratio = s.Width / CDbl(s.Height)

        GL.glMatrixMode(Convert.ToUint32(GLFlags.GL_PROJECTION))
        GL.glLoadIdentity()
        GL.gluPerspective(45.0F, aspect_ratio, 0.1F, 100.0F)

        GL.glMatrixMode(Convert.ToUint32(GLFlags.GL_MODELVIEW))
        GL.glLoadIdentity()
    End Sub

End Class
