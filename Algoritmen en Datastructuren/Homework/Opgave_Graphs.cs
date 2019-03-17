using Algoritmen_en_Datastructuren.Graphs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_Graphs
    {
        public Opgave_Graphs()
        {
            //Graph graph = new Graph();
            //graph.AddEdge("Meppel", "Nijeveen", 5.0);

            // Build the graph from figure 1 on page 502
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

            Console.WriteLine(graph);
            graph.Unweighted("V2");
            graph.printPath("V6");

            graph.Dijkstra("V2");
            graph.printPath("V5");
            Console.WriteLine(graph);

        }
    }
}
