using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Interface
{
    interface SimpleArrayList
    {
        // Toevoegen aan het einde van de lijst, mits de lijst niet vol is
        void add(int n);
        // Haal de waarde op van een bepaalde index
        int get(int index);
        // Wijzig een item op een bepaalde index
        void set(int index, int n);
        // Print de inhoud van de list
        void print();
        // Maak de list leeg
        void clear();
        // Tel hoe vaak het gegeven getal voorkomt
        int countOccurences(int n);
    }
}
