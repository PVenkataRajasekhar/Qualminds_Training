using AttributeRouting.Data;
using AttributeRouting.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace AttributeRouting.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class AttributeController : ControllerBase
    {
        Context context;
        public AttributeController(Context Context)
        {
            context = Context;
        }

        [HttpGet("/GetProduct")]
        public async Task<ActionResult<List<Products>>> Get()
        {
            var product=await context.Products.ToListAsync<Products>();
            return Ok(product);
        }

        [HttpGet("{id}")]   
        public async Task<ActionResult<Products>> GetProduct(int id)
        {
            var ProductToGet = await context.Products.FindAsync(id);
            if (ProductToGet != null)
            {
                return Ok(ProductToGet);
            }
            
                return NotFound();
            
        }

        [HttpGet("string")]
        public async Task<ActionResult<Products>> GetProductByStringId(string s)
        {
            var productToGet =await context.Products.FirstOrDefaultAsync(p => p.Name == s);

            if (productToGet != null)
            {
                return Ok(productToGet);
            }
            else
            {
                return NotFound(); // Return 404 if the product with the given string identifier is not found
            }
        }

        [HttpPost("/CreateProduct")]
        public async Task<ActionResult<Products>> Post(Products product)
        {
            if (product == null)
            {
                return BadRequest("Product data is null.");
            }

            try
            {
                context.Products.Add(product);
                await context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error creating product: {ex.Message}");
            }
        }

    }
}
