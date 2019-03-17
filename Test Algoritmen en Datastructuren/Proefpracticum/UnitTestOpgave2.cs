using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.Proefpracticum;

namespace Test_Algoritmen_en_Datastructuren.Proefpracticum
{
    /// <summary>
    /// Summary description for UnitTestOpgave2
    /// </summary>
    [TestClass]
    public class UnitTestOpgave2
    {
        [TestMethod]
        public void TestOpgave2MetNodeEen()
        {
            Opgave2 bst = new Opgave2();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(1);
            bst.Insert(4);
            bst.Insert(3);
            bst.Insert(8);

            Assert.AreEqual(2, bst.geefEenNaKleinsteElement());
        }

        [TestMethod]
        public void TestOpgave2ZonderNodeEen()
        {
            Opgave2 bst = new Opgave2();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(4);
            bst.Insert(3);
            bst.Insert(8);
            Assert.AreEqual(3, bst.geefEenNaKleinsteElement());
        }

        [TestMethod]
        public void TestOpgave2ZonderNodesEenenDrie()
        {
            // Extra test
            Opgave2 bst = new Opgave2();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(4);
            bst.Insert(8);
            Assert.AreEqual(4, bst.geefEenNaKleinsteElement());
        }

        [TestMethod]
        public void TestOpgave2MetRootEnTweeChilds()
        {
            // Extra test
            Opgave2 bst = new Opgave2();
            bst.Insert(6);
            bst.Insert(2);
            bst.Insert(8);
            // Nu verwachten we de root terug
            Assert.AreEqual(6, bst.geefEenNaKleinsteElement());
        }
    }
}
