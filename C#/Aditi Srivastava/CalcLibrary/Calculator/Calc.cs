using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLibrary;

namespace Calculator

{
    public class Options
    {
        public int choice;
       internal int Choice()
        {
            
            Console.WriteLine("Pick an operation");
            Console.WriteLine("1.Add");
            Console.WriteLine("2.Subtract");
            Console.WriteLine("3.Multiply");
            Console.WriteLine("4.Divide");
            Console.WriteLine(); 
           try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                return 0;
            }
           
            return choice;
        }
    }

    

 class CalcInt : ICalculatorInterface<int>
    {
     
     
       public int Add(int a, int b)
        {
            
            return a+b;
        }
       public int Sub(int a, int b)
        {
            return (a - b);
        }
       public int Mul(int a, int b)
        {
            
            return (a*b);
        }
       public int Div(int a, int b)
       {

           if (b != 0)
               return (a / b);
           else
           {
               Console.WriteLine("Cannot divide by zero");
               Console.WriteLine();
               return Int16.MaxValue; ;
           }
       }




    }

    class CalcString : ICalculatorInterface<StringBuilder>
    {
        public StringBuilder Add(StringBuilder a, StringBuilder b)
        {
            return a.Append(b);
        }
        public StringBuilder Sub(StringBuilder a, StringBuilder b)
        {
            StringBuilder c=new StringBuilder();
            string sa, sb;
            sa=Convert.ToString(a);
            sb=Convert.ToString(b);
            if (sa.IndexOf(sb) > -1)
                c.Append(sa.Remove(sa.IndexOf(sb), sb.Length));
            else
                c.Append(a);
            return c;
        }
        public StringBuilder Mul(StringBuilder a, StringBuilder b)
        {
            int aLen, bLen, i, j;
            StringBuilder c = new StringBuilder();
            aLen = a.Length;
            bLen = b.Length;
            for (i = 0; i < aLen; i++)
            {
                c.Append(a[i]);
                for (j = 0; j < bLen; j++)
                {
                    c.Append(b[j]);
                }
            }
            return c;
        }

        public StringBuilder Div(StringBuilder a, StringBuilder b)
        {
      
           
            StringBuilder c = new StringBuilder();
            String sA, sB;
            sA=Convert.ToString(a);
            sB=Convert.ToString(b);
            if (sA.IndexOf(sB) > -1)
                c.Append(sA.Remove(sA.IndexOf(sB), sB.Length));
            else
                c.Append("Cannot divide");
            return c;
        }
    }

    class CalcBin : ICalculatorInterface<string>
    {
        public string Add(string a,string b)
        {
            int intA, intB;
            try
            {
                intA = Convert.ToInt32(a, 2);
                intB = Convert.ToInt32(b, 2);

                return (Convert.ToString((intA + intB), 2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                return "Nothing";
            }
        }
        public string Sub(string a, string b)
        {
            int intA, intB;
            try
            {
                intA = Convert.ToInt32(a, 2);
                intB = Convert.ToInt32(b, 2);
                return (Convert.ToString((intA - intB), 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                return "Nothing";
            }
            }

        public string Mul(string a, string b)
        {
            int intA, intB;
            try
            {
                intA = Convert.ToInt32(a, 2);
                intB = Convert.ToInt32(b, 2);
                return (Convert.ToString((intA * intB), 2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                return "Nothing";
            }
        }
        public string Div(string a, string b)
        {
            int intA, intB;
            try
            {
                intA = Convert.ToInt32(a, 2);
                intB = Convert.ToInt32(b, 2);
                if (intB != 0)
                    return (Convert.ToString((intA / intB), 2));
                else
                {
                    Console.WriteLine("Cannot divide by zero");
                    Console.WriteLine();
                    return "Error";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                return "Nothing";
            }
        }
    }




    public class Calc
    {
        static void Main()
        {
            int op, num;
           String sel;
            String res;
            
            Options cal = new Options(); 
            restart:
            Console.WriteLine();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1.Number Calculator");
            Console.WriteLine("2.String Calculator");
            Console.WriteLine("3.Binary Calculator");

            try
            {
                op = int.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine();
                goto restart;
            }
            num = cal.Choice();
            if (num == 0)
            {
                Console.WriteLine("Error in selecting option!");
                Console.WriteLine();
                num = cal.Choice();
            }
            switch (op)
            {
                case 1: 
                    int a, b;
                    Console.WriteLine("Enter two numbers");
                    try
                    {
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                        Console.WriteLine();
                        a = 0;
                        b = 0;
                    }
                   
                    CalcInt c = new CalcInt();
                    switch (num)
                    {
                        case 1:
                            
                            Console.WriteLine("Answer: "+c.Add(a,b));
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Answer: "+c.Sub(a, b));
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Answer: "+c.Mul(a, b));
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Answer: "+c.Div(a, b));
                            Console.ReadKey();
                            break;
                        default: Console.WriteLine("Invalid Choice!");
                            break;
                    }

                    break;

                 case 2:

                    StringBuilder strA=new StringBuilder(); 
                    StringBuilder strB=new StringBuilder();
                    Console.WriteLine("Enter two strings");
                    strA.Append(Console.ReadLine());
                    strB.Append(Console.ReadLine());
                    CalcString strC = new CalcString();
                    switch (num)
                    {
                        case 1:
                            
                            Console.WriteLine("Answer: "+strC.Add(strA,strB));
                            Console.ReadKey();
                            break;
                        case 2:
                            Console.WriteLine("Answer: " + strC.Sub(strA, strB));
                            Console.ReadKey();
                            break;
                        case 3:
                            Console.WriteLine("Answer: " + strC.Mul(strA, strB));
                            Console.ReadKey();
                            break;
                        case 4:
                            Console.WriteLine("Answer: " + strC.Div(strA, strB));
                            Console.ReadKey();
                            break;
                        default: Console.WriteLine("Invalid Choice!");
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("Enter two binary values");
                    
                    
                    string binA, binB;

                    binA = Console.ReadLine();
                    binB = Console.ReadLine();
                    CalcBin binC = new CalcBin();
                    switch (num)
                    {
                        case 1:
                            res = binC.Add(binA, binB);
                            break;
                        case 2:
                            res=binC.Sub(binA, binB);
                           
                            break;
                        case 3:
                            res = binC.Mul(binA, binB);
                          break;
                        case 4:
                            res= binC.Div(binA, binB);
                            
                            break;
                        default: Console.WriteLine("Invalid Choice");
                            res="No answer!";
                            break;
                    }
                     Console.WriteLine("Answer: " + res);
                            
                                   
                    break;
                default: Console.WriteLine("Invalid option!");

                    break;
            }

            Console.WriteLine("Press y to continue; Enter to exit");
            sel = (Console.ReadLine());
            if (sel == "y" || sel == "Y")
                goto restart;
            else
                Environment.Exit(0);
                
        }
    }
}
