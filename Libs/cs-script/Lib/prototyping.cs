using System;
using System.Windows.Forms;

public partial class ScriptClass
{
	static public void print(string template, params string[] args)
	{
		Console.Write(template, args);
	}
	static public void printl(string template, params string[] args)
	{
		Console.WriteLine(template, args);
	}
}

