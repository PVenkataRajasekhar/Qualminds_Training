using GenericRepo.Core.Contracts.IUnitOfWork;
using GenericRepo.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericRepo.API.Controllers
{
    public class ProductController:ControllerBase
    {
        private readonly IService<ProductModel> _productService;
        public ProductController(IService<ProductModel> productService)
        {
            _productService = productService;
        }

        [HttpGet("/Getproduct")]
        public async Task<ActionResult<IEnumerable<CustomerModel>>> GetAllProducts()
        {
            var products = await _productService.GetAll();
            if (products == null)
            {
                return NotFound("Empty Records");
            }
            return Ok(products);
        }

        [HttpGet("/GetProduct/{id}")]
        public async Task<ActionResult<CustomerModel>> GetById(int id)
        {
            var products = await _productService.GetWithId(id);
            if (products != null)
            {
                return Ok(products);
            }
            return BadRequest("Id is not present");
        }

        [HttpPost("/CreateProduct")]
        public async Task<ActionResult<string>> Post(ProductModel products)
        {
            await _productService.Create(products);
            return Ok("Creation Successful");
        }

        [HttpPut("/UpdateProduct")]
        public async Task<ActionResult<string>> Put(ProductModel products)
        {
            await _productService.Update(products);
            return Ok("Product record updates succesfully");
        }

        [HttpDelete("/DeleteProduct")]
        public async Task<ActionResult<string>> Delete(int id)
        {
            await _productService.Remove(id);
            return Ok("Product record deleted successfully");
        }
    }
}

