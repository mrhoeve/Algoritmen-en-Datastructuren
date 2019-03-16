using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.BinaryHeap
{
    public class PriorityQueue
    {
        private static int DEFAULT_CAPACITY = 100;
        private int currentSize;
        private int[] array;

        public PriorityQueue()
        {
            currentSize = 0;
            array = new int[DEFAULT_CAPACITY];
        }

        public int Size()
        {
            return currentSize;
        }

        public void Clear()
        {
            currentSize = 0;
        }

        public int Element()
        {
            if (isEmpty()) throw new ArgumentNullException("Heap is empty");
            return array[1];
        }

        public Boolean Add(int x)
        {
            if (currentSize + 1 == array.Length) throw new ArgumentOutOfRangeException("Heap is full");
            int hole = ++currentSize;
            array[0] = x;
            for (; x < array[hole / 2]; hole /= 2)
                array[hole] = array[hole / 2];
            array[hole] = x;
            return true;
        }

        public int Remove()
        {
            int minItem = Element();
            array[1] = array[currentSize--];
            PercolateDown(1);
            return minItem;
        }

        private void PercolateDown(int hole)
        {
            int child;
            int tmp = array[hole];
            for(;hole*2 <= currentSize; hole=child)
            {
                child = hole * 2;
                if (child != currentSize && array[child + 1] < array[child])
                    child++;
                if (array[child] < tmp)
                    array[hole] = array[child];
                else
                    break;
            }
            array[hole] = tmp;
        }


        public void BuildHeap()
        {
            for (int i = currentSize / 2; i > 0; i--)
                PercolateDown(i);
        }

        private Boolean isEmpty()
        {
            return currentSize == 0;
        }

        public string PrintPreorder()
        {
            StringBuilder sb = new StringBuilder();
            for(int i=1;i<=currentSize; i++)
            {
                sb.Append(array[i]);
                if (i + 1 <= currentSize) sb.Append(" ");
            }
            return sb.ToString();
        }

        public void addFreely(int x)
        {
            array[++currentSize] = x;
        }
    }
}
