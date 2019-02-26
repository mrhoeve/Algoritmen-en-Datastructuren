using Algoritmen_en_Datastructuren.Homework;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_3_1
    /// </summary>
    [TestClass]
    public class TestOpgave_3_1
    {
        [TestMethod]
        public void TestFaculteit()
        {
            Assert.AreEqual(120, Opgave_3_1.FaculteitRecursief(5));
        }
    }
}
