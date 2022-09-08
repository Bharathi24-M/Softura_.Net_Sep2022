using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal class JaggArry
    {
        public static void Main()
        {
            string[][] products = new string[3][];
            products[0] = new string[] { "Good day", "oreo", "Bour Bon", "Hide & seek" };
            products[1] = new string[] { "Dairy Milk", "5 star", "Gems", "Perk", "Munch" };
            products[2] = new string[] { "Coca cola", "Bovanto", "Pepsi", "Fanta", "Miranda", "Frooti" };
            for (int i = 0; i < products.Length; i++)
            {
                for (int j = 0; j < products[i].Length; j++)
                {
                    Console.Write(products[i][j] + "\t");
                }
                Console.WriteLine();
            }



        }
    }
}
