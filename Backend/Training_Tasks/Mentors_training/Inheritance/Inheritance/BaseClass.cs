using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    abstract class EmployeePosition
    {
        public string Name;
        public int Age;
        public int ID;
        public TimeSpan Experience;
        public DateTime DateOfJoining;
        DateTime CurrentDate = DateTime.Now;
        public double years;
        public virtual void EmployeeExperience()
        {
            Console.WriteLine("Enter name of Employee:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Experience = CurrentDate - DateOfJoining;
        }
        public abstract void EmployeeSalary();
    }
}
