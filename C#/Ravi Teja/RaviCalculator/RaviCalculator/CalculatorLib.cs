
using System;
using System.Text;
namespace RaviCalculator
{
    public interface ICalculator<T>
    {
        T Add(T a, T b);
        T Sub(T a, T b);
        T Mul(T a, T b);
        T Div(T a, T b);
    }


    public class IntCalculator : ICalculator<int>
    {

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }

        public int Div(int a, int b)
        {
            return a / b;
        }
    }

    public class BinCalculator : ICalculator<string>
    {

        public string Add(string a, string b)
        {
            try
            {
                int a1 = Convert.ToInt32(a, 2);
                int b1 = Convert.ToInt32(b, 2);
                return Convert.ToString(a1 + b1, 2);
            }
            catch (Exception e)
            {
                throw new Exception("Non Binary Error");
            }
        }

        public string Sub(string a, string b)
        {
            try
            {
                int a1 = Convert.ToInt32(a, 2);
                int b1 = Convert.ToInt32(b, 2);
                if (a1 < b1)
                {
                    return Convert.ToString(b1 - a1, 2);
                }
                return Convert.ToString(a1 - b1, 2);
            }
            catch (Exception e)
            {
                throw new Exception("Non Binary Error");
            }
        }

        public string Mul(string a, string b)
        {
            try
            {
                int a1 = Convert.ToInt32(a, 2);
                int b1 = Convert.ToInt32(b, 2);

                return Convert.ToString(a1 * b1, 2);
            }
            catch (Exception e)
            {
                throw new Exception("Non Binary Error");
            }
        }

        public string Div(string a, string b)
        {
            try
            {

                int a1 = Convert.ToInt32(a, 2);
                int b1 = Convert.ToInt32(b, 2);

                return Convert.ToString(a1 / b1, 2);
            }
            catch (Exception e)
            {
                throw new Exception("Non Binary Error");
            }
        }
    }

    public class StringCalculator : ICalculator<string>
    {

        public string Add(string a, string b)
        {
            return a + b;
        }

        public string Sub(string a, string b)
        {
            return a.Replace(b, "");
        }

        public string Mul(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char ch in a)
            {
                sb.Append(ch);
                sb.Append(b);
            }
            return sb.ToString();

        }

        public string Div(string a, string b)
        {
            foreach (char ch in b)
            {
                int x = a.IndexOf(ch);
                if (x >= 0)
                    a = a.Remove(x, 1);
            }
            return a;
        }
    }
}
