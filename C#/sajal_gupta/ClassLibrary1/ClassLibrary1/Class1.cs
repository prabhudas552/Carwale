using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public interface calculator<t>
    {
        t add(t a, t b);
        t sub(t a, t b);
        t mul(t a, t b);
        t div(t a, t b);
    }
}

public class iCal : calculator<int>
{

    public int add(int a, int b)
    {
        return (a + b);
    }

    public int sub(int a, int b)
    {
        return (a - b);
    }

    public int mul(int a, int b)
    {
        return (a * b);
    }

    public int div(int a, int b)
    {
        return (a / b);
    }
}

public class sCal : calculator<string>
{


    public string add(string a, string b)
    {
        StringBuilder builder = new StringBuilder();
        builder.Append(a);
        builder.Append(b).AppendLine();

        string res = builder.ToString();

        return res;


    }

    public string sub(string a, string b)
    {
        if(a.IndexOf(b) == -1)
        {
            return a;
        }
        else
        {
            int p = a.IndexOf(b);
           return(a.Remove(p, b.Length));

        }
        
    }

    public string mul(string a, string b)
    {
        StringBuilder builder = new StringBuilder();
       
        char[] c=b.ToCharArray();

        for(int i=0;i<c.Length;i++)
        {
            builder.Append(a);
            builder.Append(c[i]);

        }

        string res = builder.ToString();

        return res;

        
    }

    public string div(string a, string b)
    {

        char[] c = b.ToCharArray();
       
        for (int i = 0; i < b.Length; i++)
        {
            a=a.Replace(c[i], ' ');
        }


        return a;

    }
}


public class bCal : calculator<string>
{

    public string add(string a, string b)
    {
        int p = Convert.ToInt32(a, 2);
        int q = Convert.ToInt32(b, 2);

        return Convert.ToString(p + q, 2);
    }

    public string sub(string a, string b)
    {
        int p = Convert.ToInt32(a, 2);
        int q = Convert.ToInt32(b, 2);
        
        return Convert.ToString(p - q, 2);
    }

    public string mul(string a, string b)
    {
        int p = Convert.ToInt32(a, 2);
        int q = Convert.ToInt32(b, 2);

        return Convert.ToString(p * q, 2);
    }

    public string div(string a, string b)
    {
        int p = Convert.ToInt32(a, 2);
        int q = Convert.ToInt32(b, 2);

        return Convert.ToString(p / q, 2);
    }
}
