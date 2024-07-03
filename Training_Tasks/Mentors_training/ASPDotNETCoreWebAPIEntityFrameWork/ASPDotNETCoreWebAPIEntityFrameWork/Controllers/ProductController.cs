using ASPDotNETCoreWebAPIEntityFrameWork.Data;
using ASPDotNETCoreWebAPIEntityFrameWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNETCoreWebAPIEntityFrameWork.Controllers
{
    public class ProductController
    {
        Context context;
        public ProductController(Context Context)
        {
            context = Context;
        }
        [HttpGet("/GetProduct")]
        public List<Product> Get()
        {
            return context.Products.ToList<Product>();
        }

        [HttpPost("/CreateProduct")]
        public string Post([FromBody] Product product)
        {
            context.Products.Add(product);
            context.SaveChanges();
            return "product Record Created Successfully";
        }
        [HttpPut("/UpdateProduct")]
        public string Put([FromBody] Product product)
        {
            context.Products.Update(product);
            context.SaveChanges();
            return "product record updates succesfully";
        }

        [HttpDelete("/DeleteProduct")]
        public string Delete(int id)
        {
            var ProductToDelete = context.Products.Find(id);
            if (ProductToDelete != null)
            {
                context.Products.Remove(ProductToDelete);
                context.SaveChanges();
                return "Product record deleted successfully";
            }
            else
            {
                return "Product not found";
            }
        }
    }
}
