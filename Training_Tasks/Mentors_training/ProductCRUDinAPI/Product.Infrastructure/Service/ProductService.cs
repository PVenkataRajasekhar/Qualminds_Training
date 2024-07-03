using Product.Core.Model;
using Product.Core.Repository;
using Product.Core.Service;
using Product.Infrastructure.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository= productRepository;
        }
        public async Task<string> Validate(ProductModel product)
        {
            return await _productRepository.ValidateProduct(product);
        }
        public async Task<ProductModel> CreateProduct(ProductModel product)
        {

            return await _productRepository.Post(product);
        }

        public async Task<ProductModel> GetProductById(int productId)
        {
            return await _productRepository.GetById(productId);
        }

        public async Task<IEnumerable<ProductModel>> GetAllProducts()
        {
            return await _productRepository.Get();
        }

        public async Task UpdateProduct(ProductModel product)
        {

           await _productRepository.Put(product); 
        }

        public async Task<ProductModel> DeleteProduct(int productId)
        {

            return await _productRepository.Delete(productId);
        }
    }
}
