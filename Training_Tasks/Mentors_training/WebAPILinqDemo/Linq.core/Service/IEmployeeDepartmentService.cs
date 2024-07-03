using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq.core.DTO;
using Linq.core.Models;

namespace Linq.core.Service
{
    public interface IEmployeeDepartmentService
    {
        public Task<IEnumerable<EmployeeModel>> GetAllEmployees();
        public Task<IEnumerable<DepartmentModel>> GetAllDepartments();
        public Task<EmployeeModel> GetEmployeeById(int id);
        public Task<decimal> GetAverageSalary(string Position);
        public Task<int> GetCount(decimal Salary);
        public Task<decimal> GetSum(string Position);
        public Task<string> GetMax(string Position);
        public Task<string> GetMin(string Position);
        public Task<List<DepartmentEmployeeCountDTO>> GetDepCount(int DepId);
    }
}
