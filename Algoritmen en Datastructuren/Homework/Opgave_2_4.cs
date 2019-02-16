using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Homework
{
    public class Opgave_2_4
    {
        public bool checkBrackets(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            MyStack<string> myStack = new MyStack<string>();
            int counter = 0;
            while (counter < s.Length)
            {
                if (!string.IsNullOrWhiteSpace(s.Substring(counter, 1)))
                {
                    if (s.Substring(counter, 1) == "(")
                    {
                        myStack.Push(s.Substring(counter, 1));
                    }
                    else
                    {
                        if (myStack.Top() == null || !"(".Equals(myStack.Pop())) return false;

                    }
                }
                counter++;
            }
            // Make sure the stack is empty
            if (myStack.Pop() != null) return false;
            return true;
        }

        public bool checkBrackets2(string s)
        {
            if (string.IsNullOrEmpty(s)) return false;
            MyStack<string> myStack = new MyStack<string>();
            string found = "";
            int counter = 0;
            while (counter < s.Length)
            {
                found = s.Substring(counter, 1);
                if (!string.IsNullOrWhiteSpace(found))
                {
                    if (found == "(" || found == "[")
                    {
                        myStack.Push(s.Substring(counter, 1));
                    }
                    else
                    {
                        if (myStack.Top() == null ||
                            (found == ")" && !"(".Equals(myStack.Pop())) ||
                            (found == "]" && !"[".Equals(myStack.Pop()))
                            ) return false;

                    }
                }
                counter++;
            }
            // Make sure the stack is empty
            if (myStack.Pop() != null) return false;
            return true;
        }

    }
}
