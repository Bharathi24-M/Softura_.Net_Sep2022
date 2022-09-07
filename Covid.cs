using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
   public class Covid
    {
        static void Main()
        {
            Console.WriteLine("Do you have travel history? if yes press 'y' otherwise press 'n'");
            char travel = Convert.ToChar(Console.ReadLine());
            if (travel == 'y')
            {
                Console.WriteLine("Do you have temperature if yes press 'y' otherwise press 'n'");
                char temp = Convert.ToChar(Console.ReadLine());
                if (temp == 'y')
                {
                    Console.WriteLine("Do you have cough/sneez? if yes press 'y' otherwise press 'n'");
                    char cold = Convert.ToChar(Console.ReadLine());
                    if (cold == 'y')
                    {
                        Console.WriteLine("Take Swab test");
                    }
                    else
                    {
                        Console.WriteLine("Quarantine and Take Fever medicine");
                    }

                }
                else
                {
                    Console.WriteLine("Home Quarantine for 28 days");
                }
            }
            else
            {
                Console.WriteLine("Not Covid-19. You are safe");
            }
        }
    }
}
