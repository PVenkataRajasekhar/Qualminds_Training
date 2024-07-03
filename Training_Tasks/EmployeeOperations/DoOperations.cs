using EmployeeOperations;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics;

namespace ArrayListDemo;

public class DoOperations
{
    EmployeeOperations emp = new EmployeeOperations();
    static int CreateId(ArrayList employees)
    {
        // EmployeeOperations employees = new EmployeeOperations();
        return employees.Count + 1;
    }

    public void Add()
    {
        Console.WriteLine("Enter Employee Id :");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Employee Name : ");
        string empName = Console.ReadLine();
        Console.WriteLine("Enter Employee Salary : ");
        decimal empSalary = Convert.ToDecimal(Console.ReadLine());
        Employee employee = new Employee(Id, empName, empSalary);
        if (emp.AddEmployee(employee))
        {
            Console.WriteLine("Added successfully.");
        }
    }

    public void Remove()
    {
        Console.WriteLine("Enter Employee Id : ");
        int empId = Convert.ToInt32(Console.ReadLine());
        if (emp.RemoveEmployee(empId))
        {
            Console.WriteLine("Removed successfully.");
        }
        else
        {
            Console.WriteLine("Failed to Remove");
        }
    }
    public void UserOption()
    {
        Console.WriteLine("Enter 1 to update only Employee Id");
        Console.WriteLine("Enter 2 to update only Employee Name");
        Console.WriteLine("Enter 3 to update only Salary");
        Console.WriteLine("Enter 4 to update All");
    }
    public void Update()
    {
        UserOption();
        int n = Convert.ToInt32(Console.ReadLine());
        if (n == 4)
        {
            Console.WriteLine("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee prevEmployee = emp.GetEmployee(empId);
            if (prevEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            else
            {
                Console.WriteLine("Enter new Employee Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Employee Name : ");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary : ");
                decimal newSalary = Convert.ToDecimal(Console.ReadLine());
                Employee newEmployee = new Employee(Id, newName, newSalary);
                if (emp.UpdateEmployee(newEmployee, empId))
                {
                    Console.WriteLine("Updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
        }
        else if (n == 1)
        {
            Console.WriteLine("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee prevEmployee = emp.GetEmployee(empId);
            if (prevEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            else
            {
                Console.WriteLine("Enter new Employee Id:");
                int Id = Convert.ToInt32(Console.ReadLine());
                string newName = prevEmployee.Name;
                decimal newSalary = prevEmployee.Salary;
                Employee newEmployee = new Employee(Id, newName, newSalary);
                if (emp.UpdateEmployee(newEmployee, empId))
                {
                    Console.WriteLine("Updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
        }
        if (n == 2)
        {
            Console.WriteLine("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee prevEmployee = emp.GetEmployee(empId);
            if (prevEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            else
            {
                int Id = prevEmployee.Id;
                Console.WriteLine("Enter Employee Name : ");
                string newName = Console.ReadLine();
                decimal newSalary = prevEmployee.Salary;
                Employee newEmployee = new Employee(Id, newName, newSalary);
                if (emp.UpdateEmployee(newEmployee, empId))
                {
                    Console.WriteLine("Updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
        }
        if (n == 3)
        {
            Console.WriteLine("Enter Employee Id : ");
            int empId = Convert.ToInt32(Console.ReadLine());

            Employee prevEmployee = emp.GetEmployee(empId);
            if (prevEmployee == null)
            {
                Console.WriteLine("Employee not found");
                return;
            }
            else
            {
                int Id = prevEmployee.Id;
                string newName = prevEmployee.Name;
                Console.WriteLine("Enter Employee Salary : ");
                decimal newSalary = Convert.ToDecimal(Console.ReadLine());
                Employee newEmployee = new Employee(Id, newName, newSalary);
                if (emp.UpdateEmployee(newEmployee, empId))
                {
                    Console.WriteLine("Updated successfully.");
                }
                else
                {
                    Console.WriteLine("Failed to update");
                }
            }
        }
    }

    public void GetAll()
    {
        foreach (Employee employee in emp.Employees)
        {
            Console.WriteLine($"Employee Id : {employee.Id}");
            Console.WriteLine($"Employee Name : {employee.Name}");
            Console.WriteLine($"Employee Salary : {employee.Salary}");
            Console.WriteLine("--------------------------------------");
        }
    }
}
