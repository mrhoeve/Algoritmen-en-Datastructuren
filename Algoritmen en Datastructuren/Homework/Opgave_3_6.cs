using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    class Opgave_3_6
    {
        public Opgave_3_6()
        {
            printForward(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
            Console.Write("\n");
            printBackward(new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3);
            Console.Write("\n");
        }

        private void printForward(List<int> theList, int i)
        {
            if (i == theList.Count) return;
            Console.Write($"{theList[i]} ");
            printForward(theList, i + 1);
        }

        private void printBackward(List<int> theList, int i)
        {
            if (theList.Count == i) return;
            Console.Write($"{theList.Last()} ");
            theList.RemoveAt(theList.Count - 1);
            printBackward(theList, i);
        }
    }
}
