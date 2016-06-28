using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class GetSet
    {
        private int number;
        public int Number { 
            get { return number; } 
            set { number = value;} 
        }
    }

    public class Calculator
    {
        public static void Main(string []args)
        { 
            int choice,op;
            System.Console.WriteLine("Choice\n1. Number Calculator\n2. String Calculator\n3. Binary Calculator ");
            choice = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter your choice \n1. Add \n2. Subtract \n3. Multiply \n4. Divide");
            op = int.Parse(Console.ReadLine());
            //System.Console.Write(op);
            if((choice > 0 && choice < 4) && (op > 0 && op < 5))
            {
                switch (choice)
                {
                    case 1: Digits d = new Digits();
                        // to show the usage of get and set properties 
                        GetSet n1 = new GetSet();
                        GetSet n2 = new GetSet();
                        int res;
                        try
                        {
                            System.Console.WriteLine("Enter first number");
                            n1.Number = int.Parse(Console.ReadLine());
                            System.Console.WriteLine("Enter second number");
                            n2.Number = int.Parse(Console.ReadLine());
                        }
                        catch (Exception e) { Console.WriteLine("{0} Exception caught.", e); System.Console.Read(); }
                        switch (op)
                        {
                            case 1: res = d.Add(n1.Number, n2.Number); System.Console.WriteLine("Addition: " + res); break;
                            case 2: res = d.Subtract(n1.Number, n2.Number); System.Console.WriteLine("Substraction: " + res); break;
                            case 3: res = d.Multiply(n1.Number, n2.Number); System.Console.WriteLine("Multiplication: " + res); break;
                            case 4:
                                try { res = d.Divide(n1.Number, n2.Number); System.Console.WriteLine("Division: " + res); }
                                catch(Exception e) {Console.WriteLine("{0} Exception caught.", e);System.Console.Read(); }
                                break;
                        }
                        break;
                    case 2:
                        Strings s = new Strings();
                        System.Console.WriteLine("Enter first string");
                        string s1 = System.Console.ReadLine();
                        System.Console.WriteLine("Enter second string");
                        string s2 = System.Console.ReadLine();
                        string s3;
                        switch (op)
                        {

                            case 1: s3 = s.Add(s1, s2); System.Console.WriteLine("String Addition: " + s3); break;
                            case 2: s3 = s.Subtract(s1, s2); System.Console.WriteLine("String Subtraction: " + s3); break;
                            case 3: s3 = s.Multiply(s1, s2); System.Console.WriteLine("String Multiplication: " + s3); break;
                            case 4: s3 = s.Divide(s1, s2); System.Console.WriteLine("String Division: " + s3); break;
                        }
                        break;
                    case 3:
                        Digits bin = new Digits();
                        int b1=0, b2=0;
                        try
                        {
                            System.Console.WriteLine("Enter first binary number");
                            b1 = Convert.ToInt32(Console.ReadLine(), 2);
                            System.Console.WriteLine("Enter second binary number");
                            b2 = Convert.ToInt32(Console.ReadLine(), 2);
                        }
                        catch(Exception e) {Console.WriteLine("{0} Exception caught.", e);System.Console.Read(); }
                        string b3;
                        switch (op)
                        {
                            case 1: b3 = Convert.ToString(bin.Add(b1, b2), 2); System.Console.WriteLine("Binary Addition: " + b3); break;
                            case 2: b3 = Convert.ToString(bin.Subtract(b1, b2), 2); System.Console.WriteLine("Binary Subtraction: " + b3); break;
                            case 3: b3 = Convert.ToString(bin.Multiply(b1, b2), 2); System.Console.WriteLine("Binary Multiplication: " + b3); break;
                            case 4: if (b2 != 0)
                                {
                                    b3 = Convert.ToString(bin.Divide(b1, b2), 2); System.Console.WriteLine("Binary Division: " + b3);
                                }
                                else { System.Console.WriteLine("Binary Division not possible-second number is zero"); }
                                break;
                        }
                        break;
                }
            }
            else { System.Console.WriteLine("wrong input"); }

            /*string n=(Console.ReadLine());
            int n1;
            bool i = int.TryParse(n, out n1);
            if (i)
            {
                Digits bin = new Digits(); int a = bin.Add(n1, 2);
                System.Console.WriteLine(a);
            }
            else { System.Console.WriteLine("wrong"); }*/
            System.Console.ReadLine();
        }
    }
}
