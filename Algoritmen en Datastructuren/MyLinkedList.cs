using Algoritmen_en_Datastructuren.Interface;
using System;
using System.Collections.Generic;

namespace Algoritmen_en_Datastructuren
{
    public class MyLinkedList<T> : SimpleLinkedList<T>
    {
        private Node<T> head;
        private int nodeCount;

        public MyLinkedList ()
        {
            head = new Node<T>(default(T));
            nodeCount = 0;
        }

        // Voeg een item toe aan het begin van de lijst
        public void addFirst(T data)
        {
            insert(0, data);
        }

        public void clear()
        {
            head.nextNode = null;
            nodeCount = 0;
        }

        // geeft het eerste item terug
        public T getFirst()
        {
            return head.nextNode!=null ? head.nextNode.get() : default(T);
        }

        // Voeg een item in op een bepaalde index (niet overschrijven!)
        public void insert(int index, T data)
        {
            if (nodeCount < index) throw new IndexOutOfRangeException("Given index larger then LinkedList size");
            Node<T> currentNode = head;
            int counter = 0;
            while (counter != index && currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
                counter++;
            }
            if(currentNode.nextNode == null)
            {
                currentNode.nextNode = new Node<T>(data);
            } else
            {
                Node<T> insertNode = new Node<T>(data);
                insertNode.nextNode=currentNode.nextNode;
                currentNode.nextNode = insertNode;
            }
            nodeCount++;
        }

        public void print()
        {
            Node<T> currentNode = head;
            while (currentNode.nextNode != null)
            {
                currentNode = currentNode.nextNode;
                Console.WriteLine(currentNode.get());
            }
        }

        // verwijder het eerste item
        public void removeFirst()
        {
            if(head.nextNode != null && head.nextNode.nextNode != null)
            {
                head.nextNode = head.nextNode.nextNode;
            } else
            {
                head.nextNode = null;
            }
            nodeCount--;
        }
    }
}
