using System;
using CSScriptLibrary;

public class Host
{
    static public void Log(string text)
    {
        Console.WriteLine(text);
    }

    static void Main()
    {
        var Sum = new AsmHelper(CSScript.LoadMethod(
            @"public static int Sum(int a, int b)
              {
                  System.Diagnostics.Debugger.Break();
                  Host.Log(""Calculating sum..."");
                  return a + b;
              }", null, true))
              .GetStaticMethod();

        int result = (int)Sum(1, 2);
    }
}

