using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Lib
{
        public interface Calculator_funcs<T>
        {
            
            T Addition(T a, T b);
            T Subtraction(T a, T b);
            T Multiplication(T a, T b);
            T Division(T a, T b);
        }       
}
