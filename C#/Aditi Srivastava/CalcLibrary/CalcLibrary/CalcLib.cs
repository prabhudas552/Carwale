﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLibrary
{

   public interface ICalculatorInterface<T> 
    {
         T Add (T a, T b);
         T Sub(T a, T b);
          T Mul(T a, T b);
          T Div(T a, T b);
        

    }

    
    
}
