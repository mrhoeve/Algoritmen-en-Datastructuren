using Algoritmen_en_Datastructuren.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren
{
    public class MyStack<T> : IStack<T>
    {
        private MyLinkedList<T> myStack;

        public MyStack()
        {
            myStack = new MyLinkedList<T>();
        }

        public T Pop()
        {
            T data = Top();
            myStack.removeFirst();
            return data;
        }

        public void Push(T data)
        {
            myStack.addFirst(data);
        }

        public T Top()
        {
            return myStack.getFirst();
        }
    }
}
