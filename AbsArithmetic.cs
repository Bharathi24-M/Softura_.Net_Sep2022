using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    abstract class Calc
    {
        public abstract void Add(int num1,int num2);
        public abstract void Sub(int num1, int num2);
        public abstract void Mul(int num1, int num2);
        public abstract void Div(int num1, int num2);


    }
    class Calculator : Calc
    {

        public override void Add(int num1, int num2)
        {
            Console.WriteLine(num1+num2);
        }
        public override void Sub(int num1, int num2)
        {
            Console.WriteLine(num1-num2);
        }
        public override void Mul(int num1, int num2)
        {
            Console.WriteLine(num1*num2);
        }
        public override void Div(int num1, int num2)
        {
            Console.WriteLine(num1/num2);
        }

    }
    internal class AbsArithmetic
    {
        public static void Main()
        {
            Calculator cobj=new Calculator();
            cobj.Add(24, 56);
            cobj.Sub(34, 13);
            cobj.Mul(5, 10);
            cobj.Div(100, 5);
        } 
    }
}
