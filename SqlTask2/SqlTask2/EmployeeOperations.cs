using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlTask2
{
    internal class EmployeeOperations
    {
        Operations operations = new Operations();
        SqlDataReader sqlDataReader;
        public void DoAdd()
        {
            Console.WriteLine("Enter Unique Id of the Employee :");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of the Employee: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Salary of the employee:");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ENter Age of the Employee:");
            int age = Convert.ToInt32(Console.ReadLine());
            EmployeeDetails employeeDetails = new EmployeeDetails
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
                Age = age
            };
            string sqltext = $"Insert Into Employees Values({employeeDetails.Id},'{employeeDetails.Name}',{employeeDetails.Salary},{employeeDetails.Age}) ";
            int result = +operations.ExecuteNonQueryMethod(sqltext);
            Console.WriteLine(result + " rows affected");
        }
        public void DoRead()
        {
            Console.WriteLine("Enter Unique Id of the Employee :");
            int readId = Convert.ToInt32(Console.ReadLine());
            string sqltext = $"Select * From Employees Where Id={readId}";
            List<EmployeeDetails> employeeslist = operations.Display(sqltext);
            foreach (EmployeeDetails employee in employeeslist)
            {
                Console.WriteLine(employee.Id + "\t\t" + employee.Name + "\t\t" + employee.Salary + "\t\t" + employee.Age);
            }
        }
        public void DoUpdate()
        {
            Console.WriteLine("Enter Employee Id to Update:");
            int newId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new Employee name:");
            string newName = Console.ReadLine();
            Console.WriteLine("Enter new Employee Salary:");
            decimal newSalary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter new employee Age");
            int newAge = Convert.ToInt32(Console.ReadLine());
            EmployeeDetails employeeDetails = new EmployeeDetails
            {
                Id = newId,
                Name = newName,
                Salary = newSalary,
                Age = newAge
            };
            string sqltext = $"Update Employees SET name='{employeeDetails.Name}',salary={employeeDetails.Salary},age={employeeDetails.Age} where Id={employeeDetails.Id}";
            int res = operations.ExecuteNonQueryMethod(sqltext);
            Console.WriteLine(res + " rows affected");
        }
        public void DoDelete()
        {
            Console.WriteLine("Enter Id to delete:");
            int delId = Convert.ToInt32(Console.ReadLine());
            string sqltext = $"Delete From Employees Where Id={delId}";
            int res = operations.ExecuteNonQueryMethod(sqltext);
            Console.WriteLine(res + " rows affected");
        }
        public void DoDisplayAll()
        {
            string sqltext = $"Select * from Employees";
            List<EmployeeDetails> employeeslist = operations.Display(sqltext);
            foreach (EmployeeDetails employee in employeeslist)
            {
                Console.WriteLine(employee.Id + "\t\t" + employee.Name + "\t\t" + employee.Salary + "\t\t" + employee.Age);
            }
        }
    }
}
