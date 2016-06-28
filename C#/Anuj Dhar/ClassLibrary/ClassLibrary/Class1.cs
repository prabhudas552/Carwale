using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public interface Calculator<T>
    {
        T add(T var1, T var2);
        T sub(T var1, T var2);
        T mul(T var1, T var2);
        T div(T var1, T var2);
    }

    public class ClassInteger : Calculator<int>
    {

        public int add(int var1, int var2)
        {
            Console.Write("Your result is : ");
            Console.Write(var1 + var2);
            return 1;
        }

        public int sub(int var1, int var2)
        {
            Console.Write("Your result is : ");
            Console.Write(var1 - var2);
            return 1;
        }

        public int mul(int var1, int var2)
        {
            Console.Write("Your result is : ");
            Console.Write(var1 * var2);
            return 1;
        }

        public int div(int var1, int var2)
        {
            Console.Write("Your result is : ");
            if (var2 == 0)
            {
                Console.Write("Please inout a valid denominator");
                return 0;
            }
            Console.Write(var1 / var2);
            return 1;
        }
    }

    public class ClassString : Calculator<string>
    {
        public string add(string var1, string var2)
        {
            string result = null;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append(var1);
            sb.Append(var2);
            result = sb.ToString();
            return result;
        }

        public string sub(string var1, string var2)
        {
            if (var1 == "")
                return ("Please input a valid first string");
            int index = var1.IndexOf(var2);
            string result = var1;
            if(index >= 0)
                result = var1.Remove(index, var2.Length);
            return result;
        }

        public string mul(string var1, string var2)
        {
            if (var1 == "" && var2 == "")
                return ("Please input atleast one valid string");
            if (var1 == "")
                return var2;
            if (var2 == "")
                return var1;
            char[] arr1 = var1.ToCharArray();
            int i;
            int arr1_length = arr1.Length;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (i = 0; i < arr1_length; i++)
            {
                sb.Append(arr1[i]);
                sb.Append(var2);
            }
            return (sb.ToString());
        }

        public string div(string var1, string var2)
        {
            if (var1 == "")
                return ("Please input a valid first string");
            if (var2 == "")
                return var1;
            string result = null;
            foreach (char ch in var2 )
            {
                if (var1.IndexOf(ch) >= 0)
                {
                    result = var1.Remove(var1.IndexOf(ch), 1);
                    var1 = result;
                }
            }
            return (result);
        }
    }

    public class ClassBinary : Calculator<string>
    {
        public string add(string var1, string var2)
        {
            if (var1 == "" && var2 == "")
                return ("Please input atleast one valid binary number");
            if (var1 == "")
                return var2;
            if (var2 == "")
                return var1;
            int num1 = Convert.ToInt32(var1, 2);
            int num2 = Convert.ToInt32(var2, 2);
            string result = Convert.ToString(num1 + num2, 2);
            return result;
        }

        public string sub(string var1, string var2)
        {
            if (var1 == "")
                return ("Please input a valid first string");
            if (var2 == "")
                return var1;
            int num1 = Convert.ToInt32(var1, 2);
            int num2 = Convert.ToInt32(var2, 2);
            string result;
            if(num1 > num2)
            {
                result = Convert.ToString(num1 - num2, 2);
            }
            else
            {
                result = Convert.ToString(num2 - num1, 2);
            }
            return result;
        }

        public string mul(string var1, string var2)
        {
            if (var1 == "" && var2 == "")
                return ("Please input atleast one valid binary number");
            if (var1 == "")
                return var2;
            if (var2 == "")
                return var1;
            int num1 = Convert.ToInt32(var1, 2);
            int num2 = Convert.ToInt32(var2, 2);
            string result = Convert.ToString(num1 * num2, 2);
            return result;
        }

        public string div(string var1, string var2)
        {
            if (var1 == "")
                return ("Please input a valid first string");
            if (var2 == "")
                return var1;
            int num1 = Convert.ToInt32(var1, 2);
            int num2 = Convert.ToInt32(var2, 2);
            string result = Convert.ToString(num1 / num2, 2);
            return result;
        }
    }
}
