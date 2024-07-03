using ASPDotNETCoreWebAPIEntityFrameWork.Data;
using ASPDotNETCoreWebAPIEntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace ASPDotNETCoreWebAPIEntityFrameWork.Controllers
{
    public class CustomerProductController:ControllerBase
    {
        private readonly Context context;
        public CustomerProductController(Context Context)
        {
            context = Context;
        }
        
        [HttpGet("/GetcustomerProduct")]
        public List<Details> GetCustomerProducts()
        {
            var customerProducts = context.CustomerProducts.ToList();
            var result = new List<Details>();
            var ProcessCustomer=new List<int>();

            foreach (var cp in customerProducts)
            {
                var customer = context.Customers.Find(cp.CustomerId);
                var product = context.Products.Find(cp.ProductId);
                if(customer != null && product!=null && !ProcessCustomer.Contains(customer.Id)) 
                {
                    var item = new Details
                    {
                        CustomerId = customer.Id,
                        CustomerName = customer.Name,
                        Products = new List<Product>()
                    };
                    foreach(var details in customerProducts)
                    {
                        if(details.CustomerId == customer.Id)
                        {
                            var prod = context.Products.Find(details.ProductId);
                            if(prod != null)
                            {
                                item.Products.Add(prod);
                            }
                        }
                    }
                    result.Add(item);
                    ProcessCustomer.Add(customer.Id);
                }
            }

            return result;
        }

        [HttpPost("/CreatecustomerProduct")]
        public List<CustomerProducts> PutCustomerProducts(CustomerProducts customerProduct)
        {
            context.CustomerProducts.Add(customerProduct);
            context.SaveChanges();
            return context.CustomerProducts.ToList();
        }
    }
}
