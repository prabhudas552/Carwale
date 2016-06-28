

namespace CalculatorLib
{
   
    public class BinaryCalculator : ICalculator<Binary>
    {

        public Binary Add(Binary a, Binary b)
        {
            return a + b;
        }

        public Binary Subtract(Binary a, Binary b)
        {
            return a - b;
        }

        public Binary Multiply(Binary a, Binary b)
        {
            return a * b;
        }

        public Binary Divide(Binary a, Binary b)
        {
            
            return a / b; 
        }
        public Binary eval(string a, string op, string b)
        {
            switch (op)
            {
                case "+":
                    return Add(a,b);
                case "-":
                    return Subtract(a,b);
                case "*":
                    return Multiply(a,b);
                case "/":
                    return Divide(a,b);
                default:
                    return new Binary(0);
            }
        }
    }
}
