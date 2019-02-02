using Algoritmen_en_Datastructuren;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test_Algoritmen_en_Datastructuren
{
    [TestClass]
    public class TestMyArrayList
    {
        [TestMethod]
        public void CreateMyArrayList()
        {
            MyArrayList _myArray = new MyArrayList(10);
            Assert.IsNotNull(_myArray);
        }

        [TestMethod]
        public void CreateArrayListOfTwoAndPutTwoItemsInIt()
        {
            MyArrayList _myArray = new MyArrayList(2);
            _myArray.add(4);
            _myArray.add(8);
            Assert.AreEqual(_myArray.get(0), 4);
            Assert.AreEqual(_myArray.get(1), 8);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateArrayListOfTwoPutTwoItemsInItAndAskForNumberThree()
        {
            MyArrayList _myArray = new MyArrayList(2);
            _myArray.add(4);
            _myArray.add(8);
            int test = _myArray.get(2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CreateArrayListOfTwoPutTwoItemsInItAndTryToAddItemThree()
        {
            MyArrayList _myArray = new MyArrayList(2);
            _myArray.add(4);
            _myArray.add(8);
            _myArray.add(10);
        }

        [TestMethod]
        public void CreateArrayListOfTwoPutTwoItemsInItClearListAddAnotherTwoAndCheckTheValues()
        {
            MyArrayList _myArray = new MyArrayList(2);
            _myArray.add(4);
            _myArray.add(8);
            Assert.AreEqual(_myArray.get(0), 4);
            Assert.AreEqual(_myArray.get(1), 8);
            _myArray.clear();
            _myArray.add(5);
            _myArray.add(10);
            Assert.AreEqual(_myArray.get(1), 10);
            Assert.AreEqual(_myArray.get(0), 5);

        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void CreateArrayListAddItemAskForNonaddedIndex()
        {
            MyArrayList _myArray = new MyArrayList(2);
            _myArray.set(1, 6);
            int test = _myArray.get(0);
        }

        [TestMethod]
        public void CreateArrayFillItAndCountTheNumbers()
        {
            MyArrayList _myArray = new MyArrayList(10);
            _myArray.add(4);
            _myArray.add(8);
            _myArray.add(7);
            _myArray.add(3);
            _myArray.add(0);
            _myArray.add(2);
            _myArray.add(5);
            _myArray.add(8);
            _myArray.add(9);
            _myArray.add(8);
            Assert.AreEqual(_myArray.countOccurences(8), 3);
            Assert.AreEqual(_myArray.countOccurences(1), 0);
            _myArray.clear();
            _myArray.add(4);
            _myArray.add(1);
            _myArray.add(7);
            _myArray.add(3);
            _myArray.add(0);
            _myArray.add(2);
            _myArray.add(5);
            _myArray.add(1);
            _myArray.add(9);
            _myArray.add(1);
            Assert.AreEqual(_myArray.countOccurences(8), 0);
            Assert.AreEqual(_myArray.countOccurences(1), 3);
        }

    }
}
