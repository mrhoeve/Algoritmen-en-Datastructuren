using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Graphs
{
    public class Path : IComparable
    {
        public Vertex dest { get; set; }
        public double cost { get; set; }

        public Path(Vertex d, double c)
        {
            dest = d;
            cost = c;
        }

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("Object is null");
            if(obj is Path)
            {
                Path compareWith = (Path)obj;
                double otherCost = compareWith.cost;
                return cost < otherCost ? -1 : cost > otherCost ? 1 : 0;
            }
            throw new ArgumentException("Object isn't of type Path");
        }
    }
}
