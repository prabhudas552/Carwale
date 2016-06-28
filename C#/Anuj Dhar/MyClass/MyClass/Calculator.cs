using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace MyClass
{
    public class Calculator
    {
        static void Main(string[] args)
        {
            Calculator<int> c1 = new ClassInteger();
            Calculator<string> c2 = new ClassString();
            Calculator<string> c3 = new ClassBinary();
            Console.WriteLine("Input the type of parameters you want to operate on : string, int, binary");
            string type = Console.ReadLine();
            Console.WriteLine("Input the parameters you want to operate on :");
            if(type == "string")
            {
                string var1 = Console.ReadLine();
                string var2 = Console.ReadLine();
                Console.WriteLine("Input the operation you want to perform on the parameters : add, subtract, multiply, divide");
                string operate = Console.ReadLine();
                string result;
                switch(operate)
                {
                    case "add":
                        result = c2.add(var1, var2);
                        break;
                    case "subtract":
                        result = c2.sub(var1, var2);
                        break;
                    case "multiply":
                        result = c2.mul(var1, var2);
                        break;
                    default:
                        result = c2.div(var1, var2);
                        break;
                }
                Console.Write("Your result is : ");
                Console.Write(result);
            }
            else if(type == "int")
            {
                string input1 = Console.ReadLine();
                string input2 = Console.ReadLine();
                int var1, var2;
                if (input1 == "")
                    var1 = 0;
                else
                    var1 = Convert.ToInt32(input1);
                if (input2 == "")
                    var2 = 0;
                else
                    var2 = Convert.ToInt32(input2);
                Console.WriteLine("Input the operation you want to perform on the parameters : add, subtract, multiply, divide");
                string operate = Console.ReadLine();
                int result;
                switch (operate)
                {
                    case "add":
                        result = c1.add(var1, var2);
                        break;
                    case "subtract":
                        result = c1.sub(var1, var2);
                        break;
                    case "multiply":
                        result = c1.mul(var1, var2);
                        break;
                    default:
                        result = c1.div(var1, var2);
                        break;
                }
                
            }
            else
            {
                string var1 = Console.ReadLine();
                string var2 = Console.ReadLine();
                Console.WriteLine("Input the operation you want to perform on the parameters : add, subtract, multiply, divide");
                string operate = Console.ReadLine();
                string result;
                switch (operate)
                {
                    case "add":
                        result = c3.add(var1, var2);
                        break;
                    case "subtract":
                        result = c3.sub(var1, var2);
                        break;
                    case "multiply":
                        result = c3.mul(var1, var2);
                        break;
                    default:
                        result = c3.div(var1, var2);
                        break;
                }
                Console.Write("Your result is : ");
                Console.Write(result);
            }
            Console.Read();
        }
    }
}
