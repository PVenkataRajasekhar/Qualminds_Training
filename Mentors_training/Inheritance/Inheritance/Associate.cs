using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    partial class Associate : EmployeePosition
    {
        public override void EmployeeExperience()
        {
            Console.WriteLine("Enter Date Of Joining of the Employee:");
            try
            {
                base.DateOfJoining = Convert.ToDateTime(Console.ReadLine());
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Please Enter Date Format like YYYY/MM/DD");
                this.EmployeeExperience();
            }
            finally
            {
                Console.WriteLine("Finally block executed");
            }
            base.EmployeeExperience();
        }
    }
    partial class Associate : EmployeePosition
    {
        public override void EmployeeSalary()
        {
            double years = base.Experience.Days / 365D;
            Console.WriteLine("Total years of experience Employee having is : " + years);
            decimal SalaryRange = (years > 1) ? 450000 : 360000;
            Console.WriteLine("Salary range of employee will be around " + SalaryRange);
        }
    }
}
