using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    class Sales
    {
        public virtual void TotalSalary(double sal)
        {
            double Bonus = (sal * 20) / 100;
            double FinalSalary = Bonus + sal;
            Console.WriteLine("salary with Bonus:" +FinalSalary);
        }
    }
    class Production : Sales
    {
        public override void TotalSalary(double sal)
        {
            double Bonus = (sal * 10) / 100;
            double FinalSalary = Bonus + sal;
            Console.WriteLine("Salary with Bonus:" + FinalSalary);
        }
    }
    internal class BonusCalculation
    {

        public static void Main()
        {
            Console.WriteLine("Enter the Employee Id: ");
            int Eid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Name: ");
            string EName = Console.ReadLine();
            Console.WriteLine("Enter the Employee Gender: ");
            string EGender = Console.ReadLine();
            Console.WriteLine("Enter the Employee's Year of Experience:");
            int Eexper = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Employee Salary");
            double Esalary = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Employee's Department(sales/production");
            string EDepart = Console.ReadLine();
            Console.WriteLine("***********************");
            Console.WriteLine("Employee Details:");
            Console.WriteLine("***********************");
            Console.WriteLine("Id:" + Eid);
            Console.WriteLine("Name:" + EName);
            Console.WriteLine("Gender:" + EGender);
            Console.WriteLine("Year of Experence:"+Eexper);
            Console.WriteLine("Department:"+EDepart);
            
            if (EDepart == "sales")
            {
                Sales sObj = new Sales();
                sObj.TotalSalary(Esalary);
            }
            else if(EDepart=="production")
            {
                Production pObj = new Production();
                pObj.TotalSalary(Esalary);
            }
            else
            {
                Console.WriteLine("Enter the valid Department");
            }
            Console.WriteLine("***********************");

        }
    }
}
