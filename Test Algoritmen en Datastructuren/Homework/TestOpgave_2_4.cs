using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.Homework;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_2_4
    /// </summary>
    [TestClass]
    public class TestOpgave_2_4
    {
        [TestMethod]
        public void TestHomework24checkBrackets()
        {
            Opgave_2_4 opgave_2_4 = new Opgave_2_4();
            Assert.IsTrue(opgave_2_4.checkBrackets("()"));
            Assert.IsTrue(opgave_2_4.checkBrackets("( ( ( ) ( ) ) )"));
            Assert.IsFalse(opgave_2_4.checkBrackets("( ) )"));
        }

        [TestMethod]
        public void TestHomework24checkBrackets2()
        {
            Opgave_2_4 opgave_2_4 = new Opgave_2_4();
            Assert.IsTrue(opgave_2_4.checkBrackets2("[ ( ( [ ] ) ) ( ) ]"));
            Assert.IsFalse(opgave_2_4.checkBrackets2("( [ ) ]"));
        }
    }
}
