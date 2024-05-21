using CodeFirstDemo.Data;
using CodeFirstDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirstDemo.Controllers
{
    public class CustomerController
    {
        PrjContext context;
        public CustomerController(PrjContext prjContext)
        {
            context = prjContext;
        }

        [HttpGet("/GetCustomer")]
        public List<Customer> Get()
        {
            return context.Customers.ToList<Customer>();
        }

        [HttpPost("/postCustomer")]
        public string Post([FromBody] Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }
    }
}
