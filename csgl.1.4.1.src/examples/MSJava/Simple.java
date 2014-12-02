import java.lang.reflect.*;
import System.Windows.Forms.*;
import System.Drawing.*;
import CsGL.OpenGL.*;

// java.awt.Frame work too but 
// can't be added a System.Windows.Forms.Control
public class Simple extends Form
{
	public static void main(String[] arg)
	{
		Form f = new Simple();
		Application.Run(f);
	}
	
	View view = new View();
	public Simple()
	{
		view.set_Dock(DockStyle.Fill);
		
		set_Text("OpenGL-Java !");
		set_Size(new Size(200, 200));
		get_Controls().Add(view);
	}
}
