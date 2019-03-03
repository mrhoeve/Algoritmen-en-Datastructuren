using Algoritmen_en_Datastructuren.BinaryTree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Week_4
    {
        public Week_4()
        {
            BinaryTree<int> tree = new BinaryTree<int>(4);
            tree.GetRoot().setLeft(new BinaryNode<int>(2, new BinaryNode<int>(1, null, null), new BinaryNode<int>(3, null, null)));
            tree.GetRoot().setRight(new BinaryNode<int>(6, null, null));
            tree.PrintInOrder();
        }
        

    }
}
