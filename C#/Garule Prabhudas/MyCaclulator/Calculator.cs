using System;
using System.Collections.Generic;
namespace MyCaclulator
{
    interface IcalcultorMethods<T> 
    {
        T add(T a, T b);
        T sub(T a, T b);
        T mul(T a, T b);
        T div(T a, T b);
        bool validateOpearands(string a, string b);
    }

    // Perform calculations on the recieved data and proceed the result to output class.

    public class Calculator : IcalcultorMethods<string> 
    {
        internal string operand_a;
        internal string operand_b;
        internal int operation;
        internal int calcitype;
        Calculator[] calciobj = new Calculator[3];
        public Calculator(){}

        // Below created objects are used to achieve polymorphism

        public void createObjects()
        {
            calciobj[0] = new DecimalCalculator();
            calciobj[1] = new BinaryCalculator();
            calciobj[2] = new StringCalculator();
        }
        public string Operand_a
        {
            get { return operand_a;}
            set { operand_a = value; }
        }
        public string Operand_b
        {
            get { return operand_b; }
            set { operand_b = value; }
        }
        public int Operation
        {
            get { return operation; }
            set { operation = value; }
        }
        public int Calcitype
        {
            get { return calcitype; }
            set { calcitype = value; }
        }

        // Find the operation type and perform actions accordingly.

        public string detectOperation(int index, int op)
        { 
          
            string res;
            switch (op)
            {
                case 1:
                    res = calciobj[index].add(this.Operand_a, this.Operand_b);
                    return res;
                case 2:
                    res = calciobj[index].sub(this.Operand_a, this.Operand_b);
                    return res;
                case 3:
                    res = calciobj[index].mul(this.Operand_a, this.Operand_b);
                    return res;
                case 4:
                    res = calciobj[index].div(this.Operand_a, this.Operand_b);
                    return res;
            }
           
            return string.Empty;
        }

        // checck if the input operands are valid

        public void calculate()
        {
            string res;
            bool validation;
            switch (this.Calcitype)
            {
                case 1:
                    validation = calciobj[0].validateOpearands(this.Operand_a, this.Operand_b);
                    if (validation)
                    { 
                        res = this.detectOperation(0, this.Operation);
                    }
                    else
                    {
                        res = "Invalid input..!";
                    }
                    new output().showResult(res);                  
                    break;
                case 2:
                    validation = calciobj[1].validateOpearands(this.Operand_a, this.Operand_b);
                    if (validation)
                    {
                        res = this.detectOperation(1, this.Operation);
                    }else
                    {
                        res = "Invalid input..!";
                    }
                    new output().showResult(res);
                    break;
                case 3:
                    res = this.detectOperation(2, this.Operation);
                    new output().showResult(res);
                    break;

            }
        }
        public virtual string add(string a, string b)
        {
            throw new NotImplementedException();
        }

        public virtual string sub(string a, string b)
        {
            throw new NotImplementedException();
        }

        public virtual string mul(string a, string b)
        {
            throw new NotImplementedException();
        }

        public virtual string div(string a, string b)
        {
            throw new NotImplementedException();
        }

        public virtual bool validateOpearands(string a, string b)
        {
            Console.WriteLine("Base Method..!");
            return false;
        }
         
        public void initialize()
        {
            this.createObjects();
            this.calculate();

        }
    }

}
