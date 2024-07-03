using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Product.Core.Model;
using Product.Core.Service;
using Product.Infrastructure.Filters;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProductCRUDinAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ServiceFilter(typeof(LogTrackAttribute))]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpPost]
        [Route("Validate")]
        public async Task<ActionResult> ValidateProduct(ProductModel product)
        {
            var token = await _productService.Validate(product);
            if (token != null)
            {
                return Ok(new { Token = token });
            }
            return Unauthorized("Invalid credentials");
        }

        [Authorize]
        [HttpGet]
        [Route("GetAllProducts")]
        public async Task<ActionResult<IEnumerable<ProductModel>>> GetAll()
        {
            var products = await _productService.GetAllProducts();
            if (products == null)
            {
                return NotFound("No products found");
            }
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProductById/{id}")]
        public async Task<ActionResult<ProductModel>> GetById(int id)
        {
            var product = await _productService.GetProductById(id);
            if (product != null)
            {
                return Ok(product);
            }
            return NotFound("No product found with this ID");
        }

        [HttpPost]
        [Route("CreateProduct")]
        public async Task<ActionResult<ProductModel>> CreateProduct(ProductModel product)
        {
            var createdProduct = await _productService.CreateProduct(product);
            if (createdProduct == null)
            {
                return BadRequest("Invalid product data");
            }
            return Ok(createdProduct);
        }

        [HttpPut]
        [Route("UpdateProduct")]
        public async Task<ActionResult> UpdateProduct(ProductModel product)
        {
            try
            {
                await _productService.UpdateProduct(product);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to update product: {ex.Message}");
            }
        }

        [HttpDelete]
        [Route("DeleteProduct/{id}")]
        public async Task<ActionResult> DeleteProduct(int id)
        {
            var deletedProduct = await _productService.DeleteProduct(id);
            if (deletedProduct == null)
            {
                return NotFound($"No product found with ID {id}");
            }
            return Ok(deletedProduct);
        }
    }
}
