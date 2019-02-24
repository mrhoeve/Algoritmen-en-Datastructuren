using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Algoritmen_en_Datastructuren.Homework;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_3_7
    /// </summary>
    [TestClass]
    public class TestOpgave_3_7
    {
        private List<int> baseList;
        private int[] baseArray;

        [TestMethod]
        public void testSorteringen()
        {
            // Initialise arrays and quantity
            int quantity = 10000;
            baseList = new List<int>();
            baseArray = new int[quantity];
            int[] arrayInsertionsort = new int[quantity];
            int[] arrayShellsort = new int[quantity];
            int[] arrayMergesort = new int[quantity];

            // Populate both lists with random numbers, but the lists have to remain equal for comparison
            generateLists(quantity);

            // Clone the generated lists
            List<int> listInsertionsort = new List<int>(baseList.Select(x => x));
            listInsertionsort.CopyTo(arrayInsertionsort);
            List<int> listShellsort = new List<int>(baseList.Select(x => x));
            listShellsort.CopyTo(arrayShellsort);
            List<int> listMergesort = new List<int>(baseList.Select(x => x));
            listMergesort.CopyTo(arrayMergesort);

            // Check if all lists are equal to their bases
            Assert.IsTrue(baseList.SequenceEqual(listInsertionsort));
            Assert.IsTrue(baseList.SequenceEqual(listShellsort));
            Assert.IsTrue(baseList.SequenceEqual(listMergesort));

            Assert.IsTrue(baseArray.SequenceEqual(arrayInsertionsort));
            Assert.IsTrue(baseArray.SequenceEqual(arrayShellsort));
            Assert.IsTrue(baseArray.SequenceEqual(arrayMergesort));

            // Do the sortations
            Opgave_3_7_Sortings<int>.Insertionsort(listInsertionsort);
            Opgave_3_7_Sortings<int>.Insertionsort(arrayInsertionsort);
            Opgave_3_7_Sortings<int>.Shellsort(listShellsort);
            Opgave_3_7_Sortings<int>.Shellsort(arrayShellsort);
            Opgave_3_7_Sortings<int>.Mergesort(listMergesort);
            Opgave_3_7_Sortings<int>.Mergesort(arrayMergesort);

            // Compare the results!
            // First compare all lists to their bases
            // Because of the sorting, every lists must be different to its base
            Assert.IsFalse(baseList.SequenceEqual(listInsertionsort));
            Assert.IsFalse(baseList.SequenceEqual(listShellsort));
            Assert.IsFalse(baseList.SequenceEqual(listMergesort));

            Assert.IsFalse(baseArray.SequenceEqual(arrayInsertionsort));
            Assert.IsFalse(baseArray.SequenceEqual(arrayShellsort));
            Assert.IsFalse(baseArray.SequenceEqual(arrayMergesort));

            // Now compare the sorted lists
            // If everything works according to plan, every list should be equal to eachother.
            Assert.IsTrue(listInsertionsort.SequenceEqual(listShellsort));
            Assert.IsTrue(listShellsort.SequenceEqual(listMergesort));

            Assert.IsTrue(arrayInsertionsort.SequenceEqual(arrayShellsort));
            Assert.IsTrue(arrayShellsort.SequenceEqual(arrayMergesort));
        }

        private void generateLists(int quantity)
        {
            var rand = new Random();
            for (int i = 0; i < quantity; i++)
                baseList.Add(rand.Next(1000000));
            baseList.CopyTo(baseArray);
        }
    }
}
