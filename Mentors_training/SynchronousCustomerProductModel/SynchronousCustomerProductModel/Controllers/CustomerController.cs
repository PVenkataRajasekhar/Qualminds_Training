using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynchronousCustomerProductModel.Data;
using SynchronousCustomerProductModel.Models;

namespace SynchronousCustomerProductModel.Controllers
{
    public class CustomerController:ControllerBase
    {
        Context context;
        public CustomerController(Context Context)
        {
            context = Context;
        }

        [HttpGet("/GetCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomer()
        {
            return await context.Customers.ToListAsync();
        }

        [HttpGet("{custid}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            if (context.Customers == null)
            {
                return NotFound();
            }
            var customer = await context.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        [HttpPost("/createCustomer")]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            context.Customers.Add(customer);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }

        [HttpPut("{custid}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }
            context.Entry(customer).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
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

        [HttpDelete("{custid}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            if (context.Customers == null)
            {
                return NotFound();
            }

            var customer = await context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            context.Customers.Remove(customer);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(long id)
        {
            return (context.Customers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
