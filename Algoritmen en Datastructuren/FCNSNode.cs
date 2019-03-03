using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren
{
    public class FCNSNode<T>
    {
        private T data;
        public FCNSNode<T> FirstChild { get; set; }
        public FCNSNode<T> NextSibling { get; set; }

        public FCNSNode(T t)
        {
            data = t;
        }

        public T get()
        {
            return data;
        }

    }
}
