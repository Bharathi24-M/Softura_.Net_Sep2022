using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class PolyLogin
    {
        public void UserLogin(string EmailId, string password)
        {
            if (EmailId == "bharathi@gmail.com" && password == "Admin@123")
            {
                Console.WriteLine("Welcome " + EmailId);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Email Id and Password");
            }
        }
        public void UserLogin(int MembershipId, int pin)
        {
            if (MembershipId == 1100 && pin == 1234)
            {
                Console.WriteLine("Welcome " + MembershipId);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Membership Id and pin");
            }

        }
        public void UserLogin(string Mobnumber, int pin)
        {
            if (Mobnumber == "8015162840" && pin == 1234)
            {
                Console.WriteLine("Welcome " + Mobnumber);
                Console.WriteLine("You are successfully Logged in");
            }
            else
            {
                Console.WriteLine("Enter valid Mobile number and pin");
            }
        }
        public static void Main()
        {
            PolyLogin pobj = new PolyLogin();
            Console.WriteLine("Enter your Login choice");
            Console.WriteLine("Press 1 for EmailID and Password");
            Console.WriteLine("Press 2 for MembershipID and Pin");
            Console.WriteLine("Press 3 for Mobile Number and pin");
            int option = Convert.ToInt32(Console.ReadLine());
            string username = "";
            string password = "";
            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter Your EmailId");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your Password");
                    password = Console.ReadLine();
                    pobj.UserLogin(username, password);
                    break;
                case 2:
                    Console.WriteLine("Enter your MembershipId");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your pin");
                    password = Console.ReadLine();
                    pobj.UserLogin(Convert.ToInt32(username), Convert.ToInt32(password));
                    break;
                case 3:
                    Console.WriteLine("Enter your Mobile Number");
                    username = Console.ReadLine();
                    Console.WriteLine("Enter your Pin");
                    password = Console.ReadLine();
                    pobj.UserLogin(username, Convert.ToInt32(password));
                    break;
            }


        }
    }
}
