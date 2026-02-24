using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Calculator<T>
    {
        public static T Add(T a, T b)
        {
            return (dynamic)a + (dynamic)b;
        }

    }
   
}

 
