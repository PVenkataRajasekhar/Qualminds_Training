using System.ComponentModel.DataAnnotations;

namespace SynchronousCustomerProductModel.Models
{
    public class Product
    {
        [Key]
        public int ProdID { get; set; }
        public string Name { get; set; }
    }
}
