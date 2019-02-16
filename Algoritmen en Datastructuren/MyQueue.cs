using Algoritmen_en_Datastructuren.Interface;
using System;

namespace Algoritmen_en_Datastructuren
{
    public class MyQueue : IQueue
    {
        private MyArrayList myArrayList;
        private int front;
        private int back;
        private int maxSize;
        private int curSize;
        private const int DEFAULT_QUEUE_SIZE = 10;

        public MyQueue(int size=DEFAULT_QUEUE_SIZE)
        {
            maxSize = size;
            myArrayList = new MyArrayList(maxSize);
            curSize = 0;
            front = 0;
            back = -1;
        }
        public void clear()
        {
            curSize = 0;
            front = 0;
            back = -1;
        }

        public int? dequeue()
        {
            if (front == maxSize) front = 0;
            if (curSize == 0) return (int?) null;
            curSize--;
            return myArrayList.get(front++);
        }

        public void enqueue(int data)
        {
            if (curSize + 1 > maxSize) throw new ArgumentOutOfRangeException("Queue is full");
            back++;
            if (back == maxSize) back = 0;
            myArrayList.set(back, data);
            curSize++;
        }

        public bool isEmpty()
        {
            return curSize==0;
        }
    }
}
