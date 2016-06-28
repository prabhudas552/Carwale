using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc_lib
{
    public class StrngCalculator : ICalculator<String>
    {

        public String Add(String _val1, String _val2) // add second string at the end of first string
        {
            return _val1 + _val2;
        }

        public String Sub(String _val1, String _val2) //Remove each appearance of each characters of second string from first string
        {
            char[] charAry = _val2.ToCharArray();
            string returnString = _val1;
            foreach (char c in charAry)
            {
                while (returnString.IndexOf(c) > -1)
                {
                    returnString = returnString.Remove(returnString.IndexOf(c), 1);
                }
            }
            return returnString;
        }

        public String Mul(String _val1, String _val2) //append second string after each character of first string
        {
            StringBuilder _sb = new StringBuilder(_val1);

            int length = Convert.ToInt32(_val1.Length);
            int length2 = Convert.ToInt32(_val2.Length);
            for (int i = 0; i < length; i++)
            {
                _sb.Insert((length2 * i) + i + 1, _val2);
            }

            return _sb.ToString();
        }

        public String Div(String _val1, String _val2) //remove second string from first string
        {
            String _res = "";
            if (_val1.Contains(_val2))
            {
                _res = _val1.Replace(_val2, "");
            }
            return _res;
        }

    }
}
