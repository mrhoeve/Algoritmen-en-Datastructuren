using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.BinarySearchTree
{
    public class BinarySearchTree : IBinarySearchTree
    {
        private Node root;

        public BinarySearchTree()
        {
            root = null;
        }

        public int FindMin()
        {
            return ElementAt(FindMin(root));
        }

        public string InOrder()
        {
            return InOrder(root);
        }

        public void Insert(int x)
        {
            root = Insert(x, root);
        }

        public void Remove(int x)
        {
            root = Remove(x, root);
        }

        public void RemoveMin()
        {
            root = RemoveMin(root);
        }

        #region "public methods that are not required now, but the are part of BST's"
        public int FindMax()
        {
            return ElementAt(FindMax(root));
        }

        public int Find(int x)
        {
            return ElementAt(Find(x, root));
        }

        public void MakeEmpty()
        {
            root = null;
        }

        public bool IsEmpty()
        {
            return root == null;
        }
        #endregion

        #region "Private methods"
        private int ElementAt(Node t)
        {
            if (t == null) return 0;
            return t.element;
        }

        private Node Find(int x, Node t)
        {
            while(t != null)
            {
                if (x < t.element)
                    t = t.left;
                else if (x > t.element)
                    t = t.right;
                else if (x == t.element)
                    return t;
            }
            return null;
        }

        private Node FindMin(Node t)
        {
            if(t != null)
            {
                while (t.left != null)
                {
                    t = t.left;
                }
            }
            return t;
        }

        private Node FindMax(Node t)
        {
            if (t != null)
            {
                while (t.right != null)
                {
                    t = t.right;
                }
            }
            return t;
        }

        private Node Insert(int x, Node t)
        {
            if (t == null)
                t = new Node(x);
            else if (x < t.element)
                t.left = Insert(x, t.left);
            else if (x > t.element)
                t.right = Insert(x, t.right);
            else
                throw new ArgumentException($"{x} already present in tree");
            return t;
        }

        private Node RemoveMin(Node t)
        {
            if (t == null) return null;
            if(t.left != null)
            {
                t.left = RemoveMin(t.left);
                return t;
            } else
            {
                return t.right;
            }
        }

        private Node Remove(int x, Node t)
        {
            if (t == null) return null;
            if (x < t.element)
                t.left = Remove(x, t.left);
            else if (x > t.element)
                t.right = Remove(x, t.right);
            else if (t.left != null && t.right != null)
            {
                t.element = FindMin(t.right).element;
                t.right = RemoveMin(t.right);
            }
            else
                t = (t.left != null) ? t.left : t.right;
            return t;
        }
        #endregion

        public override string ToString()
        {
            if (root == null) return "";
            return root.ToString();
        }

        private string InOrder(Node t)
        {
            if (t == null) return "";
            StringBuilder sb = new StringBuilder();
            if (t.left != null)
            {
                sb.Append(InOrder(t.left));
                sb.Append(" ");
            }
            sb.Append(t.element);
            if (t.right != null)
            {
                sb.Append(" ");
                sb.Append(InOrder(t.right));
            }
            return sb.ToString();
        }
    }
}
