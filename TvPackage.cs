using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
   public class TvPackage
    {
        static void Main()
        {
            Console.WriteLine("Select the package option (A/B/C)");
            char option = Convert.ToChar(Console.ReadLine());
            switch (option)
            {
                case 'A':
                    Console.WriteLine("Package A");
                    Console.WriteLine("1. South Special 2. Children's club 3.Movies");
                    Console.WriteLine("Rate: 250");
                    break;
                case 'B':
                    Console.WriteLine("Package B");
                    Console.WriteLine("1. News 2. Sports 3.Movies 4.Regional-2");
                    Console.WriteLine("Rate: 450");
                    break;
                case 'C':
                    Console.WriteLine("Package C");
                    Console.WriteLine("1. Discovery History 2.National ");
                    Console.WriteLine("Rate: 350");
                    break;
                default:
                    Console.WriteLine("Enter the valid option");
                    break;
            }
        }
    }
}
