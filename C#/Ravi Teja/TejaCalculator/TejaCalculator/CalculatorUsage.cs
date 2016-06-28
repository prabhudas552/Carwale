using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaviCalculator;

namespace TejaCalculator
{
    public class CalculatorUsage
    {
        static void Main(string[] args)
        {
            ICalculator<string> ic = new StringCalculator();

            string b = ic.Div("11", "22");

            Console.WriteLine("hello "+b);

            string s1 = "raviteja";
            string s2 = "ravi";

            Console.WriteLine(s1.Replace(s2,""));

            Console.Read();
        }
    }
}
