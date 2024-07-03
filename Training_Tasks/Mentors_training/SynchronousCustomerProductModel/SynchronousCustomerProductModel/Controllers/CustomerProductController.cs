using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SynchronousCustomerProductModel.Data;
using SynchronousCustomerProductModel.Models;

namespace SynchronousCustomerProductModel.Controllers
{
    public class CustomerProductController:ControllerBase
    {
        private readonly Context context;
        public CustomerProductController(Context Context)
        {
            context = Context;
        }

        [HttpGet("/GetcustomerProduct")]
        public async Task<ActionResult<List<Details>>> GetCustomerProducts()
        {
            var customerProducts = await context.CustomerProducts.ToListAsync();
            var result =  new List<Details>();
            var ProcessCustomer = new List<int>();

            foreach (var cp in customerProducts)
            {
                var customer = context.Customers.Find(cp.CustomerId);
                var product = context.Products.Find(cp.ProductId);
                if (customer != null && product != null && !ProcessCustomer.Contains(customer.Id))
                {
                    var item = new Details
                    {
                        CustomerId = customer.Id,
                        CustomerName = customer.Name,
                        Products = new List<Product>()
                    };
                    foreach (var details in customerProducts)
                    {
                        if (details.CustomerId == customer.Id)
                        {
                            var prod = context.Products.Find(details.ProductId);
                            if (prod != null)
                            {
                                item.Products.Add(prod);
                            }
                        }
                    }
                    result.Add(item);
                    ProcessCustomer.Add(customer.Id);
                }
            }
            if (result.Count == 0)
            {
                return null;
            }
            return result;
        }

        [HttpPost("/CreatecustomerProduct")]
        public async Task<ActionResult<CustomerProduct>> PutCustomerProducts(CustomerProduct customerProduct)
        {
            context.CustomerProducts.Add(customerProduct);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetCustomerProducts), new { id = customerProduct.Id }, customerProduct);
        }
    }
}
