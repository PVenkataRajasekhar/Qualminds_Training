using GenericRepo.Core.Models;
using Microsoft.AspNetCore.Mvc;
using GenericRepo.Core.Contracts.IUnitOfWork;
    
namespace GenericRepo.API.Controllers
{
    public class CustomerController : ControllerBase
    {

        private readonly IService<CustomerModel> _customerService;
        public CustomerController(IService<CustomerModel> customerService)
        {
            _customerService = customerService;

        }

        [HttpGet("/GetCustomer")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetAllCustomers()
        {
            var customers = await _customerService.GetAll();
            if(customers == null)
            {
                return NotFound("Empty Records");
            }
            return Ok(customers);
        }

        [HttpGet("/GetCustomer/{id}")] 
        public async Task<ActionResult<CustomerModel>> GetById(int id)
        {
            var customer = await _customerService.GetWithId(id);
            if (customer != null)
            {
                return Ok(customer);
            }
            return BadRequest("Id is not present");
        }

        [HttpPost("/CreateCustomer")]
        public async Task<ActionResult<string>> Post(CustomerModel customer)
        {
            await _customerService.Create(customer);
            return Ok("Creation Successful");
        }

        [HttpPut("/UpdateCustomer")]
        public async Task<ActionResult<string>> Put(CustomerModel customer)
        {
            await _customerService.Update(customer);
            return Ok("Customer record updates succesfully");
        }

        [HttpDelete("/DeleteCustomer")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            await   _customerService.Remove(id);
            return Ok("Customer record deleted successfully");
        }
    }
}
