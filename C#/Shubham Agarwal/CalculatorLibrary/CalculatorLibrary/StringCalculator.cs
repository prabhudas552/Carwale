using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary
{
    public class StringCalculator : ICalculator<string>
    {

        public string Add(string a, string b)
        {
            return a + b;
        }

        public string Subtract(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in a)
            {
                if (!b.Contains(c.ToString()))
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public string Multiply(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in a)
            {
                sb.Append(c);
                sb.Append(b);
            }
            return sb.ToString();
        }

        public string Divide(string a, string b)
        {
            int index = a.IndexOf(b);
            if (index >= 0)
            {
                a = a.Remove(index, b.Length);
            }
            return a;
        }
    }
}
