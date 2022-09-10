using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    abstract class Package
    {
        public abstract void Benefits();
       
    }
    class Silver : Package
    {
       
        public override void Benefits()
        {
            Console.WriteLine("Sliver Membership Benefits: Your have 3 days accomodation at Resort");
        }
    }
    class Gold : Package
    {

        public override void Benefits()
        {
            Console.WriteLine("Gold Membership Benefits:5 days accomodation at Resort & 2 Dinners on the house");
        }
    }
    class Platinum : Package
    {

        public override void Benefits()
        {
            Console.WriteLine("Platinum: You have 7 days accomodation at Resort & 5 Dinners on the house");

        }
    }
    internal class MembershipPack
    {
        public static void Main()
        {
            Silver s =new Silver();
            Gold g = new Gold();
            Platinum p=new Platinum();
            s.Benefits();
            g.Benefits();
            p.Benefits();

            
        }
    }
}
