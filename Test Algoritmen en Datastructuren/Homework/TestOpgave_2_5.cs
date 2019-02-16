using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algoritmen_en_Datastructuren;

namespace Test_Algoritmen_en_Datastructuren.Homework
{
    /// <summary>
    /// Summary description for TestOpgave_2_5
    /// </summary>
    [TestClass]
    public class TestOpgave_2_5
    {
        [TestMethod]
        public void TestOpgave25()
        {
            MyQueue myQueueOfDefault = new MyQueue(); // DEFAULT QUEUE LENGTH IS 10
            //Fill the entire queue
            for(int counter=0;counter<10;counter++)
            {
                myQueueOfDefault.enqueue(counter);
            }
            for (int counter = 0; counter < 10; counter++)
            {
                Assert.AreEqual(counter, myQueueOfDefault.dequeue());
            }
            Assert.IsNull(myQueueOfDefault.dequeue());
            Assert.IsTrue(myQueueOfDefault.isEmpty());
            for (int counter = 0; counter < 10; counter++)
            {
                myQueueOfDefault.enqueue(counter);
            }
            myQueueOfDefault.clear();
            Assert.IsNull(myQueueOfDefault.dequeue());
            Assert.IsTrue(myQueueOfDefault.isEmpty());
            for (int counter = 0; counter < 10; counter++)
            {
                myQueueOfDefault.enqueue(counter);
            }
            for (int counter = 0; counter < 5; counter++)
            {
                Assert.AreEqual(counter, myQueueOfDefault.dequeue());
            }
            for (int counter = 5; counter < 10; counter++)
            {
                myQueueOfDefault.enqueue(counter+10);
            }
            for (int counter = 0; counter < 5; counter++)
            {
                Assert.AreEqual(counter+5, myQueueOfDefault.dequeue());
            }
            for (int counter = 5; counter < 9; counter++)
            {
                Assert.AreEqual(counter+10, myQueueOfDefault.dequeue());
            }
            Assert.IsFalse(myQueueOfDefault.isEmpty());
            Assert.AreEqual(19, myQueueOfDefault.dequeue());
            Assert.IsTrue(myQueueOfDefault.isEmpty());
            Assert.IsNull(myQueueOfDefault.dequeue());
        }
    }
}
