using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_3_1
    {
        public Opgave_3_1()
        {
            Console.WriteLine(FaculteitNietRecursief(6));
            Console.WriteLine(FaculteitRecursief(6));
        }

        public static int FaculteitRecursief(int getal)
        {
            if (getal == 1) return 1;
            return getal * FaculteitRecursief(getal - 1);
        }

        public static int FaculteitNietRecursief(int getal)
        {
            if (getal == 1) return 1;
            int antwoord = 1;
            for(int teller=2;teller<=getal; teller++)
            {
                antwoord *= teller;
            }
            return antwoord;
        }
    }
}
