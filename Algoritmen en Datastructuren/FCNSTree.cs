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
            FCNSNode<T>.PrintPreOrder(root);
        }


        public int Size()
        {
            return FCNSNode<T>.Size(root);
        }
    }
}
