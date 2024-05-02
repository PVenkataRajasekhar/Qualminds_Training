using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    sealed class JuniorMentor : Junior
    {
        public override void Mentorship()
        {
            base.Mentorship();
            base.EmployeeExperience();
            base.EmployeeSalary();
         
            if (base.years > 2)
            {
                Console.WriteLine("He/she can allot as junior mentor");

            }
            else
            {
                Console.WriteLine("He/she cannot be as junior mentor");
            }
        }
    }
}
