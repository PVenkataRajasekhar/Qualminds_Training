using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Product.Core.Model;
using Product.Core.Repository;
using Product.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Product.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IConfiguration _configuration;
        private readonly ProductCrudDbContext _context;

        public ProductRepository(ProductCrudDbContext context, IConfiguration configuration)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _configuration = configuration ?? throw new ArgumentNullException(nameof(configuration));
        }

        public async Task<string> ValidateProduct(ProductModel product)
        {
            var productRecord = await _context.Products.FirstOrDefaultAsync(p => p.Id == product.Id);
            if (productRecord == null)
            {
                return string.Empty;
            }
            else
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_configuration["JWTSECRET:Key"]);

                if (key == null || key.Length == 0)
                {
                    throw new InvalidOperationException("JWT secret key is not configured properly.");
                }

                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new ClaimsIdentity(new Claim[]
                    {
                        new Claim(ClaimTypes.Name, product.Name),
                    }),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
                };

                var token = tokenHandler.CreateToken(tokenDescriptor);
                string productToken = tokenHandler.WriteToken(token);
                return productToken;
            }
        }

        public async Task<List<ProductModel>> Get()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<ProductModel> GetById(int id)
        {
            return await _context.Products.FindAsync(id);
        }

        public async Task<ProductModel> Post(ProductModel product)
        {
            var prod = await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return prod.Entity;
        }

        public async Task Put(ProductModel product)
        {
            try
            {
                var prod = await _context.Products.FindAsync(product.Id);

                if (prod != null)
                {
                    _context.Entry(prod).CurrentValues.SetValues(product);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                // Log the error using a proper logging mechanism
                throw new Exception("Error occurred while updating the product.", ex);
            }
        }

        public async Task<ProductModel> Delete(int id)
        {
            var productToDelete = await _context.Products.FindAsync(id);
            if (productToDelete != null)
            {
                _context.Products.Remove(productToDelete);
                await _context.SaveChangesAsync();
            }
            return productToDelete;
        }
    }
}
