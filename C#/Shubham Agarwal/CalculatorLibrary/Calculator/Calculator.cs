using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorLibrary;

namespace Calculator
{
    class Calculator
    {
        static void Main(String[] args)
        {
            DecimalCalculator _decCal = new DecimalCalculator();
            BinaryCalculator _binCal = new BinaryCalculator();
            StringCalculator _strCal = new StringCalculator();

            while (true)
            {
                bool isWrongInput = true;
                while (isWrongInput)
                {
                    try
                    {
                        isWrongInput = false;
                        Console.WriteLine("Choose calculator type:");
                        Console.WriteLine("1. Binary");
                        Console.WriteLine("2. Decimal");
                        Console.WriteLine("3. String");
                        Console.WriteLine("0. Exit");
                        ConsoleKeyInfo input = Console.ReadKey();
                        switch (input.KeyChar)
                        {
                            case '1':
                                Console.WriteLine("\nEnter Binary Values");
                                string bin1 = Console.ReadLine();
                                string bin2 = Console.ReadLine();
                                performOperation<string>(_binCal, bin1, bin2);
                                break;
                            case '2':
                                Console.WriteLine("\nEnter Decimal Values");
                                decimal dec1 = decimal.Parse(Console.ReadLine());
                                decimal dec2 = decimal.Parse(Console.ReadLine());
                                performOperation<decimal>(_decCal, dec1, dec2);
                                break;
                            case '3':
                                Console.WriteLine("\nEnter String Values");
                                string str1 = Console.ReadLine();
                                string str2 = Console.ReadLine();
                                performOperation<string>(_strCal, str1, str2);
                                break;
                            case '0':
                                Console.WriteLine("\nExiting..");
                                return;
                            default:
                                Console.WriteLine("\nInvalid Input!! try again..\n");
                                isWrongInput = true;
                                break;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Exception: {0}", e.Message);
                    }
                }
            }
        }

        static void performOperation<T>(ICalculator<T> cal, T a, T b)
        {
            Console.WriteLine("Enter operation to perform (+, -, *, /):");
            ConsoleKey op = Console.ReadKey().Key;
            switch (op)
            {
                case ConsoleKey.Add:
                    Console.WriteLine("\nAddition Result: {0}", cal.Add(a, b));
                    break;
                case ConsoleKey.Subtract:
                    Console.WriteLine("\nSubtraction Result: {0}", cal.Subtract(a, b));
                    break;
                case ConsoleKey.Multiply:
                    Console.WriteLine("\nMultiplication Result: {0}", cal.Multiply(a, b));
                    break;
                case ConsoleKey.Divide:
                    Console.WriteLine("\nDivision Result: {0}", cal.Divide(a, b));
                    break;
                default:
                    Console.WriteLine("\nInvalid operation!!\n");
                    break;
            }
        }
    }
}
