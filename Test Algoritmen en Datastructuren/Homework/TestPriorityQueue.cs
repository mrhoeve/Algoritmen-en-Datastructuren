using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.BinaryHeap;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestPriorityQueue
    /// </summary>
    [TestClass]
    public class TestPriorityQueue
    {
        public TestPriorityQueue()
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
        public void TestPriorityQueueWithNormalOperation()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Add(50);
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(25);
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(40);
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(60);
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(30);
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueWithBuildHeapOperation()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.addFreely(50);
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.addFreely(25);
            Assert.IsTrue("50 25".Equals(pq.PrintPreorder()));
            pq.addFreely(40);
            Assert.IsTrue("50 25 40".Equals(pq.PrintPreorder()));
            pq.addFreely(60);
            Assert.IsTrue("50 25 40 60".Equals(pq.PrintPreorder()));
            pq.addFreely(30);
            Assert.IsTrue("50 25 40 60 30".Equals(pq.PrintPreorder()));
            pq.BuildHeap();
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueFindMinAfterSeveralOperations()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.addFreely(50);
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.addFreely(25);
            Assert.IsTrue("50 25".Equals(pq.PrintPreorder()));
            pq.addFreely(40);
            Assert.IsTrue("50 25 40".Equals(pq.PrintPreorder()));
            pq.addFreely(60);
            Assert.IsTrue("50 25 40 60".Equals(pq.PrintPreorder()));
            pq.addFreely(30);
            Assert.IsTrue("50 25 40 60 30".Equals(pq.PrintPreorder()));
            pq.BuildHeap();
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            Assert.AreEqual(25, pq.Element());
            pq.Remove();
            Assert.AreEqual(30, pq.Element());
            Assert.IsTrue("30 50 40 60".Equals(pq.PrintPreorder()));
            pq.Remove();
            Assert.AreEqual(40, pq.Element());
            Assert.IsTrue("40 50 60".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueClear()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Add(50);
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(25);
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(40);
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(60);
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(30);
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            pq.Clear();
            Assert.IsTrue("".Equals(pq.PrintPreorder()));
            pq.Add(50);
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(25);
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(40);
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(60);
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(30);
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueSize()
        {
            PriorityQueue pq = new PriorityQueue();
            pq.Add(50);
            Assert.AreEqual(1, pq.Size());
            pq.Add(25);
            Assert.AreEqual(2, pq.Size());
            pq.Add(40);
            Assert.AreEqual(3, pq.Size());
            pq.Add(60);
            Assert.AreEqual(4, pq.Size());
            pq.Add(30);
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            Assert.AreEqual(5, pq.Size());
            pq.Clear();
            Assert.IsTrue("".Equals(pq.PrintPreorder()));
            Assert.AreEqual(0, pq.Size());
        }
    }
}
