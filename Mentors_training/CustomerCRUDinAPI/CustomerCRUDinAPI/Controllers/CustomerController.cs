using Microsoft.AspNetCore.Mvc;
using Customer.Core;
using Customer.Core.Service;
using Customer.Core.Model;
using Customer.Core.Repository;


namespace CustomerCRUDinAPI.Controllers
{
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("/GetCustomer")]
        public ActionResult<IEnumerable<CustomerModel>> GetAll()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("/GetCustomer,id")]
        public CustomerModel GetById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if(customer != null)
            {
                return customer;
            }
            return null;
        }

        [HttpPost("/CreateCustomer")]
        public string Post( CustomerModel customer)
        {
            _customerService. CreateCustomer(customer);
            return "Customer Record Created Successfully";
        }
        [HttpPut("/UpdateCustomer")]
        public string Put(CustomerModel customer)
        {
            _customerService.UpdateCustomer(customer);
             return "Customer record updates succesfully";
        }

        [HttpDelete("/DeleteCustomer")]
        public string Delete(int id)
        {
            _customerService.DeleteCustomer(id);
            return "Customer record deleted successfully";
        }
    }
}
