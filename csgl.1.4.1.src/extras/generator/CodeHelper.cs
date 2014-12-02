using antlr;
using antlr.collections;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

public class CodeHelper
{
	Hashtable _fctNames = new Hashtable();
	/** fctType is the GLCOLORTABLEPROC type name string. 
	 * fctName is the user name and string with wich call GetProc */
	public void SetTypeName(string fctType, string fctName)
	{
		_fctNames[fctType] = fctName;
	}
	/** return the user name of a type. if it not defined in the file
	 * return the '?'+type */
	public string GetTypeName(string type)
	{
		string s = (string) _fctNames[type];
		return s==null ? '?'+type : s;
	}
}
