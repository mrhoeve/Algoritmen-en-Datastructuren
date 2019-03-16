using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.BinarySearchTree
{
    public class AVLTree : BinarySearchTree
    {
        public static Node rotateWithLeftChild(Node k2)
        {
            Node k1 = k2.left;
            k2.left = k1.right;
            k1.right = k2;
            return k1;
        }

        public static Node rotateWithRightChild(Node k1)
        {
            Node k2 = k1.right;
            k1.right = k2.left;
            k2.left = k1;
            return k2;
        }

        public static Node doubleRotateWithLeftChild(Node k3)
        {
            k3.left = rotateWithRightChild(k3.left);
            return rotateWithLeftChild(k3);
        }

        public static Node doubleRotateWithRightChild(Node k1)
        {
            k1.right = rotateWithLeftChild(k1.right);
            return rotateWithRightChild(k1);
        }
    }
}
