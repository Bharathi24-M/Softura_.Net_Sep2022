using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class VatTax //base class
    {

        public void calculateTax(double BasicAmount)
        {
            Console.WriteLine("base class");
            double VatValue = (BasicAmount * 0.20);
            Console.WriteLine(VatValue + BasicAmount);

        }
    }
    class GstTax:VatTax  //derived class
    {
        public new void calculateTax(double BasicAmount)
        {
            Console.WriteLine("derived class");
            double GstValue = (BasicAmount * 0.12);
            Console.WriteLine(GstValue + BasicAmount);
        }
    }
    internal class TaxCalculation 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Amount");
            double Amount = Convert.ToDouble(Console.ReadLine());
            VatTax tax = new VatTax();
            GstTax tax1 = new GstTax();
            tax.calculateTax(Amount);
            tax1.calculateTax(Amount);

        }
    }
}
