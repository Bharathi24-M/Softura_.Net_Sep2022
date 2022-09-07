using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    public static class ElectricBill
    {
        public static void Main()
        {
            Console.WriteLine("Enter the units:");
            int units = Convert.ToInt32(Console.ReadLine());
            if (units <= 200)
            {
                int Amount = units * 2;
                Console.WriteLine("Your electricity bill is:" + Amount);
            }
            else if (units >= 201 && units <= 350)
            {
                int units1 = units - 200;
                int Amount1 = (200 * 2) + (units1 * 3);
                Console.WriteLine("Your Electricity Bill is:" + Amount1);
            }
            else if (units >= 351 && units <= 500)
            {
                int units2 = units - 350;
                int Amount3 = (200 * 2) + (150 * 3) + (units2 * 5);
                Console.WriteLine("Your Electricity bill is:" + Amount3);
            }
            else
            {
                int units3 = units - 500;
                int Amount4 = (200 * 2) + (150 * 3) + (150 * 5) + (units3 * 7);
                Console.WriteLine("Your Electricity Bill is" + Amount4);
            }
        }
    }
}
