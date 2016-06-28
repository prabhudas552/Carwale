using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_lib
{
     public class IntCalculator : ICalculator<decimal>
    {

        public decimal Add(decimal _val1, decimal _val2)
        {
            return _val1 + _val2;
        }

        public decimal Sub(decimal _val1, decimal _val2)
        {
            return _val1 - _val2;
        }

        public decimal Mul(decimal _val1, decimal _val2)
        {
            return _val1 * _val2;
        }

        public decimal Div(decimal _val1, decimal _val2)
        {
            return _val1 / _val2;
        }

    }
}
