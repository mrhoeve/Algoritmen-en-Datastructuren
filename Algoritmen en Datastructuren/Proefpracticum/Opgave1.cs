using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Proefpracticum
{
    public class Opgave1
    {
        public string printLetters(int n)
        {
            if (n == 0) return "";
            if (n == 1) return "AZ";
            return "A" + printLetters(n - 1) + "Z";
        }

        public string printLetters2(int p, int q)
        {
            return printA(p) + printZ(q);
        }

        private string printA(int p)
        {
            if (p == 0) return "";
            if (p == 1) return "A";
            return "A" + printA(p - 1);
        }

        private string printZ(int q)
        {
            if (q == 0) return "";
            if (q == 1) return "Z";
            return "Z" + printZ(q - 1);
        }
    }
}
