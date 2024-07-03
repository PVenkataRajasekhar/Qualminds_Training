using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance
{
    internal class MultipleInheriting:Experience,Salary
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public TimeSpan Experience;
        public DateTime DateOfJoining;
        DateTime CurrentDate = DateTime.Now;
        public double years;
        public void EmployeeExperience()
        {
            Console.WriteLine("Enter name of Employee:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee ID:");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Date of joining of employee:");
            DateOfJoining = Convert.ToDateTime(Console.ReadLine());
            Experience = CurrentDate - DateOfJoining;
        }
        public  void EmployeeSalary()
        {
            double years = Experience.Days / 365;
            Console.WriteLine("Total years of experience Employee having is : " + years);
            decimal SalaryRange = (years > 1) ? 450000 : 360000;
            Console.WriteLine("Salary range of employee will be around " + SalaryRange);
        }
    }
}
