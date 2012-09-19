using Esprima.NET.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Storm.Test.CsCode;

namespace Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments
{
    [TestClass]
    public class _7_4_Comments : SputnikV1TestBase
    {
       [TestCategory(@"7.4")]
       [TestCategory(@"Correct interpretation of single line comments")]
       [Description(@"Create comments with any code")]
       [TestMethod]
       public void S7_4_A1_T1()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A1_T1.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Correct interpretation of single line comments")]
       [Description(@"Simple test, create empty comment: ///")]
       [TestMethod]
       public void S7_4_A1_T2()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A1_T2.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Correct interpretation of multi line comments")]
       [Description(@"Create comments with any code")]
       [TestMethod]
       public void S7_4_A2_T1()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A2_T1.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Correct interpretation of multi line comments")]
       [Description(@"Try use /*CHECK#1/. This is not closed multi line comment")]
       [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
       [TestMethod]
       public void S7_4_A2_T2()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A2_T2.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Multi line comments cannot nest")]
       [Description(@"Try use nested comments")]
       [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
       [TestMethod]
       public void S7_4_A3()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A3.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Try use 2 close comment tags")]
       [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
       [TestMethod]
       public void S7_4_A4_T1()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T1.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Fist Multi line comment, then Single line comment")]
       [TestMethod]
       public void S7_4_A4_T2()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T2.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Insert Single line comment into Multi line comment")]
       [TestMethod]
       public void S7_4_A4_T3()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T3.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Try to open Multi line comment at the end of Single comment")]
       [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
       [TestMethod]
       public void S7_4_A4_T4()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T4.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Insert Multi line comment into Single line comment")]
       [TestMethod]
       public void S7_4_A4_T5()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T5.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Insert Multi line comment with two closed tags into Single line comment")]
       [TestMethod]
       public void S7_4_A4_T6()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T6.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single and Multi line comments are used together")]
       [Description(@"Insert Multi line comment into Single line comments")]
       [TestMethod]
       public void S7_4_A4_T7()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A4_T7.js");
           RunTest(code);
       }

       [TestCategory(@"")]
       [TestMethod]
       public void S7_4_A5_global_and_array()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A5.global_and_array.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"Single line comments can contain any Unicode character without Line Terminators")]
       [Description(@"//var "" + xx + ""yy = -1"", insert instead of xx all Unicode characters")]
       [TestMethod]
       public void S7_4_A5()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A5.js");
           RunTest(code);
       }

       [TestCategory(@"7.4")]
       [TestCategory(@"If multi line comments csn not nest, they can contain any Unicode character")]
       [Description(@"var""+ yy+ ""xx = 1"", insert instead of yy all Unicode characters")]
       [TestMethod]
       public void S7_4_A6()
       {
           var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._4_Comments.S7.4_A6.js");
           RunTest(code);
       }

    }
}
