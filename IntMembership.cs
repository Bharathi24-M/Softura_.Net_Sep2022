using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class Membership : Benefits
    {
        public void Sliver()
        {
            Console.WriteLine("Sliver Membership Benefits: Your have 3 days accomodation at Resort");
        }

        public void Gold()
        {
            Console.WriteLine("Gold Membership Benefits:5 days accomodation at Resort & 2 Dinners on the house");
        }
        public void Platinum()
        {
            Console.WriteLine("Platinum: You have 7 days accomodation at Resort & 5 Dinners on the house");
        }

    }
    internal class IntMembership
    {

        public static void Main()
        {
            Membership mobj = new Membership();
            mobj.Sliver();
            mobj.Gold();
            mobj.Platinum();

        }
    }
}
