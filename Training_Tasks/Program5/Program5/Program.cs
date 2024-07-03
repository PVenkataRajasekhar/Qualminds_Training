/*
 * Sample5.cs
 * This program is used to divide, 
 * salary of the employee present in the company.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    /// <summary>
    /// Sample5 class takes the details of the employee
    /// And divide the salary into different allowances.
    /// </summary>
    class sample5
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Declaring the Employee variables required.
            int empId, empAge;
            string empName;
            float salary;

            //Taking the details of the Employee as user input
            Console.WriteLine("Enter Employee Id:");
            empId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age :");
            empAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of Employee:");
            empName = Console.ReadLine();
            Console.WriteLine("salary :");
            salary = Convert.ToInt32(Console.ReadLine());

            //Division of salary into different allowances by percentages
            float salaryPackage = salary * 12;
            float basic = (salary * 40) / 100;// basic is 35% of total salary 
            float HRA = (salary * 15) / 100;//House Rent Allowance is 15% of salary 
            float MA = (salary * 10) / 100;//medical Allowance is 10% of salary 
            float CA = (salary * 10) / 100;//conveyance Allowance is 10% of salary 
            float SA = (salary * 20) / 100;//special Allowance is 18% of salary 
            float DA = (salary * 5) / 100;//Dearness Allowance is 12% of salary 
            float PF = (salary * 5) / 100;//Provident Fund is 5% of salary

            //Displaying the Details and allowances given for the employee
            Console.WriteLine("ID of the employee is: {0}", empId);
            Console.WriteLine("Name of the employee is: {0}", empName);
            Console.WriteLine("Salary of the employee is: {0}", salary);
            Console.WriteLine("Basic                    : {0}", basic);
            Console.WriteLine("HRA                      : {0}", HRA);
            Console.WriteLine("Medical Allowance        : {0}", MA);
            Console.WriteLine("Conveyance Allowance     : {0}", CA);
            Console.WriteLine("Special Allowance        : {0}", SA);
            Console.WriteLine("Dearness Allowance       : {0}", DA);
            Console.WriteLine("Provident Fund           : {0}", PF);
            Console.WriteLine("Total Take Home Per Month: {0}", salary - PF);
            Console.WriteLine("Total Salary Package     : {0}", salaryPackage);
            Console.ReadKey();
        }

    }
}

