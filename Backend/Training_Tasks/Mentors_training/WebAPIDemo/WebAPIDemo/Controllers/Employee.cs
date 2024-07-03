using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApplicationModels;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using WebAPIDemo.models;

namespace WebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Employee : ControllerBase
    {
        public static List<EmployeeModel> employeeList;
        static Employee()
        {
            employeeList = new List<EmployeeModel>();
        }
        [HttpGet("/EmployeeAPI")]
        public List<EmployeeModel> EmployeeList()
        {
            return employeeList;
        }
        
        [HttpPost("/Create")]
        public List<EmployeeModel> AddEmployee(EmployeeModel employeeModel)
        {
            employeeList.Add(employeeModel);
            return employeeList;
        }

        [HttpGet("/Id")]
        public EmployeeModel Display(int id)
        {
            EmployeeModel employee = employeeList.Find(x => x.Id == id);
            if(employee != null)
            {
                return employee;
            }
            return null;
        }

        [HttpPut("/update")]
        public EmployeeModel UpdateEmployee(EmployeeModel employeeModel)
        {
            EmployeeModel existingEmployee = employeeList.Find(x => x.Id == employeeModel.Id);
            if (existingEmployee != null)
            {
                // Update existing employee with the new data
                existingEmployee.Name = employeeModel.Name;
                existingEmployee.Salary = employeeModel.Salary;

                return existingEmployee;
            }
            else
            {
                // If employee not found, return null or throw an exception based on your requirement
                // For simplicity, returning null here
                return null;
            }
        }


        [HttpDelete("/delete")]
        public List<EmployeeModel> DeleteEmployee(int id)
        {
            EmployeeModel employee = employeeList.Find(x => x.Id == id);
            if (employee != null)
            {
                employeeList.Remove(employee);
                return employeeList;
            }
            return null;
        }
    }
}

