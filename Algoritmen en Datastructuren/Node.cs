﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren
{
    public class Node<T>
    {
        T data;
        public Node<T> nextNode { get; set; }

        public Node(T t)
        {
            data = t;
        }
    }
}
