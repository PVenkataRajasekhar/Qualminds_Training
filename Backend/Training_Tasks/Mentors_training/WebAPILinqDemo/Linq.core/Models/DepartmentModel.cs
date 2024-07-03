using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.core.Models
{
    public class DepartmentModel
    {
        public int Id { get; set; }
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int TotalMembers {  get; set; }
    }
}
