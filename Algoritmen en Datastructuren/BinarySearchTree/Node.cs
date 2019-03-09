using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.BinarySearchTree
{
    public class Node
    {
        public int element { get; set; }
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(int x)
        {
            element = x;
            left = null;
            right = null;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (left == null)
                sb.Append("NULL");
            else
            {
                sb.Append("[ ");
                sb.Append(left);
                sb.Append(" ]");
            }
            sb.Append(" ");
            sb.Append(element);
            sb.Append(" ");
            if(right==null)
                sb.Append("NULL");
            else
            {
                sb.Append("[ ");
                sb.Append(right);
                sb.Append(" ]");
            }
            return sb.ToString();
        }
    }
}
