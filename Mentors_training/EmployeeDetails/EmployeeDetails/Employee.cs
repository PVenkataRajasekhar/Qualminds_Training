using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace EmployeeDetails
{
    public class Employee
    {
        public readonly string Name;
        int Age;
        string Department;
        string Company;
        string Location;
        public Employee (string name,int age,string department,string company,string location)
        {
            Name = name;
            Age = age;
            Department = department;
            Company = company;
            Location = location;
        }
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Rajasekhar", 21, "IT", "Qualminds", "Hyderabad");
            employee.Output();
        }
        public void Output()
        {
            NameMethod();
            AgeMethod();
            DepartmentMethod();
            CompanyMethod();
            LocationMethod();
        }

        StringBuilder sb = new StringBuilder();
        public void NameMethod()
        {
            sb.Append($"Hi my name is {Name}");
        }
        public void AgeMethod()
        {
            sb.Append($" and I am {Age} year old.");
        }
        public void DepartmentMethod()
        {
            sb.Append($" Currently I am working in {Department} department");
        }
        public void CompanyMethod()
        {
            sb.Append($" at {Company}");
        }
        public void LocationMethod()
        {
            sb.Append($" {Location} office.");
            Console.Write(sb.ToString());
        }
    }
}
