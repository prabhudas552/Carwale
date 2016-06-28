using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class test
    {
        static void Main()
        {
            iCal obj1 = new iCal();
            iCal obj2 = new iCal();
            iCal obj3 = new iCal();
            iCal obj4 = new iCal();

            sCal obj5 = new sCal();
            sCal obj6 = new sCal();
            sCal obj7 = new sCal();
            sCal obj8 = new sCal();

            bCal obj9 = new bCal();
            bCal obj10 = new bCal();
            bCal obj11 = new bCal();
            bCal obj12 = new bCal();

            int res1 = obj1.add(3, 4);
            int res2 = obj2.sub(4, 1);
            int res3 = obj3.mul(2, 1);
            int res4 = obj4.div(2, 2);

            Console.WriteLine(res1);
            Console.WriteLine(res2);
            Console.WriteLine(res3);
            Console.WriteLine(res4);

            string s1 = obj5.add("abca", "ab");
            string s2 = obj6.sub("abcaac", "ab");
            string s3 = obj7.mul("xyz", "ab");
            string s4 = obj8.div("abca", "ab");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            string b1 = obj9.add("10", "1");
            string b2 = obj10.sub("10", "0");
            string b3 = obj11.mul("10", "1");
            string b4 = obj12.div("10", "1");

            Console.WriteLine(b1);
            Console.WriteLine(b2);
            Console.WriteLine(b3);
            Console.WriteLine(b4);
            

            Console.Read();

        }
    }
}
