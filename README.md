# Storm

Storm is a javascript engine written in C#.

> STORM IS UNDER CONSTRUCTION (!)

### Hello World

Let's look at a Hello World example that takes a JavaScript statement as a string argument, executes it as JavaScript code, and prints the result to console. This example is written in c# but any other .NET language can use Storm.

```c#
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
```

## License

Storm is distributed under the MIT license. [See license file here](https://raw.github.com/Diullei/Storm/master/LICENSE.txt) or below:

Copyright (c) 2012 by Diullei Gomes

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.