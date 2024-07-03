using Azure;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlTask3
{
    internal class EmployeeOperations
    {
        Operations operations = new Operations();
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
            EmployeeModel employeeModel = new EmployeeModel
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
                Age = age
            };
            operations.AddRow(employeeModel);
        }
        public void DoRead()
        {
            Console.WriteLine("Enter Unique Id of the Employee :");
            int readId = Convert.ToInt32(Console.ReadLine());
            DataRow newdr=operations.ReadRow(readId);
            Console.WriteLine("Id :" + newdr[0] + "\t\tName :" + newdr[1] + "\t\tSalary :" + newdr[2] + "\t\tAge :" +newdr[3]);
        }
        public void DoDelete() 
        {
            Console.WriteLine("Enter Unique Id of the Employee :");
            int readId = Convert.ToInt32(Console.ReadLine());
            operations.DeleteRow(readId);
        }
        public void DoUpdate()
        {
            Console.WriteLine("Enter Unique Id of the Employee :");
            int Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name of the Employee: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Salary of the employee:");
            decimal Salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ENter Age of the Employee:");
            int age = Convert.ToInt32(Console.ReadLine());
            EmployeeModel employeeModel = new EmployeeModel
            {
                Id = Id,
                Name = Name,
                Salary = Salary,
                Age = age
            };
            operations.UpdateRow(employeeModel);
        }
        public void DoDisplayAll()
        {
            DataSet newDs=operations.DisplayAll();
            foreach (DataRow data in newDs.Tables[0].Rows)
            {
                Console.WriteLine("Id :"+data[0]+"\t\tName :"+data[1]+"\t\tSalary :"+data[2]+"\t\tAge :" + data[3]);
            }
        }
    }
}
