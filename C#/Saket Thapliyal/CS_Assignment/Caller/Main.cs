using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calc_lib;

namespace CS_Assignment
{
    enum choice { Integer, String, Binary, Exit };

    public class driver
    {

        static void int_call()
        {
            int _int1, _int2;

            IntCalculator _in = new IntCalculator();
            Console.WriteLine("Enter Two Integers");
            if (!(Int32.TryParse(Console.ReadLine(), out _int1)))
            {
                Console.WriteLine("You have not entered a integer");
            }
            else if ((Int32.TryParse(Console.ReadLine(), out _int2)))
            {
                Console.WriteLine("Adding: {0}", _in.Add(_int1, _int2));
                Console.WriteLine("Substracting: {0}", _in.Sub(_int1, _int2));
                Console.WriteLine("Multiplying: {0}", _in.Mul(_int1, _int2));
                Console.WriteLine("Dividing: {0}", _in.Div(_int1, _int2));
            }
            else
            {
                Console.WriteLine("You have not entered a integer");
            }
        }

        static void string_call()
        {
            String _str1, _str2;

            StrngCalculator _st = new StrngCalculator();
            Console.WriteLine("Enter Two Strings");
            if ((_str1 = Console.ReadLine()) == "")
            {
                Console.WriteLine("You have not entered a string");
            }
            else if (!((_str2 = Console.ReadLine()) == ""))
            {
                Console.WriteLine("Adding: {0}", _st.Add(_str1, _str2));
                Console.WriteLine("Substracting: {0}", _st.Sub(_str1, _str2));
                Console.WriteLine("Multiplying: {0}", _st.Mul(_str1, _str2));
                Console.WriteLine("Dividing: {0}", _st.Div(_str1, _str2));
            }
            else
            {
                Console.WriteLine("You have not entered a string");
            }
        }

        static void binary_call()
        {
            String _bin1, _bin2;

            BinCalculator _bn = new BinCalculator();
            Console.WriteLine("Enter Two Binary Numbers");
            if ((_bin1 = Console.ReadLine()) == "")
            {
                Console.WriteLine("You have not entered a Binary number");
            }
            else if (!((_bin2 = Console.ReadLine()) == ""))
            {
                Console.WriteLine("Adding: {0}", _bn.Add(_bin1, _bin2));
                Console.WriteLine("Substracting: {0}", _bn.Sub(_bin1, _bin2));
                Console.WriteLine("Multiplying: {0}", _bn.Mul(_bin1, _bin2));
                Console.WriteLine("Dividing: {0}", _bn.Div(_bin1, _bin2));
            }
            else
            {
                Console.WriteLine("You have not entered a binary number");
            }
        }

        static void Main()
        {

            int _option;
            do
            {
                Console.WriteLine("For integer calculation Enter 0");
                Console.WriteLine("For String calculation Enter 1");
                Console.WriteLine("For Binary calculation Enter 2");
                Console.WriteLine("For Exit Enter 3");
                _option = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("{0}", _option);
                switch (_option)
                {
                    case (Int32)choice.Integer:
                        int_call();
                        break;

                    case (Int32)choice.String:
                        string_call();
                        break;

                    case (Int32)choice.Binary:
                        binary_call();
                        break;

                    case (Int32)choice.Exit:
                        Console.WriteLine("Bye Bye");
                        Console.ReadLine();
                        break;

                    default: Console.WriteLine("You have entered wrong choice");
                        break;
                }

            } while (_option != (Int32)(choice.Exit));

        }


    }

}


