using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Interface
{
    interface SimpleLinkedList<T>
    {
        // Voeg een item toe aan het begin van de lijst
        void addFirst(T data);
        void clear();
        void print();
        // Voeg een item in op een bepaalde index (niet overschrijven!)
        void insert(int index, T data);
        // verwijder het eerste item
        void removeFirst();
        // geeft het eerste item terug
        T getFirst();
    }
}
