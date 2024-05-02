using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductManagement
{
    public class Product
    {
        public int ProdId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }
        public Product(int prodId, string description,decimal price,string image)
        {
            ProdId = prodId;
            Description = description;
            Price = price;
            Image = image;
        }
        
    }
}
