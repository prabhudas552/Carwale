using System;
using System.Text;

namespace MyCaclulator
{
    // class to perform string calculation

    class StringCalculator:Calculator
    {
        public override string add(string a, string b)
        {
            return a + b;
        }

        public override string sub(string a, string b)
        {
            if (a.Length < b.Length)
                return "Can not substract..!";
            if (a.Length == b.Length)
                return string.Empty;
            return a.Substring(0, b.Length);
        }

        public override string mul(string a, string b)
        {
            StringBuilder res = new StringBuilder();
            for(int i = 0; i < a.Length; i++)
            {
                res.Append(a[i]).Append(b);
            }
            return res.ToString();
        }

        public override string div(string a, string b)
        {
            int l = b.Length;
            int p = a.IndexOf(b);
            if (p != -1)
            {
                StringBuilder str = new StringBuilder(a);
                str.Remove(p, l);
                //Console.WriteLine(str);
                return str.ToString();
            }
            return "Can Not Divide..!";
        }

        public override bool validateOpearands(string a, string b)
        {
            return true;
        }
    }
}
