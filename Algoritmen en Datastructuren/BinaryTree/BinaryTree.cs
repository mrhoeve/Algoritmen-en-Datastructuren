using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.BinaryTree
{
    public class BinaryTree<T> : IBinaryTree<T>
    {
        private BinaryNode<T> root;

        public BinaryTree()
        {
            root = null;
        }

        public BinaryTree(T rootItem)
        {
            root = new BinaryNode<T>(rootItem, null, null);
        }

        public BinaryNode<T> GetRoot()
        {
            return root;
        }

        public int Height()
        {
            return BinaryNode<T>.Height(root);
        }

        public int CountLeaves()
        {
            return BinaryNode<T>.CountLeaves(root);
        }

        public int CountNodesWithOneChild()
        {
            return BinaryNode<T>.CountNodesWithOneChild(root);
        }

        public int CountNodesWithTwoChildren()
        {
            return BinaryNode<T>.CountNodesWithTwoChildren(root);
        }

        public bool IsEmpty()
        {
            return root == null;
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public void PrintInOrder()
        {
            if (root != null) root.printInOrder();
        }

        public void PrintPostOrder()
        {
            if (root != null) root.printPostOrder();
        }

        public void PrintPreOrder()
        {
            if (root != null) root.printPreOrder();
        }

        public int Size()
        {
            return BinaryNode<T>.Size(root);
        }

        /// <summary>
        /// Merge routine for merging two trees.
        /// Unnecessary for the assignment, but lets be complete :)
        /// </summary>
        /// <param name="rootItem">new root item</param>
        /// <param name="t1">tree 1</param>
        /// <param name="t2">tree 2</param>
        public void merge(T rootItem, BinaryTree<T> t1, BinaryTree<T> t2)
        {
            if (t1.root == t2.root && t1.root != null) throw new ArgumentException();
            // Allocate new node
            root = new BinaryNode<T>(rootItem, t1.root, t2.root);

            // Ensure that every node is in one tree
            if (this != t1) t1.root = null;
            if (this != t2) t2.root = null;
        }

        public override string ToString()
        {
            return root.ToString();
        }
    }
}
