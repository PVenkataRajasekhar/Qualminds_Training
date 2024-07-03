using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices.Marshalling;

namespace Customer.Core.Model;

    public class CustomerModel
    {
        [Key]
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public long Pin {  get; set; }

        [NotNull]
        [Required]
        public string Address { get; set; }

        [NotNull]
        [Required]
        public long Mobile {  get; set; }

        [NotNull]
        [Required]
        public bool IsActive {  get; set; }

        [NotNull]
        [Required]
        public bool IsDeleted {  get; set; }

        [NotNull]
        public DateTime DateCreatedUTC {  get; set; }

        [NotNull]
        public DateTime DateUpdatedUTC {  get; set; }
    }

