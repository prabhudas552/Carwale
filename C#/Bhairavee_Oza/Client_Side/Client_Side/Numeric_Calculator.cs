using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Lib;

namespace Calculator
{
        public class Numeric_Calculator : Calculator_funcs<string>
        {
            private int first_number, second_number;
            public Numeric_Calculator()
            {
                Console.WriteLine("Welcome to Numeric Calculator!");
            }
            public string Addition(string a, string b)
            {
                try
                {
                    first_number = Convert.ToInt32(a);
                    second_number = Convert.ToInt32(b);
                }
                
                catch(Exception ex)
                {
                    Console.WriteLine("Caught Exception!: ", ex);
                }
                return Convert.ToString(first_number + second_number);
            }

            public string Subtraction(string a, string b)
            {
                try
                {
                    first_number = Convert.ToInt32(a);
                    second_number = Convert.ToInt32(b);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Caught Exception!: ", ex);
                }
                return Convert.ToString(first_number - second_number);
            }

            public string Multiplication(string a, string b)
            {
                try
                {
                    first_number = Convert.ToInt32(a);
                    second_number = Convert.ToInt32(b);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Caught Exception!: ", ex);
                }
                return Convert.ToString(first_number * second_number);
            }

            public string Division(string a, string b)
            {
                try
                {
                    first_number = Convert.ToInt32(a);
                    second_number = Convert.ToInt32(b);
                }

                catch (Exception ex)
                {
                    Console.WriteLine("Caught Exception!: ", ex);
                }
                return Convert.ToString(first_number / second_number);
            }
        }
        
    }
