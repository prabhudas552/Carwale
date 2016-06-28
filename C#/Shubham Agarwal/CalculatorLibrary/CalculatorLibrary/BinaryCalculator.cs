using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class BinaryCalculator : ICalculator<string>
    {

        public string Add(string a, string b)
        {
            int x = Convert.ToInt32(a, 2);
            int y = Convert.ToInt32(b, 2);
            return Convert.ToString(x + y, 2);
        }

        public string Subtract(string a, string b)
        {
            int x = Convert.ToInt32(a, 2);
            int y = Convert.ToInt32(b, 2);
            return Convert.ToString(x - y, 2);
        }

        public string Multiply(string a, string b)
        {
            int x = Convert.ToInt32(a, 2);
            int y = Convert.ToInt32(b, 2);
            return Convert.ToString(x * y, 2);
        }

        public string Divide(string a, string b)
        {
            int x = Convert.ToInt32(a, 2);
            int y = Convert.ToInt32(b, 2);
            return Convert.ToString(x / y, 2);
        }
    }
}
