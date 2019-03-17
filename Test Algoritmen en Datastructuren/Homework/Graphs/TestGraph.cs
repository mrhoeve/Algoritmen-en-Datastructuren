using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren.Graphs;

namespace Test_Algoritmen_en_Datastructuren.Homework.Graphs
{
    /// <summary>
    /// Summary description for TestGraph
    /// </summary>
    [TestClass]
    public class TestGraph
    {
        [TestMethod]
        public void TestVertexToString()
        {
            //Build the graph from figure 1 on page 502
            Graph graph = new Graph();
            graph.AddEdge("V2", "V0", 4);
            graph.AddEdge("V2", "V5", 5);
            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V0", "V3", 1);
            graph.AddEdge("V1", "V4", 10);
            graph.AddEdge("V1", "V3", 3);
            graph.AddEdge("V4", "V6", 6);
            graph.AddEdge("V6", "V5", 1);
            graph.AddEdge("V3", "V2", 2);
            graph.AddEdge("V3", "V4", 2);
            graph.AddEdge("V3", "V5", 8);
            graph.AddEdge("V3", "V6", 3);
            Assert.AreEqual("V2 --> V0(4) V5(5)", graph.GetVertex("V2").ToString());
        }

        [TestMethod]
        public void TestGraphToString()
        {
            //Build the graph from figure 1 on page 502
            Graph graph = new Graph();
            graph.AddEdge("V2", "V0", 4);
            graph.AddEdge("V2", "V5", 5);
            graph.AddEdge("V0", "V1", 2);
            graph.AddEdge("V0", "V3", 1);
            graph.AddEdge("V1", "V3", 3);
            graph.AddEdge("V1", "V4", 10);
            graph.AddEdge("V4", "V6", 6);
            graph.AddEdge("V6", "V5", 1);
            graph.AddEdge("V3", "V2", 2);
            graph.AddEdge("V3", "V5", 8);
            graph.AddEdge("V3", "V6", 4);
            graph.AddEdge("V3", "V4", 2);

            StringBuilder sb = new StringBuilder();
            sb.Append("V0 --> V1(2) V3(1)");
            sb.Append(Environment.NewLine);
            sb.Append("V1 --> V3(3) V4(10)");
            sb.Append(Environment.NewLine);
            sb.Append("V2 --> V0(4) V5(5)");
            sb.Append(Environment.NewLine);
            sb.Append("V3 --> V2(2) V5(8) V6(4) V4(2)");
            sb.Append(Environment.NewLine);
            sb.Append("V4 --> V6(6)");
            sb.Append(Environment.NewLine);
            sb.Append("V5 -->");
            sb.Append(Environment.NewLine);
            sb.Append("V6 --> V5(1)");
            sb.Append(Environment.NewLine);
            Assert.AreEqual(sb.ToString(), graph.ToString());
        }

    }
}
