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

        public static int Size(FCNSNode<T> node)
        {
            if (node == null) return 0;
            return 1 + Size(node.FirstChild) + Size(node.NextSibling);
        }

        public static void PrintPreOrder(FCNSNode<T> node, int level = 0)
        {
            if (node == null) return;
            if (level == 0)
            {
                Console.WriteLine("ROOT A");
            }
            else
            {
                for(int teller=0;teller<level;teller++)
                    Console.Write("-->\t");
                Console.WriteLine(node.get());
            }
            PrintPreOrder(node.FirstChild, level+1);
            PrintPreOrder(node.NextSibling, level);
        }

    }
}
