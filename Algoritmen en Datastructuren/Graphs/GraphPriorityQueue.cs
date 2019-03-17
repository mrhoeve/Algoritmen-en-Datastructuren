using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Graphs
{
    public class GraphPriorityQueue
    {
        private static int DEFAULT_CAPACITY = 100;
        private int currentSize;
        private Path[] array;

        public GraphPriorityQueue()
        {
            currentSize = 0;
            array = new Path[DEFAULT_CAPACITY];
        }

        public int Size()
        {
            return currentSize;
        }

        public void Clear()
        {
            currentSize = 0;
        }

        public Path Element()
        {
            if (isEmpty()) throw new ArgumentNullException("Heap is empty");
            return array[1];
        }

        public Boolean Add(Path x)
        {
            if (currentSize + 1 == array.Length) throw new ArgumentOutOfRangeException("Heap is full");
            int hole = ++currentSize;
            array[0] = x;
            for (; x.cost < array[hole / 2].cost; hole /= 2)
                array[hole] = array[hole / 2];
            array[hole] = x;
            return true;
        }

        public Path Remove()
        {
            Path minItem = Element();
            array[1] = array[currentSize--];
            PercolateDown(1);
            return minItem;
        }

        private void PercolateDown(int hole)
        {
            int child;
            Path tmp = array[hole];
            for (; hole * 2 <= currentSize; hole = child)
            {
                child = hole * 2;
                if (child != currentSize && array[child + 1].cost < array[child].cost)
                    child++;
                if (array[child].cost < tmp.cost)
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

        public Boolean isEmpty()
        {
            return currentSize == 0;
        }

        public string PrintPreorder()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= currentSize; i++)
            {
                sb.Append(array[i].cost);
                if (i + 1 <= currentSize) sb.Append(" ");
            }
            return sb.ToString();
        }

        public void addFreely(Path x)
        {
            array[++currentSize] = x;
        }
    }
}
