using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_lib
{
    internal interface ICalculator<T>
    {
        T Add(T _val1, T _val2);
        T Sub(T _val1, T _val2);
        T Mul(T _val1, T _val2);
        T Div(T _val1, T _val2);
    }
}
    

    

       

    

