using System;
namespace MyCaclulator
{
    // class to perform integer calculations

    class DecimalCalculator :Calculator
    {
        
        public override string  add(string a, string b)
        {
            return (Int32.Parse(a) + Int32.Parse(b)).ToString();
        }

        public override string div(string a, string b)
        {
            if (Int32.Parse(b) == 0)
                return "Divided By Zero";
            return (Int32.Parse(a)/Int32.Parse(b)).ToString();
        }

        public override string mul(string a, string b)
        {
            return (Int32.Parse(a) * Int32.Parse(b)).ToString();
        }

        public override string sub(string a, string b)
        {
            return (Int32.Parse(a) - Int32.Parse(b)).ToString();
        }

        public override bool  validateOpearands(string a, string b)
        {
            int op1;
            int op2;
            bool flag = Int32.TryParse(a, out op1);
            if (!flag)
                return false;
            flag = Int32.TryParse(b, out op2);
            if (!flag)
                return false;
            return true;
        }
    }
}
