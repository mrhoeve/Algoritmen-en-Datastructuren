using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Graphs
{
    public class Edge
    {
        public Vertex dest { get; set; }
        public double cost { get; set; }

        public Edge(Vertex dest, double cost)
        {
            this.dest = dest;
            this.cost = cost;
        }
    }
}
