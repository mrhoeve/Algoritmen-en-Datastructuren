using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren;

namespace Test_Algoritmen_en_Datastructuren
{
    /// <summary>
    /// Summary description for TestMyLinkedList
    /// </summary>
    [TestClass]
    public class TestMyLinkedList
    {
        [TestMethod]
        public void AanmakenLegeLinkedList_GetMoetNullRetourneren()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            Assert.IsNull(myLinkedList.getFirst());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void AanmakeLinkedListEnTekstPlaatsenOpPositieEen_VerwachtExceptie()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.insert(1, "test");
        }

        [TestMethod]
        public void AanmakenLinkedListEnTweeItemsToevoegenMetAddFirst_GetFirstMoetTweedeItemRetourneren()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.addFirst("eerste toevoeging");
            string expectedResult = "tweede toevoeging";
            myLinkedList.addFirst(expectedResult);
            Assert.AreEqual(expectedResult,myLinkedList.getFirst());
        }

        [TestMethod]
        public void AanmakenLinkedListDrieItemsToevoegenEenItemVerwijderenEnEenItemToevoegen_GetFirstMoetTweedeItemRetourneren()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.addFirst("eerste toevoeging");
            string expectedResult = "tweede toevoeging";
            myLinkedList.addFirst(expectedResult);
            myLinkedList.addFirst("derde toevoeging");
            myLinkedList.removeFirst();
            Assert.AreEqual(expectedResult, myLinkedList.getFirst());
        }

        [TestMethod]
        public void AanmakenLinkedListDrieItemsToevoegenEnLijstLeegmaken_GetFirstMoetNullRetourneren()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.addFirst("eerste toevoeging");
            myLinkedList.addFirst("tweede toevoeging");
            myLinkedList.addFirst("derde toevoeging");
            myLinkedList.clear();
            Assert.IsNull(myLinkedList.getFirst());
        }

        [TestMethod]
        public void AanmakenLinkedListMetEigenObjectDrieItemsToevoegenEnEenVerwijderen_GetFirstMoetTweedeObjectRetourneren()
        {
            MyLinkedList<TestObject> myLinkedList = new MyLinkedList<TestObject>();
            myLinkedList.addFirst(new TestObject("Eerste object",1));
            TestObject expectedResult = new TestObject("Tweede object", 2);
            myLinkedList.addFirst(expectedResult);
            myLinkedList.addFirst(new TestObject("Derde object", 3));
            myLinkedList.removeFirst();
            Assert.AreEqual(expectedResult, myLinkedList.getFirst());
        }

        [TestMethod]
        public void AanmakenLinkedListTweeItemsToevoegenEnVerwijderen_GetFirstMoetNullRetourneren()
        {
            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.addFirst("1e tekst");
            myLinkedList.addFirst("2e tekst");
            myLinkedList.removeFirst();
            myLinkedList.removeFirst();
            Assert.IsNull(myLinkedList.getFirst());
        }

        [TestMethod]
        public void AanmakenLinkedListVierItemsToevoegenItemInsertenOpDerdePositieEnEersteTweeVerwijderen_GetFirstMoetEerstGeinserteItemRetournerenEnDaarnaDeAndereVerwachteResultaten()
        {
            MyLinkedList<int> myLinkedList = new MyLinkedList<int>();
            int expectedResult1 = 5;
            int expectedResult2 = 2;
            int expectedResult3 = 1;
            myLinkedList.addFirst(expectedResult3);
            myLinkedList.addFirst(expectedResult2);
            myLinkedList.addFirst(3);
            myLinkedList.addFirst(4);
            myLinkedList.insert(2, expectedResult1);
            myLinkedList.removeFirst();
            myLinkedList.removeFirst();
            Assert.AreEqual(expectedResult1,myLinkedList.getFirst());
            // Ter controle kijken we ook of de rest van de lijst klopt als verwacht
            myLinkedList.removeFirst();
            Assert.AreEqual(expectedResult2, myLinkedList.getFirst());
            myLinkedList.removeFirst();
            Assert.AreEqual(expectedResult3, myLinkedList.getFirst());
        }

    }

    #pragma warning disable CS0659 // disable warning about not overriding GetHashCode()
    public class TestObject
    {
        public string testString { get; set; }
        public int testInt { get; set; }

        public TestObject(string testString, int testInt)
        {
            this.testString = testString;
            this.testInt = testInt;
        }

        public override bool Equals(object obj)
        {
            var @object = obj as TestObject;
            return @object != null &&
                   testString == @object.testString &&
                   testInt == @object.testInt;
        }
    }
}
