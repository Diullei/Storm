using System;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;
using CSScriptLibrary;

class Script
{
	static string usage = "Usage: cscscript cache scriptFile ...\nOpens the cahce directory for a given C# script file.\n";
	
	static public void Main(string[] args)
	{	
		if (args.Length == 0 || (args[0] == "?" || args[0] == "/?" || args[0] == "-?" || args[0].ToLower() == "help"))
		{	Console.WriteLine(usage);
			return;
		}

		string path = csscript.CSSEnvironment.GetCacheDirectory(Path.GetFullPath(args[0]));

		if (Directory.Exists(path))
			Process.Start("explorer.exe", "\""+path+"\"");
		else
			MessageBox.Show("The cache directory "+path+" does not exist.");
	}
}

