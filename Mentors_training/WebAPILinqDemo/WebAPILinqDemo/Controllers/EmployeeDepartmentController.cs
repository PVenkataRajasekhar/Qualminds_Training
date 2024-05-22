using Linq.core.Models;
using Linq.core.Service;
using Microsoft.AspNetCore.Mvc;
using Linq.core.DTO;

namespace WebAPILinqDemo.Controllers
{
    public class EmployeeDepartmentController:ControllerBase
    {
        private readonly IEmployeeDepartmentService _EmployeeDepartmentService;
        public EmployeeDepartmentController(IEmployeeDepartmentService EmployeeDepartmentService)
        {
            _EmployeeDepartmentService = EmployeeDepartmentService;
        }

        [HttpGet("AllEmployeesData")]
        public async Task<ActionResult<IEnumerable<EmployeeModel>>> GetAllEmployees()
        {
            var Employees = await _EmployeeDepartmentService.GetAllEmployees();
            if(Employees == null)
            {
                return NotFound("No such table present in Database");
            }
            return Ok(Employees);
        }
        [HttpGet("AllDepartmentsData")]
        public async Task<ActionResult<IEnumerable<DepartmentModel>>> GetAllDepartments()
        {
            var Departments= await _EmployeeDepartmentService.GetAllDepartments();
            if (Departments == null)
            {
                return NotFound("No such table present in Database");
            }
            return Ok(Departments);
        }
        [HttpGet("GetEmployeeById")]
        public async Task<ActionResult<EmployeeModel>> GetEmployeeByID(int ID)
        {
            var Employee = await _EmployeeDepartmentService.GetEmployeeById(ID);
            if(Employee == null)
            {
                return BadRequest("No Employee present with this ID");
            }
            return Ok(Employee);
        }
        [HttpGet("GetAverageSalary")]
        public async Task<ActionResult<decimal>> GetAverageDeveloperSalary(string Department)
        {
            decimal Salary = await _EmployeeDepartmentService.GetAverageSalary(Department);
            if (Salary > 0)
            {
                return Ok(Salary);
            }
            return BadRequest("No such department is present.");
        }
        [HttpGet("GetEmployeeSalaryCountGreaterThan")]
        public async Task<ActionResult<int>> GetEmployeeCount(decimal Salary)
        {
            int count=await _EmployeeDepartmentService.GetCount(Salary);
            if(count > 0)
            {
                return Ok(count);
            }
            return NotFound("No person present with salary greater than this.");
            
        }
        [HttpGet("GetSumOfSalaryOfEmployees")]
        public async Task<ActionResult<decimal>> GetSumSalary(string Department)
        {
            decimal sum = await _EmployeeDepartmentService.GetSum(Department);
            if (sum > 0)
            {
                return Ok(sum);
            }
            return BadRequest("Enter valid Department.");
            
        }
        [HttpGet("MaxSalariedPerson")]
        public async Task<ActionResult<string>> GetMaxSalaryPerson(string Department)
        {
            string name=await _EmployeeDepartmentService.GetMax(Department);
            if(name != null)
                return Ok(name);
            return BadRequest("Enter valid Department.");
        }
        [HttpGet("MinSalariedPerson")]
        public async Task<ActionResult<string>> GetMinSalaryPerson(string Department)
        {
            string name = await _EmployeeDepartmentService.GetMin(Department);
            if (name != null)
                return Ok(name);
            return BadRequest("Enter valid Department.");
        }
        [HttpGet("GetDepartmentEmployeeCount")]
        public async Task<ActionResult<IEnumerable<DepartmentEmployeeCountDTO>>> GetDepartmentCount(int DepartmentID)
        {
            var employee=await _EmployeeDepartmentService.GetDepCount(DepartmentID);
            if (employee != null)
                return employee;
            return BadRequest("Enter valid Department ID.");
        }
    }
}
