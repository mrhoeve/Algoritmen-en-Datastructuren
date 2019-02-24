using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Algoritmen_en_Datastructuren.Homework;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_3_7
    {
        private List<int> baseList;
        private int[] baseArray;

        public Opgave_3_7()
        {
            // Initialise arrays and quantity
            int quantity = 10000;
            baseList = new List<int>();
            baseArray = new int[quantity];
            int[] arrayInsertionsort = new int[quantity];
            int[] arrayShellsort = new int[quantity];
            int[] arrayMergesort = new int[quantity];

            // Initialise timers
            Stopwatch clockRunningTime = new Stopwatch();
            Stopwatch stopwatch = new Stopwatch();
            TimeSpan timeInsertionList;
            TimeSpan timeInsertionArray;
            TimeSpan timeShellList;
            TimeSpan timeShellArray;
            TimeSpan timeMergeList;
            TimeSpan timeMergeArray;
            TimeSpan totalRunningTime;

            // Populate both lists with random numbers, but the lists have to remain equal for comparison
            generateLists(quantity);

            // Clone the generated lists
            List<int> listInsertionsort = new List<int>(baseList.Select(x => x));

            listInsertionsort.CopyTo(arrayInsertionsort);
            List<int> listShellsort = new List<int>(baseList.Select(x => x));
            listShellsort.CopyTo(arrayShellsort);
            List<int> listMergesort = new List<int>(baseList.Select(x => x));
            listMergesort.CopyTo(arrayMergesort);

            clockRunningTime.Start();
            stopwatch.Start();
            Opgave_3_7_Sortings<int>.Insertionsort(listInsertionsort);
            stopwatch.Stop();
            timeInsertionList = stopwatch.Elapsed;
            stopwatch.Restart();
            Opgave_3_7_Sortings<int>.Insertionsort(arrayInsertionsort);
            stopwatch.Stop();
            timeInsertionArray = stopwatch.Elapsed;
            stopwatch.Restart();
            Opgave_3_7_Sortings<int>.Shellsort(listShellsort);
            stopwatch.Stop();
            timeShellList = stopwatch.Elapsed;
            stopwatch.Restart();
            Opgave_3_7_Sortings<int>.Shellsort(arrayShellsort);
            stopwatch.Stop();
            timeShellArray = stopwatch.Elapsed;
            stopwatch.Restart();
            Opgave_3_7_Sortings<int>.Mergesort(listMergesort);
            stopwatch.Stop();
            timeMergeList = stopwatch.Elapsed;
            stopwatch.Restart();
            Opgave_3_7_Sortings<int>.Mergesort(arrayMergesort);
            stopwatch.Stop();
            timeMergeArray = stopwatch.Elapsed;
            clockRunningTime.Stop();
            totalRunningTime = clockRunningTime.Elapsed;

            // Compare the results!
            if (listInsertionsort.SequenceEqual(listShellsort) && listShellsort.SequenceEqual(listMergesort))
            {
                Console.WriteLine("De lijsten zijn vergeleken en zijn gelijk.");
            }
            else
            {
                Console.WriteLine("De lijsten zijn vergeleken en zijn VERSCHILLEND!");
            }
            if (arrayInsertionsort.SequenceEqual(arrayShellsort) && arrayShellsort.SequenceEqual(arrayMergesort))
            {
                Console.WriteLine("De arrays zijn vergeleken en zijn gelijk.");
            }
            else
            {
                Console.WriteLine("De arrays zijn vergeleken en zijn VERSCHILLEND!");
            }

            Console.WriteLine($"\nIn totaal heeft het sorteren {totalRunningTime.TotalMilliseconds} ms. tijd in beslag genomen.\n");
            Console.WriteLine($"                List\t\tArray");
            Console.WriteLine($"Insertion Sort: {timeInsertionList.TotalMilliseconds}\t{timeInsertionArray.TotalMilliseconds}");
            Console.WriteLine($"Shell Sort    : {timeShellList.TotalMilliseconds}\t{timeShellArray.TotalMilliseconds}");
            Console.WriteLine($"Merge Sort    : {timeMergeList.TotalMilliseconds}\t{timeMergeArray.TotalMilliseconds}");
        }

        private void generateLists(int quantity)
        {
            var rand = new Random();
            for (int i = 0; i < quantity; i++)
                baseList.Add(rand.Next(1000000));
            baseList.CopyTo(baseArray);
        }
    }

    public static class Opgave_3_7_Sortings<T> where T : IComparable
    {
        /// <summary>
        /// Insertionsort algorithm
        /// </summary>
        /// <param name="theList">Array or List of Comparible items</param>
        public static void Insertionsort(IList<T> theList)
        {
            for (int p = 1; p < theList.Count; p++)
            {
                T temp= theList[p];
                int j = p;
                for (; j > 0 && temp.CompareTo(theList[j - 1]) < 0; j--)
                {
                    theList[j] = theList[j-1];
                }
                theList[j] = temp;
            }
        }

        /// <summary>
        /// Shellsort algorithm
        /// </summary>
        /// <param name="theList">Array or List of Comparible items</param>
        public static void Shellsort(IList<T> theList)
        {
            for(int gap = theList.Count / 2; gap > 0;
                gap = gap == 2 ? 1 : (int) (gap / 2.2))
            for (int i = gap; i < theList.Count; i++)
            {
                T temp = theList[i];
                int j = i;
                for (; j >= gap && temp.CompareTo(theList[j - gap]) < 0; j -= gap)
                    theList[j] = theList[j - gap];
                theList[j] = temp;
            }
        }

        #region "Mergesort algorithm"
        /// <summary>
        /// Mergesort algorithm
        /// </summary>
        /// <param name="theList">Array or List of Comparible items</param>
        public static void Mergesort(IList<T> theList)
        {
            IList<T> tempArray = new T[theList.Count];
            MergeSort(theList, tempArray, 0, theList.Count - 1);
        }

        /// <summary>
        /// Internal method that makes recursive calls
        /// </summary>
        /// <param name="theList">Array or List of Comparible items</param>
        /// <param name="tempArray">Array to place the merged results</param>
        /// <param name="left">left-most index of the subarray</param>
        /// <param name="right">right-most index of the subarray</param>
        private static void MergeSort(IList<T> theList, IList<T> tempArray, int left, int right)
        {
            if(left < right)
            {
                int center = (left + right) / 2;
                MergeSort(theList, tempArray, left, center);
                MergeSort(theList, tempArray, center + 1, right);
                Merge(theList, tempArray, left, center + 1, right);
            }
        }

        /// <summary>
        /// Internal method that merges two sorted halves of a list.
        /// </summary>
        /// <param name="theList">Array or List of Comparible items</param>
        /// <param name="tempArray">Array to place the merged results</param>
        /// <param name="leftPos">left-most index of the subarray</param>
        /// <param name="rightPos">index of the start of the second half</param>
        /// <param name="rightEnd">right-most index of the subarray</param>
        private static void Merge(IList<T> theList, IList<T> tempArray, int leftPos, int rightPos, int rightEnd)
        {
            int leftEnd = rightPos - 1;
            int tmpPos = leftPos;
            int numElements = rightEnd - leftPos + 1;

            // Main loop
            while (leftPos <= leftEnd && rightPos<=rightEnd)
            {
                if (theList[leftPos].CompareTo(theList[rightPos]) <= 0)
                {
                    tempArray[tmpPos++] = theList[leftPos++];
                }
                else
                {
                    tempArray[tmpPos++] = theList[rightPos++];
                }
            }
            // Copy rest of first half
            while (leftPos <= leftEnd)
                tempArray[tmpPos++] = theList[leftPos++];
            // Copy rest of second half
            while (rightPos <= rightEnd)
                tempArray[tmpPos++] = theList[rightPos++];

            // Copy tempArray back
            for (int i = 0; i < numElements; i++, rightEnd--)
                theList[rightEnd] = tempArray[rightEnd];
        }
        #endregion
    }
}
