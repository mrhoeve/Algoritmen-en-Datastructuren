using Algoritmen_en_Datastructuren.Homework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave_1_5 opgave_1_5 = new Opgave_1_5();
            //opgave_1_5.StartTest();

            //Zeef_van_Eratosthenes zeef = new Zeef_van_Eratosthenes(1000000);
            //zeef.StartZeven();

            MyLinkedList<string> myLinkedList = new MyLinkedList<string>();
            myLinkedList.addFirst("hallo");
            myLinkedList.addFirst("wereld");
            myLinkedList.addFirst("reiziger");
            myLinkedList.insert(3, "beeld");
            myLinkedList.print();
            Console.WriteLine("\n\n\n");
            myLinkedList.removeFirst();
            myLinkedList.print();
            Console.WriteLine("\n\n\n");
            myLinkedList.removeFirst();
            myLinkedList.print();
            Console.ReadKey();
        }
    }
}
