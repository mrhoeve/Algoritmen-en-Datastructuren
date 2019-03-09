using Algoritmen_en_Datastructuren.BinaryTree;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_4
    /// </summary>
    [TestClass]
    public class TestOpgave_Week4
    {
        private BinaryTree<int> tree;

        public TestOpgave_Week4()
        {
            // Set the working tree for all tests
            tree = new BinaryTree<int>(4);
            tree.GetRoot().setLeft(new BinaryNode<int>(2, new BinaryNode<int>(1, null, null), new BinaryNode<int>(3, null, null)));
            tree.GetRoot().setRight(new BinaryNode<int>(6, null, null));
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Assert.IsTrue("[ [ NULL 1 NULL ] 2 [ NULL 3 NULL ] ] 4 [ NULL 6 NULL ] ".Equals(tree.ToString()));
        }

        [TestMethod]
        public void TestCountLeaves()
        {
            Assert.AreEqual(3, tree.CountLeaves());
        }

        [TestMethod]
        public void TestCountNodesWithOneChild()
        {
            Assert.AreEqual(0, tree.CountNodesWithOneChild());
        }

        [TestMethod]
        public void TestCountNodesWithTwoChildren()
        {
            Assert.AreEqual(2, tree.CountNodesWithTwoChildren());
        }
    }
}
