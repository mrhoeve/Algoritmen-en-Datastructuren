using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.Proefpracticum;

namespace Test_Algoritmen_en_Datastructuren.Proefpracticum
{
    /// <summary>
    /// Summary description for UnitTestOpgave1
    /// </summary>
    [TestClass]
    public class UnitTestOpgave1
    {
        [TestMethod]
        public void testPrintLetters()
        {
            Opgave1 opgave = new Opgave1();
            Assert.IsTrue("AAAZZZ".Equals(opgave.printLetters(3)));
            Assert.IsTrue("".Equals(opgave.printLetters(0)));
        }


        [TestMethod]
        public void testPrintLetters2()
        {
            Opgave1 opgave = new Opgave1();
            Assert.IsTrue("AAAZZZZZ".Equals(opgave.printLetters2(3, 5)));
            Assert.IsTrue("AA".Equals(opgave.printLetters2(2,0)));
        }
    }
}
