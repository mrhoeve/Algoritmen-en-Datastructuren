using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            v.adj.Add(new Edge(w, cost));
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
            ClearAll();

            Vertex start;
            if (!vertexMap.TryGetValue(startName, out start))
            {
                throw new ArgumentException("Start vertex not found");
            }
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(start);
            start.dist = 0;

            while(q.Count!=0)
            {
                Vertex v = q.Dequeue();
                foreach(Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    if(w.dist == INFINITY)
                    {
                        w.dist = v.dist + 1;
                        w.prev = v;
                        q.Enqueue(w);
                    }
                }
            }

        }

        public void Dijkstra(string startName)
        {
            GraphPriorityQueue pq = new GraphPriorityQueue();

            Vertex start;
            if (!vertexMap.TryGetValue(startName, out start))
            {
                throw new ArgumentException("Start vertex not found");
            }
            ClearAll();
            pq.Add(new Path(start, 0));
            start.dist = 0;
            int nodesSeen = 0;
            while(!pq.isEmpty() && nodesSeen < vertexMap.Count)
            {
                Path vrec = pq.Remove();
                Vertex v = vrec.dest;
                if (v.scratch != null)
                    continue;
                v.scratch = 1;
                nodesSeen++;

                foreach(Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    double cvw = e.cost;
                    if (cvw < 0)
                        throw new ArgumentException("Graph has negative edges");

                    if(w.dist > v.dist + cvw)
                    {
                        w.dist = v.dist + cvw;
                        w.prev = v;
                        pq.Add(new Path(w, w.dist));
                    }
                }
            }
        }

        public void Negative(string startName)
        {
            ClearAll();
            Vertex start;
            if (!vertexMap.TryGetValue(startName, out start))
            {
                throw new ArgumentException("Start vertex not found");
            }
            Queue<Vertex> q = new Queue<Vertex>();
            q.Enqueue(start);
            start.dist = 0;
            start.scratch++;

            while(q.Count !=0)
            {
                Vertex v = q.Dequeue();
                if (v.scratch++ > 2 * vertexMap.Count) throw new ArgumentException("Negative cycle detected");

                foreach(Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    double cvw = e.cost;
                    if(w.dist > v.dist+cvw)
                    {
                        w.dist = v.dist + cvw;
                        w.prev = v;
                        // Enqueue only if not already on the queue
                        if(w.scratch++ % 2 ==0)
                        {
                            q.Enqueue(w);
                        } else
                        {
                            w.scratch--;
                        }
                    }
                }
            }
        }

        public void Acyclic(string startName)
        {
            Vertex start;
            if (!vertexMap.TryGetValue(startName, out start))
            {
                throw new ArgumentException("Start vertex not found");
            }
            ClearAll();
            Queue<Vertex> q = new Queue<Vertex>();
            start.dist = 0;

            // Compute indegrees
            ICollection<Vertex> vertexSet = vertexMap.Values;
            foreach (Vertex v in vertexSet)
                foreach (Edge e in v.adj)
                    e.dest.scratch++;

            //Enqueue vertices of indegree zero
            foreach (Vertex v in vertexSet)
                if (v.scratch == 0)
                    q.Enqueue(v);

            int iterations;
            for(iterations=0; q.Count!=0; iterations++)
            {
                Vertex v = q.Dequeue();
                foreach(Edge e in v.adj)
                {
                    Vertex w = e.dest;
                    double cvw = e.cost;
                    if (--w.scratch == 0)
                        q.Enqueue(w);

                    if (v.dist == INFINITY)
                        continue;

                    if(w.dist > v.dist + cvw)
                    {
                        w.dist = v.dist + cvw;
                        w.prev = v;
                    }
                }
            }

            if(iterations != vertexMap.Count) throw new ArgumentException("Graph has a cycle!");
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

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            List<string> list = vertexMap.Keys.ToList();
            list.Sort();
            foreach (string key in list)
            {
                sb.Append(vertexMap[key]);
                sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

    }
}
