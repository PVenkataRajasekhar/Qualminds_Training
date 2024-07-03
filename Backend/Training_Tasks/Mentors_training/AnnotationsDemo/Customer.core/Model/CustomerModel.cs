using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Customer.core.UserdefinedAttribute;

namespace Customer.core.Model
{
    public class CustomerModel
    {

        [Key]
        public int CustomerID { get; set; }

        [NotNull]
        [Required]
        [StringLength(50, MinimumLength = 4)]
        public string FirstName { get; set; }

        [AllowNull]
        public string LastName { get; set; }

        [Range(18, 100 ,ErrorMessage ="The Age should be minimum of 18 years and maximum of 100 years")]
        public int Age { get; set; }

        [AllowedValues("Male","Female","Others",ErrorMessage ="The allowed values are 'Male','Female','Others' only.")]
        public string Gender { get; set; }

        [CustomEmail(ErrorMessage ="the email format is 'example@yahoo.com'.")]
        public string email { get; set; }

        [RegularExpression(@"^\+?\d{1,3}?[- .]?\(?\d{3}\)?[- .]?\d{3}[- .]?\d{4}$",ErrorMessage ="The phone number format is ex:+919989732508")]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        [MinLength(10)]
        public string Address { get; set; }
        
    }
}
