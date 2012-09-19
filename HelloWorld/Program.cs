using System;
using Storm;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // A string containing the JavaScript source code.
            const string source = "'Hello' + ', World'";

            // Compile the source code.
            var script = Script.Compile(source);

            // Run the script to get the result.
            var result = script.Run();

            // Print result on console
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
