using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_3_2
    {
        public Opgave_3_2(int aantalElementen = 35)
        {
            int uitkomstRecursief;
            int uitkomstNietRecursief;
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            uitkomstRecursief = Fibonacci_recursief(aantalElementen);
            stopwatch.Stop();
            Console.WriteLine($"Recursief berekenen van {aantalElementen} elementen met uitkomst {uitkomstRecursief} heeft in totaal {stopwatch.Elapsed} ms. in beslag genomen.");
            stopwatch.Restart();
            uitkomstNietRecursief = Fibonacci_nietrecursief(aantalElementen);
            stopwatch.Stop();
            Console.WriteLine($"Niet recursief berekenen van {aantalElementen} elementen met uitkomst {uitkomstNietRecursief} heeft in totaal {stopwatch.Elapsed} ms. in beslag genomen.");


        }

        private int Fibonacci_recursief(int aantalElementen)
        {
            if (aantalElementen <= 1)
            {
                return aantalElementen;
            }
            else
            {
                return Fibonacci_recursief(aantalElementen - 1) + Fibonacci_recursief(aantalElementen - 2);
            }
        }

        private int Fibonacci_nietrecursief(int aantalElementen)
        {
            if (aantalElementen <= 1) return aantalElementen;
            int elementLaag = 0;
            int elementHoog = 1;
            int elementTemp = 0;
            for(int stepper=2;stepper<=aantalElementen;stepper++)
            {
                elementTemp = elementLaag;
                elementLaag = elementHoog;
                elementHoog += elementTemp;
            }
            return elementHoog;
        }
    }
}
