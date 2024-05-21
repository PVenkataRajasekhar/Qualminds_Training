using CodeFirstDemo.Data;
using CodeFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class EmployeeController
    {
        PrjContext context;
        public EmployeeController(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet("/GetEmployee")]
        public List<Employee> Get()
        {
            return context.Employees.ToList<Employee>();
        }

        [HttpPost("/PostEmployee")]
        public string Post([FromBody] Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return "Employee Record Created Successfully";
        }
    }
}
