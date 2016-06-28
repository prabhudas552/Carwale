using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Lib;

namespace Calculator
{
    public class Binary_Calculator : Calculator_funcs<string>
    {
        private int binary_first;
        private int binary_second;
        public Binary_Calculator()
        {
            Console.WriteLine("Welcome to Binary Calculator!");
        }
        public string Addition(string a, string b)
        {
            try
            {
                binary_first = Convert.ToInt32(a, 2);
                binary_second = Convert.ToInt32(b, 2);
                return Convert.ToString(binary_first + binary_second, 2);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Caught!: ", ex);
                return "0";
            }
        }

        public string Subtraction(string a, string b)
        {
            try
            {
                binary_first = Convert.ToInt32(a, 2);
                binary_second = Convert.ToInt32(b, 2);
                return Convert.ToString(binary_first - binary_second, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught!: ", ex);
                return "0";
            }
        }

        public string Multiplication(string a, string b)
        {
            try
            {
                binary_first = Convert.ToInt32(a, 2);
                binary_second = Convert.ToInt32(b, 2);
                return Convert.ToString(binary_first * binary_second, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught!: ", ex);
                return "0";
            }
        }

        public string Division(string a, string b)
        {
            try
            {
                binary_first = Convert.ToInt32(a, 2);
                binary_second = Convert.ToInt32(b, 2);
                return Convert.ToString(binary_first + binary_second, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Caught!: ", ex);
                return "0";
            }
        }
    }
}
