﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
   public class AgeCount
    {
        public static void Main()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < age; i++)
            {
                Console.WriteLine(name);
            }

        }
    }
}
