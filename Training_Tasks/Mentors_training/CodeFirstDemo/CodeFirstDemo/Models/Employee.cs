using System.ComponentModel.DataAnnotations;

namespace CodeFirstDemo.Models
{
    public class Employee
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Grade { get; set; }
        public string comments { get; set; }
    }
}
