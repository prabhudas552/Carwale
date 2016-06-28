using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Lib;

namespace Calculator
{
    public class String_Calculator : Calculator_funcs<string>
    {
        public String_Calculator()
            {
                Console.WriteLine("Welcome to String Calculator!");
            }
        public string Addition(string a, string b) // Addition implies concatenation of strings 
        {
            if (a == null)
                return b;
            else if (b == null)
                return a;
            else return a + b;
        }
        public string Subtraction(string a, string b) // Subtraction implies removing substring b from a if b is a substring of a
        {
            if (b == null)
                return a;
            if (a == null)
                return b;
            return (a.Replace(b, ""));
        }
        public string Multiplication(string a, string b)//Multiplication: string a="AB" and string b="CD" then output="ACDBCD"
        {
            var char_array = a.ToCharArray();
            int len = char_array.Length;
            StringBuilder myStringBuilder = new StringBuilder();
            for (int ctr = 0; ctr < len; ++ctr)
            {
                myStringBuilder.Append(char_array[ctr]).Append(b);
            }
            return myStringBuilder.ToString();
        }
        public string Division(string a, string b)//Division implies removing common characters of a and b from a
        {
            if (b == null)
                return a;
            if (a == null)
                return null;
            var char_array_of_a = a.ToCharArray();
            var char_array_of_b = b.ToCharArray();
            StringBuilder myStringBuilder = new StringBuilder();
            int len_a = char_array_of_a.Length;
            int len_b = char_array_of_b.Length;
            int flag = 0, ctr1, ctr2;
            for (ctr1 = 0; ctr1 < len_a; ++ctr1)
            {
                for (ctr2 = 0; ctr2 < len_b; ++ctr2)
                {
                    if (char_array_of_a[ctr1] == char_array_of_b[ctr2])
                    { flag = 1; break; }
                }
                if (flag == 0)
                    myStringBuilder.Append(char_array_of_a[ctr1]);
                else flag = 0;
            }
            return myStringBuilder.ToString();
        }
    }
}
