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

            Zeef_van_Eratosthenes zeef = new Zeef_van_Eratosthenes(1000);
            //Zeef_van_Eratosthenes zeef = new Zeef_van_Eratosthenes(146435000);
            zeef.StartZeven();
        }
    }
}
