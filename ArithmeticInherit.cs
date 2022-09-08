using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class parent
    {
        public void add(int num1, int num2)
        {
            Console.WriteLine( num1 + num2);
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
    class child : parent
    {
        public  void mul(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public  void div(int num1, int num2)
        {
             Console.WriteLine(num1 + num2);
        }

    }
    internal class ArithmeticInherit
    {
        public static void Main()
        {
           child cobj = new child();
            cobj.mul(5, 2);
            cobj.div(10, 2);
            cobj.add(23, 45);
            cobj.sub(34, 23);

        }
    }
}
