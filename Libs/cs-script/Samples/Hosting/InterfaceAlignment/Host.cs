using CSScriptLibrary;

public interface IScript
{
    void Hello(string greeting);
}

class Host
{
    static void Main()
    {
        TestWithRawAssembly();
        TestWithAsmHelper();
        TestWithAsmHelperAndUnloadingAssembly();
    }

    static void TestWithRawAssembly()
    {
        var script = CSScript.Load("HelloScript.cs")
                             .CreateInstance("Script")
                             .AlignToInterface<IScript>();

        script.Hello("Hi there...");
    }

    static void TestWithAsmHelper()
    {
        //Note usage of CreateObject("Script") is also acceptable

        var script = new AsmHelper(CSScript.Load("HelloScript.cs"))
                                           .CreateObject("*")             
                                           .AlignToInterface<IScript>();

        script.Hello("Hi there..."); 
    }

    static void TestWithAsmHelperAndUnloadingAssembly()
    {
        //we cannot use HelloScript.cs as class Script must 
        //be serializable or derived from MarshalByRefObject
        var code = @"using System;
 
                     public class Script : MarshalByRefObject
                     {
                         public void Hello(string greeting)
 	                     {
 	                         Console.WriteLine(greeting);
 	                     }
                     }";

        //Note usage of helper.CreateAndAlignToInterface<IScript>("Script") is also acceptable
        using (var helper = new AsmHelper(CSScript.CompileCode(code), null, false))
        {
            IScript script = helper.CreateAndAlignToInterface<IScript>("*");

            script.Hello("Hi there...");
        }
    }
}

