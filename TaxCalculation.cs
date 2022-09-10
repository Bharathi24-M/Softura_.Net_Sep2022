using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    class VatTax //base class
    {

        public  void calculateTax(double BasicAmount)
        {

            
            double VatValue = (BasicAmount * 0.20);
            Console.WriteLine("The VAT Amount is: " +VatValue);

        }
    }
    class GstTax:VatTax  //derived class
    {
        public new void calculateTax(double BasicAmount)
        {
            
            double GstValue = (BasicAmount * 0.12);
            Console.WriteLine("The GST Amount is:"+GstValue);
        }
    }
    internal class TaxCalculation 
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Amount");
            double Amount = Convert.ToDouble(Console.ReadLine());
            GstTax gobj=new GstTax();
            gobj.calculateTax(Amount);
            VatTax vobj = new GstTax();
            vobj.calculateTax(Amount);

        }
    }
}
    
    

        
    
}
