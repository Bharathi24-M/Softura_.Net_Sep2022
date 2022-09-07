using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
   public class StudentsMark
    {
        static void Main()
        {
            int[] arry = new int[5];
            int tot = 0;
            int per = 0;
            Console.WriteLine("Enter the 5 subjects Marks");
            for (int i = 0; i < arry.Length; i++)
            {
                arry[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arry.Length; i++)
            {
                tot = tot + arry[i];
                per = tot / 5;

            }
            Console.WriteLine("The total mark of the 5 subject is:" + tot);
            Console.WriteLine("The percentage is:" + per);

        }
    }
}
