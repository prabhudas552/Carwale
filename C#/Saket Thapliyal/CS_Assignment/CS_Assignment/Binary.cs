using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_lib
{
    public class BinCalculator : ICalculator<String>
    {
        int x, y;
        public String Add(String _val1, String _val2)
        {
            x = Convert.ToInt32(_val1, 2);
            y = Convert.ToInt32(_val2, 2);

            return Convert.ToString(x + y, 2);
        }

        public String Sub(String _val1, String _val2)
        {
            x = Convert.ToInt32(_val1, 2);
            y = Convert.ToInt32(_val2, 2);

            return Convert.ToString(x - y, 2);
        }

        public String Mul(String _val1, String _val2)
        {
            x = Convert.ToInt32(_val1, 2);
            y = Convert.ToInt32(_val2, 2);

            return Convert.ToString(x * y, 2);
        }

        public String Div(String _val1, String _val2)
        {
            x = Convert.ToInt32(_val1, 2);
            y = Convert.ToInt32(_val2, 2);

            return Convert.ToString(x / y, 2);
        }
    }
}
