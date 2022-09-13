using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Training1
{
    [Serializable()]//Decorater
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    public class EmpSerial
    {
        public static void Main()
        {
            Employee Employee = new Employee()
            {
                Id = 1,
                Name = "Adhi",
                Age = 6,
                Gender = "Male"
            };

            BinaryFormatter f = new BinaryFormatter();
            Stream s = new FileStream("employee.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            f.Serialize(s, Employee);
            s.Close();

            FileStream fs1 = new FileStream("employee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf1 = new BinaryFormatter();

            
            Employee Employee1 = (Employee)bf1.Deserialize(fs1);

            Console.WriteLine("Employee Details");
            Console.WriteLine(Employee1.Id);
            Console.WriteLine(Employee1.Name);
            Console.WriteLine(Employee1.Age);
            Console.WriteLine(Employee1.Gender);
            fs1.Close();


        }
    }
}


