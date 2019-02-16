using Algoritmen_en_Datastructuren.Interface;
using System;


/*
Implementeer een eenvoudige klasse MyArrayList waarin alleen getallen
kunnen worden opgeslagen, waarbij je onderstaande interface implementeert.
Intern wordt een primitieve array bijgehouden. De list heeft een vaste capaciteit
(grootte van de interne array) die wordt meegegeven aan de constructor. Deze
capaciteit kan dus niet meer veranderen! Controleer op ongeldige bewerkingen
en gooi zo nodig exceptions. Schrijf testcode om alle methodes te testen.
Probeer eerst zelf de klasse te maken voor je het boek erbij pakt.
*/
namespace Algoritmen_en_Datastructuren
{
    public class MyArrayList : SimpleArrayList
    {

        private const string errorIndexGreaterThenMaxSize = "Index cannot be greater then the maximum size";
        private int?[] _myIntArray;
        private int _maxSize;

        public MyArrayList(int size)            // O(1)
        {
            if (size < 1) throw new ArgumentOutOfRangeException("Minimum size for an array is 1");
            _maxSize = size;
            clear();
        }

        public void add(int n)                  // O(N)
        {
            int stepper = 0;
            Boolean added = false;
            do
            {
                if(_myIntArray[stepper] == null)
                {
                    _myIntArray[stepper] = n;
                    added = true;
                }
                stepper++;
            } while (!added && stepper < _maxSize);
            if (!added) throw new ArgumentOutOfRangeException("Cannot add integer to a full array");
        }

        public void clear()                     // O(N), geen nieuwe initialisatie ivm geheugengebruik!
        {
            for(int stepper=0; stepper<_maxSize; stepper++)
            {
                _myIntArray[stepper] = null;
            }
        }

        public int countOccurences(int n)       // O(N)
        {
            int counter = 0;
            for(int stepper=0; stepper < _maxSize; stepper++)
            {
                if (_myIntArray[stepper] == n) counter++;
            }
            return counter;
        }

        public int get(int index)               // O(1)
        {
            if(_maxSize <= index) throw new ArgumentOutOfRangeException(errorIndexGreaterThenMaxSize);
            return _myIntArray[index] != null ? (int) _myIntArray[index] : throw new NullReferenceException("The value NULL has been found");
        }

        public void print()                     // O(N)
        {
            for(int stepper=0;stepper<_maxSize;stepper++)
            {
                if (_myIntArray[stepper] != null) Console.WriteLine((int)_myIntArray[stepper]);
            }
        }

        public void set(int index, int n)       // O(1)
        {
            if (_maxSize <= index) throw new ArgumentOutOfRangeException(errorIndexGreaterThenMaxSize);
            _myIntArray[index] = n;
        }
    }
}
