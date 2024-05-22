using System.ComponentModel.DataAnnotations;

namespace AnnotationsDemo.Model
{
    public class Customer
    {
        [Key]
        public int CustomerID {  get; set; }

        [Required]
        public string CustomerName { get; set; }

        [AllowedValues("Male,Female")]
        public string Gender { get; set; }

        [EmailAddress]                                                                                                                                       ṁ]

    }
}
