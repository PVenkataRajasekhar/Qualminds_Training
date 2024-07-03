using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRepo.Core.Models
{
    public class ProductModel
    {
        [Key]
        public int ProdID { get; set; }
        public string Name { get; set; }
    }
}
