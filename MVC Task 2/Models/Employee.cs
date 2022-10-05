namespace MvcTask1App.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public static List<Employee> GetData()
        {
            List<Employee> employees = new List<Employee>()
        {
            new Employee() { EmployeeId = 1, FirstName = "Divya", LastName= "M",Gender="Female"},
            new Employee() { EmployeeId  = 2, FirstName = "DivyaBharathi", LastName= "S",Gender="Female" },
            new Employee() { EmployeeId  = 3,FirstName= "Priya", LastName=  "M" ,Gender="Female"},
            new Employee() { EmployeeId = 4, FirstName = "Harini", LastName= "S",Gender="Female" },
            new Employee() { EmployeeId = 5, FirstName = "Adhi", LastName= "A",Gender="Male" }

        };
            return employees;
        }
    }
}
