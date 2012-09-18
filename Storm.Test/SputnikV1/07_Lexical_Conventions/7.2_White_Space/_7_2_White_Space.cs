using System;
using Esprima.NET.Ex;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Storm.Test.CsCode;

namespace Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space
{
    [TestClass]
    public class _7_2_White_Space : SputnikV1TestBase
    {
        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"HORIZONTAL TAB (U+0009) between any two tokens is allowed")]
        [Description(@"Insert HORIZONTAL TAB(\u0009 and \t) between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"HORIZONTAL TAB (U+0009) between any two tokens is allowed")]
        [Description(@"Insert real HORIZONTAL TAB between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"VERTICAL TAB (U+000B) between any two tokens is allowed")]
        [Description(@"Insert VERTICAL TAB(\u000B and \v) between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"VERTICAL TAB (U+000B) between any two tokens is allowed")]
        [Description(@"Insert real VERTICAL TAB between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"FORM FEED (U+000C) between any two tokens is allowed")]
        [Description(@"Insert FORM FEED(\u000C and \f) between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_3_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.3_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"FORM FEED (U+000C) between any two tokens is allowed")]
        [Description(@"Insert real FORM FEED between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_3_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.3_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"SPACE (U+0020) between any two tokens is allowed")]
        [Description(@"Insert SPACE(\u0020) between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"SPACE (U+0020) between any two tokens is allowed")]
        [Description(@"Insert real SPACE between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"NO-BREAK SPACE (U+00A0) between any two tokens is allowed")]
        [Description(@"Insert NO-BREAK SPACE(\u00A0) between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_5_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.5_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.5")]
        [TestCategory(@"NO-BREAK SPACE (U+00A0) between any two tokens is allowed")]
        [Description(@"Insert real NO-BREAK SPACE between tokens of var x=1")]
        [TestMethod]
        public void S7_2_A1_5_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A1.5_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"HORIZONTAL TAB (U+0009) may occur within strings")]
        [Description(@"Use HORIZONTAL TAB(\u0009 and \t)")]
        [TestMethod]
        public void S7_2_A2_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"HORIZONTAL TAB (U+0009) may occur within strings")]
        [Description(@"Use real HORIZONTAL TAB")]
        [TestMethod]
        public void S7_2_A2_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"VERTICAL TAB (U+000B) may occur within strings")]
        [Description(@"Use VERTICAL TAB(\u000B and \v)")]
        [TestMethod]
        public void S7_2_A2_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"VERTICAL TAB (U+000B) may occur within strings")]
        [Description(@"Use real VERTICAL TAB")]
        [TestMethod]
        public void S7_2_A2_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"FORM FEED (U+000C) may occur within strings")]
        [Description(@"Use FORM FEED(\u000C and \f)")]
        [TestMethod]
        public void S7_2_A2_3_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.3_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"FORM FEED (U+000C) may occur within strings")]
        [Description(@"Use real FORM FEED")]
        [TestMethod]
        public void S7_2_A2_3_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.3_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"SPACE (U+0020) may occur within strings")]
        [Description(@"Use SPACE(\u0020)")]
        [TestMethod]
        public void S7_2_A2_4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"SPACE (U+0020) may occur within strings")]
        [Description(@"Use real SPACE")]
        [TestMethod]
        public void S7_2_A2_4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"NO-BREAK SPACE (U+00A0) may occur within strings")]
        [Description(@"Use NO-BREAK SPACE(\u00A0)")]
        [TestMethod]
        public void S7_2_A2_5_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.5_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.8.4")]
        [TestCategory(@"NO-BREAK SPACE (U+00A0) may occur within strings")]
        [Description(@"Use real NO-BREAK SPACE")]
        [TestMethod]
        public void S7_2_A2_5_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A2.5_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain HORIZONTAL TAB (U+0009)")]
        [Description(@"Use HORIZONTAL TAB(\u0009)")]
        [TestMethod]
        public void S7_2_A3_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain HORIZONTAL TAB (U+0009)")]
        [Description(@"Use real HORIZONTAL TAB")]
        [TestMethod]
        public void S7_2_A3_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain VERTICAL TAB (U+000B)")]
        [Description(@"Use VERTICAL TAB(\u000B)")]
        [TestMethod]
        public void S7_2_A3_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain VERTICAL TAB (U+000B)")]
        [Description(@"Use real VERTICAL TAB")]
        [TestMethod]
        public void S7_2_A3_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain FORM FEED (U+000C)")]
        [Description(@"Use FORM FEED(\u000C)")]
        [TestMethod]
        public void S7_2_A3_3_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.3_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain FORM FEED (U+000C)")]
        [Description(@"Use real FORM FEED")]
        [TestMethod]
        public void S7_2_A3_3_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.3_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain SPACE (U+0020)")]
        [Description(@"Use SPACE(\u0020)")]
        [TestMethod]
        public void S7_2_A3_4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain SPACE (U+0020)")]
        [Description(@"Use real SPACE")]
        [TestMethod]
        public void S7_2_A3_4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain NO-BREAK SPACE (U+00A0)")]
        [Description(@"Use NO-BREAK SPACE(\u00A0)")]
        [TestMethod]
        public void S7_2_A3_5_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.5_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Single line comment can contain NO-BREAK SPACE (U+00A0)")]
        [Description(@"Use real NO-BREAK SPACE")]
        [TestMethod]
        public void S7_2_A3_5_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A3.5_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain HORIZONTAL TAB (U+0009)")]
        [Description(@"Use HORIZONTAL TAB(\u0009)")]
        [TestMethod]
        public void S7_2_A4_1_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.1_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain HORIZONTAL TAB (U+0009)")]
        [Description(@"Use real HORIZONTAL TAB")]
        [TestMethod]
        public void S7_2_A4_1_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.1_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain VERTICAL TAB (U+000B)")]
        [Description(@"Use VERTICAL TAB(\u000B)")]
        [TestMethod]
        public void S7_2_A4_2_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.2_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain VERTICAL TAB (U+000B)")]
        [Description(@"Use real VERTICAL TAB")]
        [TestMethod]
        public void S7_2_A4_2_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.2_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain FORM FEED (U+000C)")]
        [Description(@"Use FORM FEED(\u000C)")]
        [TestMethod]
        public void S7_2_A4_3_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.3_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain FORM FEED (U+000C)")]
        [Description(@"Use real FORM FEED")]
        [TestMethod]
        public void S7_2_A4_3_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.3_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain SPACE (U+0020)")]
        [Description(@"Use SPACE(\u0020)")]
        [TestMethod]
        public void S7_2_A4_4_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.4_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain SPACE (U+0020)")]
        [Description(@"Use real SPACE")]
        [TestMethod]
        public void S7_2_A4_4_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.4_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain NO-BREAK SPACE (U+00A0)")]
        [Description(@"Use NO-BREAK SPACE(\u00A0)")]
        [TestMethod]
        public void S7_2_A4_5_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.5_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2, 7.4")]
        [TestCategory(@"Multi line comment can contain NO-BREAK SPACE (U+00A0)")]
        [Description(@"Use real NO-BREAK SPACE")]
        [TestMethod]
        public void S7_2_A4_5_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A4.5_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2")]
        [TestCategory(@"White space cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Use TAB (U+0009)")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_2_A5_T1()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A5_T1.js");
            RunTest(code);
        }

        [TestCategory(@"7.2")]
        [TestCategory(@"White space cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Use VERTICAL TAB (U+000B)")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_2_A5_T2()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A5_T2.js");
            RunTest(code);
        }

        [TestCategory(@"7.2")]
        [TestCategory(@"White space cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Use FORM FEED (U+000C)")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_2_A5_T3()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A5_T3.js");
            RunTest(code);
        }

        [TestCategory(@"7.2")]
        [TestCategory(@"White space cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Use SPACE (U+0020)")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_2_A5_T4()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A5_T4.js");
            RunTest(code);
        }

        [TestCategory(@"7.2")]
        [TestCategory(@"White space cannot be expressed as a Unicode escape sequence consisting of six characters, namely \u plus four hexadecimal digits")]
        [Description(@"Use NO-BREAK SPACE (U+00A0)")]
        [ExpectedException(typeof(SyntaxError), @"Unexpected token ILLEGAL")]
        [TestMethod]
        public void S7_2_A5_T5()
        {
            var code = GetResource("Storm.Test.SputnikV1._07_Lexical_Conventions._7._2_White_Space.S7.2_A5_T5.js");
            RunTest(code);
        }

    }
}
