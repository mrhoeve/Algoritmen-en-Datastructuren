using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Graphs
{
    public class Vertex : IVertex
    {
        public String name { get; set; }
        public LinkedList<Edge> adj { get; set; }
        public double dist { get; set; }
        public Vertex prev { get; set; }
        public int? scratch { get; set; }

        public Vertex(string nm)
        {
            this.name = nm;
            adj = new LinkedList<Edge>();
            Reset();
        }

        public void Reset()
        {
            dist = Graph.INFINITY;
            prev = null;
            //pos = null;
            scratch = null;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
