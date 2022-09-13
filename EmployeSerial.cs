using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Training1
{
    public class MyEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
    internal class EmployeSerial
    {
        public static void Main()
        {
            MyEmployee empobj = new MyEmployee()
            {
                Id = 1,
                Name = "Adhi",               
                Age = 20,
                Gender = "Male"
            };
            var serialize = new XmlSerializer(typeof(MyEmployee));
            using (StreamWriter stream = new StreamWriter("Employee.xml"))
            {
                serialize.Serialize(stream, empobj);
            }
            Console.WriteLine("Id:{0} \n Name:{1} \n Age:{2} \n Gender={3}", empobj.Id, empobj.Name,empobj.Age,empobj.Gender);
        }
    }

}
