using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class EmployeePosition
    {
        private string Name;
        private int Age;
        private string location;
        protected int ID;
        protected TimeSpan Experience;
        protected internal DateTime DateOfJoining;
        private DateTime CurrentDate { get; set; }
        public EmployeePosition()
        {
            CurrentDate = DateTime.Now;
        }
        public virtual void EmployeeExperience()
        {
            Console.WriteLine("Enter name of Employee:");
            this.Name = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee ID:");
            ID = Convert.ToInt32(Console.ReadLine());
            Experience = CurrentDate - DateOfJoining;
        }
        public virtual void EmployeeExperience(DateTime PresentDate)
        {
            Experience = PresentDate - DateOfJoining;
            Console.WriteLine(Experience);
        }
        public abstract void EmployeeSalary();
    }
}
