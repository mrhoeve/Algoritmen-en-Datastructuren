using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    class Zeef_van_Eratosthenes
    {
        private Stopwatch stopwatch;
        private bool[] zeefFlagged;
        private int zeefSize;
        private int[] foundPrimes;
        private int numberOfPrimes;

        public Zeef_van_Eratosthenes(int size)
        {
            stopwatch = new Stopwatch();
            zeefFlagged = new bool[size];
            foundPrimes = new int[size];        // Way to large, but ok...
            zeefSize = size;
            numberOfPrimes = -1;
        }

        public void StartZeven()
        {
            stopwatch.Start();
            Zeef();
            stopwatch.Stop();
            Console.WriteLine($"Er zijn {numberOfPrimes + 1} gevonden bij het zeven. Dit zijn ze:\n");
            for(int stepper=0;stepper<=numberOfPrimes;stepper++)
            {
                Console.Write($"{foundPrimes[stepper]} ");
            }
            Console.WriteLine($"\n\nIn totaal heeft dit {stopwatch.Elapsed} ms. in beslag genomen.");
            Console.ReadKey();
        }

        private void Zeef()
        {
            int stepper;
            for(int iterator=2;iterator<zeefSize;iterator++)
            {
                if(!zeefFlagged[iterator])
                {
                    numberOfPrimes++;
                    foundPrimes[numberOfPrimes] = iterator;
                    for(stepper=iterator+iterator;stepper<zeefSize;stepper+=iterator)
                    {
                        zeefFlagged[stepper] = true;
                    }
                }
            }
        }
    }
}
