using antlr;
using antlr.collections;
using System;
using System.Collections;
using System.Globalization;
using System.IO;
using System.Text;

public class GLArgs
{
	public ArrayList types = new ArrayList();
	public ArrayList names = new ArrayList();
	
	public void Add(GLType type, string argName)
	{
		types.Add(type);
		switch(argName) {
			case "params":
				argName = "Params";
				break;
			case "out":
				argName = "Out";
				break;
			case "ref":
				argName = "Ref";
				break;
			case "in":
				argName = "In";
				break;
		}
		names.Add(argName);
	}
	public int Level 
	{
		get {
			int max = 0, l;
			foreach(GLType t in types) {
				l = t.Level;
				if(l>max)
					max = l;
			}
			return max;
		}
	}
}
