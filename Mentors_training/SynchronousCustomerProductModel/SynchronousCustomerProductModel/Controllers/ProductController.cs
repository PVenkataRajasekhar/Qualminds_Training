using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynchronousCustomerProductModel.Data;
using SynchronousCustomerProductModel.Models;

namespace SynchronousCustomerProductModel.Controllers
{
    public class ProductController:ControllerBase
    {
        Context context;
        public ProductController(Context Context)
        {
            context = Context;
        }

        [HttpGet("/GetProd")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            return await context.Products.ToListAsync();
        }

        [HttpGet("{Prodid}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            if (context.Products == null)
            {
                return NotFound();
            }
            var product = await context.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }

        [HttpPost("/createProd")]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct), new { id = product.ProdID }, product);
        }

        [HttpPut("{prodid}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            if (id != product.ProdID)
            {
                return BadRequest();
            }
            context.Entry(product).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpDelete("{prodid}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (context.Products == null)
            {
                return NotFound();
            }

            var product = await context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            context.Products.Remove(product);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProductExists(long id)
        {
            return (context.Products?.Any(e => e.ProdID == id)).GetValueOrDefault();
        }
    }
}
