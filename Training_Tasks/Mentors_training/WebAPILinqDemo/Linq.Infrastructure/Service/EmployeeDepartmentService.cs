using Linq.core.Service;
using Linq.core.Repository;
using Linq.core.Models;
using Linq.core.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Infrastructure.Service
{
    public class EmployeeDepartmentService:IEmployeeDepartmentService
    {
        private readonly IEmployeeDepartmentRepository _EmployeeDepartmentRepository;

        public EmployeeDepartmentService(IEmployeeDepartmentRepository EmployeeDepartmentRepository)
        {
            _EmployeeDepartmentRepository = EmployeeDepartmentRepository;
        }
        public async Task<IEnumerable<EmployeeModel>> GetAllEmployees()
        {
            return await _EmployeeDepartmentRepository.GetAllEmp();
        }
        public async Task<IEnumerable<DepartmentModel>> GetAllDepartments()
        {
            return await _EmployeeDepartmentRepository.GetAllDep();
        }
        public async Task<EmployeeModel> GetEmployeeById(int id)
        {
            return await _EmployeeDepartmentRepository.GetEmployee(id);
        }
        public async Task<decimal> GetAverageSalary(string Position)
        {
            return await _EmployeeDepartmentRepository.GetAverageEmpSalary(Position);
        }
        public async Task<int> GetCount(decimal Salary)
        {
            return await _EmployeeDepartmentRepository.GetEmployeeCount(Salary);
        }
        public async Task<decimal> GetSum(string Position)
        {
            return await _EmployeeDepartmentRepository.GetSumDesignerSalary(Position);
        }
        public async Task<string> GetMax(string Position)
        {
            return await _EmployeeDepartmentRepository.GetMaxSalaryEmployee(Position);
        }
        public async Task<string> GetMin(string Position)
        {
            return await _EmployeeDepartmentRepository.GetMinSalaryEmployee(Position);
        }
        public async Task<List<DepartmentEmployeeCountDTO>> GetDepCount(int DepId)
        {
            return await _EmployeeDepartmentRepository.GetDepartmentCount(DepId);
        }
    }
}
