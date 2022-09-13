using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    internal class CollecRestarunt
    {
        public static void Main()
        {
            List<string> list = new List<string>();
            list.Add("Choco Lava");
            list.Add("Waffle");
            list.Add("Donut");
            list.Add("Cheese Cake");
            
            FileStream fs = new FileStream("C:\\Bharathi\\Softura\\Project\\sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter bw = new StreamWriter(fs);
            bw.BaseStream.Seek(0, SeekOrigin.End);
            foreach (string i in list)
                bw.WriteLine(i);
            bw.Flush();
            fs.Close();

            FileStream fs1 = new FileStream("C:\\Bharathi\\Softura\\Project\\Sample.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader br = new StreamReader(fs1);
            br.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(br.ReadToEnd());
            br.Close();
            fs1.Close();

            FileInfo fi = new FileInfo("C:\\Bharathi\\Softura\\Project\\Sample.txt");
            Console.WriteLine("File created Time : " + fi.CreationTime);
            Console.WriteLine("Length of the file: "+ fi.Length);



        }
    }
}
