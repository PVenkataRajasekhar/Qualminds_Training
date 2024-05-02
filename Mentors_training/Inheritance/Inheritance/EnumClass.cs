using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    static class EnumClass
    {
        enum MenuOption
        {
            AssociateSoftWareEngineer = 1,
            JuniorSoftWareEngineer,
            SeniorSoftwareEngineer,
            TechnicalLead,
            Manager,
            CEO
        }
        public static void ReadUserOption()
        {
            Console.WriteLine($"Enter {1} for {MenuOption.AssociateSoftWareEngineer}");
            Console.WriteLine($"Enter {2} for {MenuOption.JuniorSoftWareEngineer}");
            Console.WriteLine($"Enter {3} for {MenuOption.SeniorSoftwareEngineer}");
            Console.WriteLine($"Enter {4} for {MenuOption.TechnicalLead}");
            Console.WriteLine($"Enter {5} for {MenuOption.Manager}");
            Console.WriteLine($"Enter {6} for {MenuOption.CEO}");
            Console.Write("Enter your Option :");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    EmployeePosition employeePosition = new Associate();
                    employeePosition.EmployeeExperience();
                    employeePosition.EmployeeSalary();
                    break;
                case 2:
                    employeePosition = new Junior();
                    employeePosition.EmployeeExperience();
                    employeePosition.EmployeeSalary();
                    break;
                case 3:
                    Junior junior = new JuniorMentor();
                    junior.Mentorship();
                    break;
            }
        }
    }
}
