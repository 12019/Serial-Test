Imports System
Imports System.Windows.Forms
Imports CsGL.OpenGL

Module Hello
	Sub Main()
		Dim f As New MyForm()
		Application.Run(f)
	End Sub
End Module

Public Class MyForm
    Inherits Form

    Public Sub New()
        MyBase.New()
        Dim view As New GLView()
        view.Dock = DockStyle.Fill
        Controls.Add(view)
    End Sub
End Class
