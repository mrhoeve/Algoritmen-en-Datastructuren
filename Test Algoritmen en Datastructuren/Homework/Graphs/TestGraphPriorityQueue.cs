using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.Graphs;

namespace Test_Algoritmen_en_Datastructuren.Homework.Graphs
{
    /// <summary>
    /// Summary description for TestGraphPriorityQueue
    /// </summary>
    [TestClass]
    public class TestGraphPriorityQueue
    {
        [TestMethod]
        public void TestPriorityQueueWithNormalOperation()
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();
            pq.Add(new Path(new Vertex(""), 50));
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 25));
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 40));
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 60));
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 30));
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueWithBuildHeapOperation()
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();
            pq.addFreely(new Path(new Vertex(""), 50));
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 25));
            Assert.IsTrue("50 25".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 40));
            Assert.IsTrue("50 25 40".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 60));
            Assert.IsTrue("50 25 40 60".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 30));
            Assert.IsTrue("50 25 40 60 30".Equals(pq.PrintPreorder()));
            pq.BuildHeap();
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueFindMinAfterSeveralOperations()
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();
            pq.addFreely(new Path(new Vertex(""), 50));
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 25));
            Assert.IsTrue("50 25".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 40));
            Assert.IsTrue("50 25 40".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 60));
            Assert.IsTrue("50 25 40 60".Equals(pq.PrintPreorder()));
            pq.addFreely(new Path(new Vertex(""), 30));
            Assert.IsTrue("50 25 40 60 30".Equals(pq.PrintPreorder()));
            pq.BuildHeap();
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            Assert.AreEqual(25, pq.Element().cost);
            pq.Remove();
            Assert.AreEqual(30, pq.Element().cost);
            Assert.IsTrue("30 50 40 60".Equals(pq.PrintPreorder()));
            pq.Remove();
            Assert.AreEqual(40, pq.Element().cost);
            Assert.IsTrue("40 50 60".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueClear()
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();
            pq.Add(new Path(new Vertex(""), 50));
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 25));
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 40));
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 60));
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 30));
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            pq.Clear();
            pq.Add(new Path(new Vertex(""), 50));
            Assert.IsTrue("50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 25));
            Assert.IsTrue("25 50".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 40));
            Assert.IsTrue("25 50 40".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 60));
            Assert.IsTrue("25 50 40 60".Equals(pq.PrintPreorder()));
            pq.Add(new Path(new Vertex(""), 30));
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
        }

        [TestMethod]
        public void TestPriorityQueueSize()
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();
            pq.Add(new Path(new Vertex(""), 50));
            Assert.AreEqual(1, pq.Size());
            pq.Add(new Path(new Vertex(""), 25));
            Assert.AreEqual(2, pq.Size());
            pq.Add(new Path(new Vertex(""), 40));
            Assert.AreEqual(3, pq.Size());
            pq.Add(new Path(new Vertex(""), 60));
            Assert.AreEqual(4, pq.Size());
            pq.Add(new Path(new Vertex(""), 30));
            Assert.IsTrue("25 30 40 60 50".Equals(pq.PrintPreorder()));
            Assert.AreEqual(5, pq.Size());
            pq.Clear();
            Assert.IsTrue("".Equals(pq.PrintPreorder()));
            Assert.AreEqual(0, pq.Size());
        }
    }
}
