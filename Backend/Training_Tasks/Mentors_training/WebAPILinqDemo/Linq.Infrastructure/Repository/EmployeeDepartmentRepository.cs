using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.Infrastructure.Data;
using Linq.core.Models;
using Linq.core.Repository;
using Linq.core.DTO;
using Microsoft.EntityFrameworkCore;

namespace Linq.Infrastructure.Repository
{
    public class EmployeeDepartmentRepository:IEmployeeDepartmentRepository
    {
        private readonly Context context;
        public EmployeeDepartmentRepository(Context Context)
        {
            context = Context;
        }
        public async Task<List<EmployeeModel>> GetAllEmp()
        {
            var Employee= await (from employee in context.Employees
            select employee).ToListAsync();
            if (Employee != null )
            {
                return Employee;
            }
            return null;
        }
        public async Task<List<DepartmentModel>> GetAllDep()
        {
            var Department= await ( from department in context.Department
                     select department).ToListAsync();
            if (Department != null )
            {
                return Department;
            }
            return null;
        }
        public async Task<EmployeeModel> GetEmployee(int id)
        {
            var Employee = await (from employee in context.Employees
                            where employee.Id == id
                            select employee).FirstOrDefaultAsync();
            if(Employee == null)
            {
                return null;
            }
            return Employee;
        }
        public async Task<decimal> GetAverageEmpSalary(string Position)
        {
            decimal averageSalary = await context.Employees
                .Where(employee => employee.Position == Position)
                .AverageAsync(employee => employee.Salary);
            if(averageSalary > 0)
            {
                return averageSalary;
            }
            return 0;
            
        }
        public async Task<int> GetEmployeeCount(decimal Salary)
        {
            int count = await (from employee in context.Employees
                         where employee.Salary >= Salary
                         select employee).CountAsync();
            if (count > 0)
            {
                return count;
            }
            return 0;
        }
        public async Task<decimal> GetSumDesignerSalary(string Position)
        {
            var sum = await (from employee in context.Employees
                       where employee.Position == Position
                       select employee.Salary).SumAsync();

            if (sum > 0)
            {
                return sum;
            }
            return 0;

        }
        public async Task<string> GetMaxSalaryEmployee(string Position)
        {
            var employee =await context.Employees
                .Where(e => e.Position == Position)
                .OrderByDescending(e => e.Salary)
                .FirstOrDefaultAsync();
            if (employee == null)
                return null;
            return $"{employee.FirstName} {employee.LastName}";
            
        }
        public async Task<string> GetMinSalaryEmployee(string Position)
        {
            var employee =await context.Employees
                .Where(e => e.Position == Position)
                .OrderBy(e => e.Salary)
                .FirstOrDefaultAsync();
            if (employee == null)
                return null;
            return $"{employee.FirstName} {employee.LastName}";

        }
        public async Task<List<DepartmentEmployeeCountDTO>> GetDepartmentCount(int DepId)
        {

            var departmentCounts = await (from employee in context.Employees
                                    join department in context.Department
                                    on employee.DepartmentID equals department.DepartmentID
                                    where employee.DepartmentID == DepId
                                    group employee by new { department.DepartmentName, employee.DepartmentID } into g
                                    select new DepartmentEmployeeCountDTO
                                    {
                                        DepartmentName = g.Key.DepartmentName,
                                        EmployeeCount = g.Count()
                                    })
                            .ToListAsync();
            if (departmentCounts.Count > 0)
                 return departmentCounts;
            return null;
        }
    }
}
