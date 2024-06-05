using Microsoft.AspNetCore.Mvc;
using Customer.Core;
using Customer.Core.Service;
using Customer.Core.Model;
using Customer.Core.Repository;
using Customer.Infrastructure.Repository;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore.Infrastructure;


namespace CustomerCRUDinAPI.Controllers
{
    public class CustomerController : ControllerBase                    
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

        [HttpGet("/GetCustomer/{id}")] // Fix route attribute
        public CustomerModel GetById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }

        [HttpPost("/CreateCustomer")]
        public string Post(CustomerModel customer)
        {
            _customerService.CreateCustomer(customer);
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

        [HttpGet]
        [Route("Products")]
        public async Task<IActionResult> GetProducts(string accessToken)
        {
            var product = await _customerService.CallOtherApiGet(accessToken);
            if (product != null)
            {
                return Ok(product);
            }
            else
            {
                // If product is still null after retries, return a specific response
                return NotFound("Product not found");
            }
        }
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductsById(int id)
        {
            var product = await _customerService.GetById(id);
            return Ok(product);
        }
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateNewProduct(ProductModel productModel)
        {
            var product = await _customerService.Create(productModel);
            return Ok(product);
        }
        [HttpPut("UpdateProduct")]
        public async Task<IActionResult> UpdateRequiredProduct(ProductModel productModel)
        {
            var product = await _customerService.Update(productModel);
            return Ok(product);
        }
        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteRequiredProduct(int id)
        {
            var product = await _customerService.Delete(id);
            return Ok(product);
        }
    }
}

