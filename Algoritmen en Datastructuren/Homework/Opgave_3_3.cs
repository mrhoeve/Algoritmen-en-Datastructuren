using System;

namespace Algoritmen_en_Datastructuren.Homework
{
    class Opgave_3_3
    {
        public Opgave_3_3()
        {
            Console.WriteLine($"f(5) = {f(5)}");
            Console.WriteLine($"f(6) = {f(6)}");
            Console.WriteLine($"f(7) = {f(7)}");
        }

        private int f(int nummer)
        {
            if (nummer < 1) return 0;
            return f(nummer - 2) + nummer;
        }
    }
}
