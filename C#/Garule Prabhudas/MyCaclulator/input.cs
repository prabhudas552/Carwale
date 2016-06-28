using System;

namespace MyCaclulator
{
    // User can only interact with this class and this class is responsible for 
    // forwording input to the calculator which actually does calculations.

    public class input
    {
        public void giveInput() {
            Calculator calci = new Calculator();
            Console.WriteLine("Enter Opearand 1:");
            calci.Operand_a = Console.ReadLine();
            Console.WriteLine("Enter Operand 2:");
            calci.Operand_b = Console.ReadLine();
            Console.WriteLine("Operaton : 1(+),2(-),3(*),4(/)");
            bool res;
            res = Int32.TryParse(Console.ReadLine(), out calci.operation);
            if (!res)
            {
                Console.WriteLine("Invalid Operation Chosen");
                return;
            }
            Console.WriteLine("Calci type : 1(Decimal),2(Binary),3(String)");
            res = Int32.TryParse(Console.ReadLine(),out calci.calcitype);
            if (!res)
            {
                Console.WriteLine("Invalid CalciType Chosen");
                return;
            }
            calci.initialize();
        }
    }
}
