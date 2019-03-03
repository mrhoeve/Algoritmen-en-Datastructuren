using Algoritmen_en_Datastructuren.Interface;
using System;

namespace Algoritmen_en_Datastructuren
{
    class FCNSTree<T> : IFCNSTree<T>
    {
        // declare root node
        private FCNSNode<T> root;

        public FCNSTree()
        {
            root = new FCNSNode<T>(default(T));
        }

        public void clear()
        {
            root.FirstChild = null;
            root.NextSibling = null;
        }
        
        public void addNode(FCNSNode<T> node)
        {
            root.FirstChild = node;
        }

        public void PrintPreOrder()
        {
            PrintPreOrder(root);
        }

        private void PrintPreOrder(FCNSNode<T> node, bool isChild=false)
        {
            if (node == null) return;
            if(root.Equals(node))
            {
                Console.WriteLine("ROOT A");
            } else
            {
                if(isChild)
                    Console.Write("child:");
                Console.WriteLine(node.get());
            }
                PrintPreOrder(node.FirstChild, true);
                PrintPreOrder(node.NextSibling);
        }

        public int Size()
        {
            return Size(root);
        }

        private int Size(FCNSNode<T> node)
        {
            if (node == null) return 0;
            return 1 + Size(node.FirstChild) + Size(node.NextSibling);
        }
    }
}
