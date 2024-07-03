using Microsoft.AspNetCore.Mvc;
using Customer.core.Model;
using Customer.core.Service;
using Customer.Infrastructure.Context;
using System.ComponentModel.DataAnnotations;

namespace AnnotationsDemo.Controllers
{
    public class CustomerController:ControllerBase
    {
        private readonly ICustomerService _CustomerService;
        private readonly CustomerCrudDbContext _CustomerCrudDbContext;
        public CustomerController(ICustomerService CustomerService, CustomerCrudDbContext CustomerCrudDbContext)
        {
            _CustomerService = CustomerService;
            _CustomerCrudDbContext = CustomerCrudDbContext;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<CustomerModel>> PostCustomer(CustomerModel customerModel)
        {
            if(!ModelState.IsValid)
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors)
                   .Select(x => x.ErrorMessage).ToList();
                return Ok(errors);
            }
                return await _CustomerService.IPostService(customerModel);
            
        }
    }
}
