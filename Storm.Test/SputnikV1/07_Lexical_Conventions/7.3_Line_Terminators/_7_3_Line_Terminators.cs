using System;
using Esprima.NET.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Storm.Test.CsCode;

namespace Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators
{
    [TestClass]
    public class _7_3_Line_Terminators : SputnikV1TestBase
    {
        [TestCategory(@"7.3")]
        [TestCategory(@"LINE FEED (U+000A) may occur between any two tokens")]
        [Description(@"Insert LINE FEED (\u000A and \n) between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"LINE FEED (U+000A) may occur between any two tokens")]
        [Description(@"Insert real LINE FEED between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"CARRIAGE RETURN (U+000D) may occur between any two tokens")]
        [Description(@"Insert CARRIAGE RETURN (\u000D and \r) between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"CARRIAGE RETURN (U+000D) may occur between any two tokens")]
        [Description(@"Insert real CARRIAGE RETURN between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"LINE SEPARATOR (U+2028) may occur between any two tokens")]
        [Description(@"Insert LINE SEPARATOR (\u2028) between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"PARAGRAPH SEPARATOR (U+2029) may occur between any two tokens")]
        [Description(@"Insert PARAGRAPH SEPARATOR (\u2029) between tokens of var x=1")]
        [TestMethod]
        public void S7_3_A1_4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A1.4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"LINE FEED (U+000A) within strings is not allowed")]
        [Description(@"Insert LINE FEED (\u000A) into string")]
        [TestMethod]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        public void S7_3_A2_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"LINE FEED (U+000A) within strings is not allowed")]
        [Description(@"Use real LINE FEED into string")]
        [TestMethod]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        public void S7_3_A2_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"CARRIAGE RETURN (U+000D) within strings is not allowed")]
        [Description(@"Insert CARRIAGE RETURN (\u000D) into string")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A2_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"CARRIAGE RETURN (U+000D) within strings is not allowed")]
        [Description(@"Insert real CARRIAGE RETURN into string")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A2_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"LINE SEPARATOR (U+2028) within strings is not allowed")]
        [Description(@"Insert LINE SEPARATOR (\u2028) into string")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A2_3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"PARAGRAPH SEPARATOR (U+2029) within strings is not allowed")]
        [Description(@"Insert PARAGRAPH SEPARATOR (\u2029) into string")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A2_4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A2.4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain LINE FEED (U+000A) inside")]
        [Description(@"Insert LINE FEED (\u000A) into single line comment")]
        [ExpectedException(typeof(ReferenceError), @"comment is not defined")]
        [TestMethod]
        public void S7_3_A3_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain LINE FEED (U+000A) inside")]
        [Description(@"Insert LINE FEED (\u000A) into begin of single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain LINE FEED (U+000A) inside")]
        [Description(@"Insert real LINE FEED into single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_1_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.1_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain CARRIAGE RETURN (U+000D) inside")]
        [Description(@"Insert CARRIAGE RETURN (\u000D) into single line comment")]
        [ExpectedException(typeof(ReferenceError), @"comment is not defined")]
        [TestMethod]
        public void S7_3_A3_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain CARRIAGE RETURN (U+000D) inside")]
        [Description(@"Insert CARRIAGE RETURN (\u000D) into begin of single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain CARRIAGE RETURN (U+000D) inside")]
        [Description(@"Insert real CARRIAGE RETURN into single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_2_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.2_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain LINE SEPARATOR (U+2028) inside")]
        [Description(@"Insert LINE SEPARATOR (\u2028) into single line comment")]
        [ExpectedException(typeof(ReferenceError), @"comment is not defined")]
        [TestMethod]
        public void S7_3_A3_3_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.3_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain LINE SEPARATOR (U+2028) inside")]
        [Description(@"Insert LINE SEPARATOR (\u2028) into begin of single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_3_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.3_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain PARAGRAPH SEPARATOR (U+2029) inside")]
        [Description(@"Insert PARAGRAPH SEPARATOR (\u2029) into single line comment")]
        [ExpectedException(typeof(ReferenceError), @"comment is not defined")]
        [TestMethod]
        public void S7_3_A3_4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can not contain PARAGRAPH SEPARATOR (U+2029) inside")]
        [Description(@"Insert PARAGRAPH SEPARATOR (\u2029) into begin of single line comment")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected identifier")]
        [TestMethod]
        public void S7_3_A3_4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A3.4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can contain Line Terminator at the end of line")]
        [Description(@"Insert LINE FEED (U+000A) into the end of single line comment")]
        [TestMethod]
        public void S7_3_A4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can contain Line Terminator at the end of line")]
        [Description(@"Insert CARRIAGE RETURN (U+000D) into the end of single line comment")]
        [TestMethod]
        public void S7_3_A4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can contain Line Terminator at the end of line")]
        [Description(@"Insert LINE SEPARATOR (U+2028) into the end of single line comment")]
        [TestMethod]
        public void S7_3_A4_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A4_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Single line comments can contain Line Terminator at the end of line")]
        [Description(@"Insert PARAGRAPH SEPARATOR (U+2029) into the end of single line comment")]
        [TestMethod]
        public void S7_3_A4_T4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A4_T4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain LINE FEED (U+000A)")]
        [Description(@"Insert LINE FEED (U+000A) into multi line comment")]
        [TestMethod]
        public void S7_3_A5_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain LINE FEED (U+000A)")]
        [Description(@"Insert real LINE FEED into multi line comment")]
        [TestMethod]
        public void S7_3_A5_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain CARRIAGE RETURN (U+000D)")]
        [Description(@"Insert CARRIAGE RETURN (U+000D) into multi line comment")]
        [TestMethod]
        public void S7_3_A5_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain CARRIAGE RETURN (U+000D)")]
        [Description(@"Insert real CARRIAGE RETURN into multi line comment")]
        [TestMethod]
        public void S7_3_A5_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain LINE SEPARATOR (U+2028)")]
        [Description(@"Insert LINE SEPARATOR (U+2028) into multi line comment")]
        [TestMethod]
        public void S7_3_A5_3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3, 7.4")]
        [TestCategory(@"Multi line comment can contain LINE SEPARATOR (U+2029)")]
        [Description(@"Insert PARAGRAPH SEPARATOR (U+2029) into multi line comment")]
        [TestMethod]
        public void S7_3_A5_4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A5.4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Insert LINE FEED (U+000A) in var x")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A6_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A6_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Insert CARRIAGE RETURN (U+000D) in var x")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A6_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A6_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Insert LINE SEPARATOR (U+2028) in var x")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A6_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A6_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminator cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Insert PARAGRAPH SEPARATOR (U+2029) in var x")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_3_A6_T4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A6_T4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y+z")]
        [TestMethod]
        public void S7_3_A7_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y-z")]
        [TestMethod]
        public void S7_3_A7_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y*z")]
        [TestMethod]
        public void S7_3_A7_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y/z")]
        [TestMethod]
        public void S7_3_A7_T4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T4.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y%z")]
        [TestMethod]
        public void S7_3_A7_T5()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T5.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y>>z")]
        [TestMethod]
        public void S7_3_A7_T6()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T6.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y<<z")]
        [TestMethod]
        public void S7_3_A7_T7()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T7.js");
            RunTest(code);
        }

        [TestCategory(@"7.3")]
        [TestCategory(@"Line Terminators between operators are allowed")]
        [Description(@"Insert Line Terminator in var x=y<z")]
        [TestMethod]
        public void S7_3_A7_T8()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._3_Line_Terminators.S7.3_A7_T8.js");
            RunTest(code);
        }

    }
}
