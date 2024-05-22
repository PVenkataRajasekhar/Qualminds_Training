using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.core.DTO;
using Linq.core.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Linq.core.Repository
{
    public interface IEmployeeDepartmentRepository
    {
        public Task<List<EmployeeModel>> GetAllEmp();
        public Task<List<DepartmentModel>> GetAllDep();
        public Task<EmployeeModel> GetEmployee(int id);
        public Task<decimal> GetAverageEmpSalary(string Position);
        public Task<int> GetEmployeeCount(decimal Salary);
        public Task<decimal> GetSumDesignerSalary(string Position);
        public Task<string> GetMaxSalaryEmployee(string Position);
        public Task<string> GetMinSalaryEmployee(string Position);
        public Task<List<DepartmentEmployeeCountDTO>> GetDepartmentCount(int DepId);
    }
}
