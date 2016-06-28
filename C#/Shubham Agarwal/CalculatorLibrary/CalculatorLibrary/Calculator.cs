﻿using System;
using System.Text;
using System.Collections.Generic;

namespace CalculatorLibrary
{
    public interface ICalculator<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }
}
