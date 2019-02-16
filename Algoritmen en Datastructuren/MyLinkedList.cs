using Algoritmen_en_Datastructuren.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren
{
    public class MyLinkedList<T> : SimpleLinkedList<T>
    {
        private Node<T> head;
        private int nodeCount;

        public MyLinkedList(T t)
        {
            head = new Node<T>(default(T));
            nodeCount = 0;
            insert(1, t);
        }

        // Voeg een item toe aan het begin van de lijst
        public void addFirst(T data)
        {

        }

        public void clear()
        {
            throw new NotImplementedException();
        }

        // geeft het eerste item terug
        public T getFirst()
        {
            throw new NotImplementedException();
        }

        // Voeg een item in op een bepaalde index (niet overschrijven!)
        public void insert(int index, T data)
        {
            if (nodeCount + 1 < index) throw new IndexOutOfRangeException("Given index larger then LinkedList size");
            Node<T> tempNode = null;
            Node<T> currentNode = null;
            for(int stepper=0;stepper<index; stepper++)
            {
                currentNode= tempNode == null ? head : tempNode;
                tempNode = currentNode.nextNode;
            }
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        // verwijder het eerste item
        public void removeFirst()
        {
            throw new NotImplementedException();
        }
    }
}
