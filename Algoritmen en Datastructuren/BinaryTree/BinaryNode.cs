using System;
using System.Text;

namespace Algoritmen_en_Datastructuren.BinaryTree
{
    public class BinaryNode<T>
    {
        private T element;
        private BinaryNode<T> left;
        private BinaryNode<T> right;

        public BinaryNode() : this(default(T), null, null) { }

        public BinaryNode(T theElement, BinaryNode<T> left, BinaryNode<T> right)
        {
            this.element = theElement;
            this.left = left;
            this.right = right;
        }

        public T getElement()
        {
            return element;
        }

        public BinaryNode<T> getLeft()
        {
            return left;
        }

        public BinaryNode<T> getRight()
        {
            return right;
        }

        public void setElement(T x)
        {
            element = x;
        }

        public void setLeft(BinaryNode<T> left)
        {
            this.left = left;
        }

        public void setRight(BinaryNode<T> right)
        {
            this.right = right;
        }

        public static int Size(BinaryNode<T> node)
        {
            if (node == null) return 0;
            return 1 + Size(node.left) + Size(node.right);
        }

        public static int Height(BinaryNode<T> node)
        {
            if (node == null) return -1;
            return 1 + Math.Max(Height(node.left), Height(node.right));
        }

        public static int CountLeaves(BinaryNode<T> node)
        {
            if (node == null) return 0;
            if (node.left == null && node.right == null) return 1;
            return CountLeaves(node.left) + CountLeaves(node.right);
        }

        public static int CountNodesWithOneChild(BinaryNode<T> node)
        {
            if (node == null) return 0;
            if ((node.left != null && node.right == null) || (node.left == null && node.right != null))
            {
                return 1 + CountNodesWithOneChild(node.left) + CountNodesWithOneChild(node.right);
            }
            else
            {
                return CountNodesWithOneChild(node.left) + CountNodesWithOneChild(node.right);
            }
        }

        public static int CountNodesWithTwoChildren(BinaryNode<T> node)
        {
            if (node == null) return 0;
            if (node.left != null && node.right != null)
            {
                return 1 + CountNodesWithTwoChildren(node.left) + CountNodesWithTwoChildren(node.right);
            }
            else
            {
                return CountNodesWithTwoChildren(node.left) + CountNodesWithTwoChildren(node.right);
            }
        }

        public BinaryNode<T> duplicate()
        {
            BinaryNode<T> root = new BinaryNode<T>(element, null, null);
            if (left != null) root.left = left.duplicate();
            if (right != null) root.right = right.duplicate();
            return root;
        }

        public void printPreOrder()
        {
            Console.Write(element);
            if (left != null) left.printPreOrder();
            if (right != null) right.printPreOrder();
        }

        public void printPostOrder()
        {
            if (left != null) left.printPostOrder();
            if (right != null) right.printPostOrder();
            Console.Write(element);
        }

        public void printInOrder()
        {
            if (left != null) left.printInOrder();
            Console.Write(element);
            if (right != null) right.printInOrder();
        }

        public override string ToString()
        {
            return ToString(0);
        }

        private string ToString(int level = 0)
        {
            StringBuilder sb = new StringBuilder();
            if (level != 0) sb.Append("[ ");
            sb.Append(left != null ? left.ToString(level + 1) : "NULL ");
            sb.Append($"{element} ");
            sb.Append(right != null ? right.ToString(level + 1) : "NULL ");
            if (level != 0) sb.Append("] ");
            return sb.ToString();
        }
    }
}
