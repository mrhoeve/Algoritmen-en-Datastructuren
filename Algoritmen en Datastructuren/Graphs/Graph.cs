using System;
using System.Collections.Generic;

namespace Algoritmen_en_Datastructuren.Graphs
{
    public class Graph : IGraph
    {
        public static double INFINITY = double.MaxValue;
        private Dictionary<string, Vertex> vertexMap = new Dictionary<string, Vertex>();

        public void AddEdge(string source, string dest, double cost)
        {
            Vertex v = GetVertex(source);
            Vertex w = GetVertex(dest);
            v.adj.AddLast(new Edge(w, cost));
        }

        public void printPath(string destName)
        {
            Vertex v;
            if (!vertexMap.TryGetValue(destName, out v))
            {
                throw new ArgumentException($"{destName} not found");
            }
            if (v.dist == INFINITY)
            {
                Console.WriteLine($"{destName} is unreachable");
            }
            else
            {
                Console.WriteLine($"(Cost is: {v.dist})");
                PrintPath(v);
                Console.WriteLine("\n");
            }
        }

        public void Unweighted(string startName)
        {

        }

        public void Dijkstra(string startName)
        {

        }

        public void Negative(string startName)
        {

        }

        public void Acyclic(string startName)
        {

        }

        public Vertex GetVertex(string name)
        {
            Vertex v;
            if (!vertexMap.TryGetValue(name, out v))
            {
                v = new Vertex(name);
                vertexMap.Add(name, v);
            }
            return v;
        }

        private void PrintPath(Vertex dest)
        {
            if (dest.prev != null)
            {
                PrintPath(dest.prev);
                Console.WriteLine(" to ");
            }
            Console.WriteLine(dest.name);
        }

        private void ClearAll()
        {
            foreach (Vertex v in vertexMap.Values)
                v.Reset();
        }

    }
}
