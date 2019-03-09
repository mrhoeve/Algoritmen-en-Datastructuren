using Algoritmen_en_Datastructuren.BinarySearchTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_5_1
    /// </summary>
    [TestClass]
    public class TestOpgave_5_1
    {
        public TestOpgave_5_1()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestToStringOpLegeTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsTrue(string.IsNullOrEmpty(bst.ToString()));
        }

        [TestMethod]
        public void TestToStringOpTreeMetEenRootElement()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            Assert.IsTrue("NULL 6 NULL".Equals(bst.ToString()));
        }

        [TestMethod]
        public void TestToStringOpTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            Assert.IsTrue("[ [ NULL 2 NULL ] 4 [ NULL 5 NULL ] ] 6 [ NULL 7 NULL ]".Equals(bst.ToString()));
        }

        [TestMethod]
        public void TestInOrderOpTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            Assert.IsTrue("2 4 5 6 7".Equals(bst.InOrder()));
        }

        [TestMethod]
        public void TestFindMinOpTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            Assert.AreEqual(2, bst.FindMin());
        }

        [TestMethod]
        public void TestFindMaxOpTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            Assert.AreEqual(7, bst.FindMax());
        }

        [TestMethod]
        public void TestFindElementInTree()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(4);
            bst.Insert(7);
            bst.Insert(6);
            Assert.AreEqual(0, bst.Find(3));
            Assert.AreEqual(4, bst.Find(4));
        }

        [TestMethod]
        public void TestRemoveMinOpTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            Assert.AreEqual(2, bst.FindMin());
            bst.RemoveMin();
            Assert.AreEqual(4, bst.FindMin());
        }

        [TestMethod]
        public void TestRemoveItemVanTreeMetEenAantalElementen()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            // Check if base is correct
            Assert.AreEqual(4, bst.Find(4));
            Assert.IsTrue("[ [ NULL 2 NULL ] 4 [ NULL 5 NULL ] ] 6 [ NULL 7 NULL ]".Equals(bst.ToString()));
            // Remove 4, which is a node in the tree above 2 and 5
            bst.Remove(4);
            // Check afterwards...
            Assert.AreEqual(0, bst.Find(4));
            Assert.AreEqual(5, bst.Find(5));
            Assert.IsTrue("[ [ NULL 2 NULL ] 5 NULL ] 6 [ NULL 7 NULL ]".Equals(bst.ToString()));
            // Remove another item
            bst.Remove(7);
            Assert.AreEqual(0, bst.Find(7));
            Assert.IsTrue("[ [ NULL 2 NULL ] 5 NULL ] 6 NULL".Equals(bst.ToString()));

        }

        [TestMethod]
        public void TestIsEmpty()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsTrue(bst.IsEmpty());
            bst.Insert(6);
            Assert.IsFalse(bst.IsEmpty());
        }

        [TestMethod]
        public void TestMakeEmpty()
        {
            BinarySearchTree bst = new BinarySearchTree();
            Assert.IsTrue(bst.IsEmpty());
            bst.Insert(6);
            Assert.IsFalse(bst.IsEmpty());
            bst.MakeEmpty();
            Assert.IsTrue(bst.IsEmpty());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInsertDoubleKey()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(6);
            bst.Insert(4);
            bst.Insert(2);
            bst.Insert(5);
            bst.Insert(7);
            bst.Insert(4);
        }
    }
}
