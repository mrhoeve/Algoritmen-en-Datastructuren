using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    class Opgave_3_4
    {
        public Opgave_3_4()
        {
            Console.WriteLine($"numberOfOnes(7) levert als antwoord {numberOfOnes(7)} op.");
            Console.WriteLine($"numberOfOnes(9) levert als antwoord {numberOfOnes(9)} op.");
            Console.WriteLine($"numberOfOnes(19) levert als antwoord {numberOfOnes(19)} op.");
            Console.WriteLine($"numberOfOnes(28) levert als antwoord {numberOfOnes(28)} op.");
            Console.WriteLine($"numberOfOnes(49) levert als antwoord {numberOfOnes(49)} op.");
            Console.WriteLine($"numberOfOnes(63) levert als antwoord {numberOfOnes(63)} op.");
            Console.WriteLine($"numberOfOnes(127) levert als antwoord {numberOfOnes(127)} op.");
            Console.WriteLine($"numberOfOnes(128) levert als antwoord {numberOfOnes(128)} op.");
        }


        private int numberOfOnes(int number)
        {
            if (number <= 1) return number;
            if(number % 2 == 1)
            {
                return 1 + numberOfOnes(number / 2);
            } else
            {
                return numberOfOnes(number / 2);
            }
        }
    }
}
