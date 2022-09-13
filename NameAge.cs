using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    internal class NameAge
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Display(string Name,int Age)
        {
            Console.WriteLine("{0} is {1} years old",Name,Age);
        }
        public static void Main()
        {
            NameAge obj = new NameAge()
            {
                Age = 6,
                Name = "Adhi"
            };
           
            Console.WriteLine("{0} is {1} years old",obj.Name,obj.Age);
            obj.Display("Adhi",6);
        }
    }
}
