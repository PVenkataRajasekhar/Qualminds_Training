using ASPDotNETCoreWebAPIEntityFrameWork.Data;
using ASPDotNETCoreWebAPIEntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreWebAPIEntityFrameWork.Controllers
{
    public class CustomerController
    {
        Context context;
        public CustomerController(Context Context)
        {
            context = Context;
        }
        [HttpGet("/GetCustomer")]
        public List<Customer> Get()
        {
            return context.Customers.ToList<Customer>();
        }

        [HttpPost("/CreateCustomer")]
        public string Post([FromBody] Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }
        [HttpPut("/UpdateCustomer")]
        public string Put([FromBody] Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
            return "Customer record updates succesfully";
        }

        [HttpDelete("/DeleteCustomer")]
        public string Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);
            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                return "Customer record deleted successfully";
            }
            else
            {
                return "Customer not found";
            }
        }

    }
}
