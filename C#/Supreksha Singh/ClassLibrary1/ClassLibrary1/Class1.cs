using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    interface ICalculator<T>
    {
        T Add(T a, T b);
        T Subtract(T a, T b);
        T Multiply(T a, T b);
        T Divide(T a, T b);
    }


    // all classes are inheriting the interface ICalculator

    public class Digits : ICalculator <int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b){
            return a - b;
        }
        public int Multiply(int a, int b){
            return a * b;
        }
        public int Divide(int a, int b){
            return a / b;
        }
    }
    public class Strings : ICalculator <string>
    {
         public string Add(string a, string b)
         {
             //append the string at last eg: aa + bb = aabb
             StringBuilder c = new StringBuilder(a);
             c.Append(b);
             return c.ToString();
         }
         public string Subtract(string a, string b)
         {
             //append second string in front eg: aa - bb = bbaa
             StringBuilder c = new StringBuilder(b);
             c.Append(a);
             return c.ToString();
         }
         public string Multiply(string a, string b)
         {
             int i;
             //eg: aa * bb = abbabb
             StringBuilder c = new StringBuilder("");
             for( i=0;i<a.Length;i++)
             {
                 c.Append(a[i]).Append(b);
             }
             //c.Append(a[i-1]).Append(b);
             return c.ToString();
         }
         public string Divide(string a, string b)
         {
             //eg: aabbaa / bb = aaaa  removing the first sub string 
             int l= b.Length;
             int ptr = a.IndexOf(b);
             if(ptr!= -1)
             {
                 StringBuilder c = new StringBuilder(a);
                 c.Remove(ptr, l);
                 return c.ToString();
             }
             else { return "cannot divide- no sub string found"; }
             
         }
        
     }

}