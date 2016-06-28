using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MyCaclulator
{
    // class to perform Binary calculations

    class BinaryCalculator :Calculator
    {
        public override string add(string a, string b)
        {
            return (Convert.ToInt32(a, 2) + Convert.ToInt32(b, 2)).ToString();
        }

        public override string sub(string a, string b)
        {
            return (Convert.ToInt32(a, 2) - Convert.ToInt32(b, 2)).ToString();
        }

        public override string mul(string a, string b)
        {
            return (Convert.ToInt32(a, 2) * Convert.ToInt32(b, 2)).ToString();
        }

        public override string div(string a, string b)
        {
            int temp = Convert.ToInt32(b, 2);
            if (temp == 0)
                return "Divided By Zero..!";
            return (Convert.ToInt32(a, 2) / temp).ToString();

        }

        public override bool validateOpearands(string a, string b)
        {
            
            Regex rgx = new Regex(@"[^0-1]");
            if (rgx.IsMatch(a))
                return false;
            if (rgx.IsMatch(b))
                return false;
            return true;
        }
    }
}
