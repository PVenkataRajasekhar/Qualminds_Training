using Product.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Core.Repository
{
    public interface IProductRepository
    {
        public Task<string> ValidateProduct(ProductModel product);
        public Task<List<ProductModel>> Get();
        public Task<ProductModel> GetById(int id);
        public Task<ProductModel> Post(ProductModel product);
        public Task Put(ProductModel product);
        public Task<ProductModel> Delete(int id);
    }
}
