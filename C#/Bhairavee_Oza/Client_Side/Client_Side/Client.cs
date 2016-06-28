using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator_Lib;

namespace Calculator
{
    public class Client
    {
        internal string input;
        
        public static void Main()
        {
            Client obj = new Client();
            Dictionary<string, string> Dictionary_symbols = new Dictionary<string, string>()
            {
                {"+","Addition"},
                {"-","Subtraction"},
                {"*","Multiplication"},
                {"/","Division"},
            };
            int flag=0;
            while (true)
            {
                Console.WriteLine("Enter the type of your operators:String,Numeric or Binary or type exit");
                Console.WriteLine(" ");
                string calculator_operator_type = Console.ReadLine();
                if (calculator_operator_type == "exit")
                    break;
                string answer = "";
                while (flag != 1)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Enter your expression to the calculator(*space separated)");
                    Console.WriteLine("type answer as one operand to continue your calculation ");
                    Console.WriteLine("or type switch to change calculator type or type exit");
                    Console.WriteLine(" ");
                    obj.input = Console.ReadLine();
                    Console.WriteLine("You enetered: " + obj.input);
                    Console.WriteLine(" ");
                    if (obj.input == "exit")
                    { flag = 1; break; }
                    if (obj.input == "switch")
                        break;
                    char[] delimiterChars = { ' ' };
                    string[] input_token = obj.input.Split(delimiterChars);
                    if(input_token.Length!=3)
                    {
                        Console.WriteLine("Expression must be of the form: <operand1> <operator> <operand2>");
                        continue;
                    }
                    if (input_token[0] == "answer")
                        input_token[0] = answer;
                    if (input_token[2] == "answer")
                        input_token[2] = answer;
                    switch (calculator_operator_type)
                    {
                        case "String":
                            String_Calculator obj_string = new String_Calculator();
                            string func = Dictionary_symbols[input_token[1]];
                            answer=(string)typeof(String_Calculator).GetMethod(func).Invoke(obj_string,new[] {input_token[0], input_token[2]} );
                            Console.WriteLine(answer);
                            Console.WriteLine(" ");
                            break;
                        case "Numeric":
                            Numeric_Calculator obj_numeric = new Numeric_Calculator();
                            func = Dictionary_symbols[input_token[1]];
                            answer=(string)typeof(Numeric_Calculator).GetMethod(func).Invoke(obj_numeric, new[] { input_token[0], input_token[2] });
                            Console.WriteLine(answer);
                            Console.WriteLine(" ");
                            break;
                        case "Binary":
                            Binary_Calculator obj_binary = new Binary_Calculator();
                            func = Dictionary_symbols[input_token[1]];
                            answer=(string)typeof(Binary_Calculator).GetMethod(func).Invoke(obj_binary, new[] { input_token[0], input_token[2] });
                            Console.WriteLine(answer);
                            Console.WriteLine(" ");
                            break;
                        default:
                            Console.WriteLine("Sorry your inputs didnt match any type");
                            Console.WriteLine(" ");
                            break;
                    }
                }

                if (flag == 1)
                    break;
            }
            Console.WriteLine("Thank you for using for this calculator!");
            Console.WriteLine(" ");
            Console.ReadLine();
        }
    }
 
}
