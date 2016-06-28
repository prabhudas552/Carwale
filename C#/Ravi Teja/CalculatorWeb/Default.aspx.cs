using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using RaviCalculator;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        add.Click += new EventHandler(add_click);
        sub.Click += new EventHandler(sub_click);
        mul.Click += new EventHandler(mul_click);
        div.Click += new EventHandler(div_click);
    }

    private void add_click(object sender, EventArgs e)
    {
        if (notEmpty())
        {
            string caltype = calcType.SelectedValue.ToString();
            if (caltype.Equals("int"))
            {
                try
                {
                    ICalculator<int> ic = new IntCalculator();
                    int a = Convert.ToInt16(inp_a.Value);
                    int b = Convert.ToInt16(inp_b.Value);
                    output.InnerText = Convert.ToString(ic.Add(a, b));
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only integers";
                }
            }
            else if (caltype.Equals("bin"))
            {
                try
                {
                    ICalculator<string> ic = new BinCalculator();
                    output.InnerText = ic.Add(inp_a.Value, inp_b.Value);
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only binary values";
                }
            }
            else if (caltype.Equals("string"))
            {
                ICalculator<string> ic = new StringCalculator();
                output.InnerText = ic.Add(inp_a.Value, inp_b.Value);
            }

        }
    }

    private void mul_click(object sender, EventArgs e)
    {
        if (notEmpty())
        {
            string caltype = calcType.SelectedValue.ToString();
            if (caltype.Equals("int"))
            {
                try
                {
                    ICalculator<int> ic = new IntCalculator();
                    int a = Convert.ToInt16(inp_a.Value);
                    int b = Convert.ToInt16(inp_b.Value);
                    output.InnerText = Convert.ToString(ic.Mul(a, b));
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only integers";
                }
            }
            else if (caltype.Equals("bin"))
            {
                try
                {
                    ICalculator<string> ic = new BinCalculator();
                    output.InnerText = ic.Mul(inp_a.Value, inp_b.Value);
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only binary values";
                }
            }
            else if (caltype.Equals("string"))
            {
                ICalculator<string> ic = new StringCalculator();
                output.InnerText = ic.Mul(inp_a.Value, inp_b.Value);
            }
        }
    }

    private void sub_click(object sender, EventArgs e)
    {
        if (notEmpty())
        {
            string caltype = calcType.SelectedValue.ToString();
            if (caltype.Equals("int"))
            {
                try
                {
                    ICalculator<int> ic = new IntCalculator();
                    int a = Convert.ToInt16(inp_a.Value);
                    int b = Convert.ToInt16(inp_b.Value);
                    output.InnerText = Convert.ToString(ic.Sub(a, b));
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only integers";
                }
            }
            else if (caltype.Equals("bin"))
            {
                try
                {
                    ICalculator<string> ic = new BinCalculator();
                    output.InnerText = ic.Sub(inp_a.Value, inp_b.Value);
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only binary values";
                }
            }
            else if (caltype.Equals("string"))
            {
                ICalculator<string> ic = new StringCalculator();
                string result = ic.Sub(inp_a.Value, inp_b.Value);
                output.InnerText = result=="" ? "<Empty>":result;
            }
        }
    }

    private void div_click(object sender, EventArgs e)
    {
        if (notEmpty())
        {
            string caltype = calcType.SelectedValue.ToString();
            if (caltype.Equals("int"))
            {
                try
                {
                    ICalculator<int> ic = new IntCalculator();
                    int a = Convert.ToInt16(inp_a.Value);
                    int b = Convert.ToInt16(inp_b.Value);
                    output.InnerText = Convert.ToString(ic.Div(a, b));
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only integers";
                }
            }
            else if (caltype.Equals("bin"))
            {
                try
                {
                    ICalculator<string> ic = new BinCalculator();
                    output.InnerText = ic.Div(inp_a.Value, inp_b.Value);
                }
                catch (Exception ex)
                {
                    output.InnerText = "Input only binary values";
                }
            }
            else if (caltype.Equals("string"))
            {
                ICalculator<string> ic = new StringCalculator();
                string result = ic.Div(inp_a.Value, inp_b.Value);
                output.InnerText = result == "" ? "<Empty>" : result;
            }
        }
    }

    private bool notEmpty()
    {
        if (inp_a.Value == "" || inp_b.Value == "")
        {
            output.InnerText = "Fields should not be empty";
            return false;
        }
        return true;
    }
}