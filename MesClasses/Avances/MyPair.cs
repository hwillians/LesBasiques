using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesClasses.Avances
{
    class MyPair<T, U>
    {
        public T First { get; set; }
        public U Second { get; set; }

        public MyPair(T first, U second)
        {
            First = first;
            Second = second;
        }

        public override string ToString() => $"Value 1 : {First} – Value 2 : {Second}";
    }
}
