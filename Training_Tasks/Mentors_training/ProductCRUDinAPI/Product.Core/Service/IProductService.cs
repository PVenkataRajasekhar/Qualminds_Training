using Product.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Service
{
    public interface IProductService
    {
        Task<string> Validate(ProductModel product);
        Task<ProductModel> GetProductById(int productId);
        Task<IEnumerable<ProductModel>> GetAllProducts();
        Task<ProductModel> CreateProduct(ProductModel product);
        Task UpdateProduct(ProductModel product);
        Task<ProductModel> DeleteProduct(int productId);
    }
}
