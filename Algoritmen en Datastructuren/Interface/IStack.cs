using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritmen_en_Datastructuren.Interface
{
    public interface IStack<T>
    {
        void Push(T data);
        T Pop();
        T Top();
    }
}
