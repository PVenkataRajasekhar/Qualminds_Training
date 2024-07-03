using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SQLCRUDOperations
{
    internal class MenuClass
    {
        public enum Menu
        {
            Add=1,
            Read,
            Update,
            Delete,
            DisplayAll,
            Exit
        }
        public void  ReadUserOption()
        {
            EmployeeOperations employeeOperations = new EmployeeOperations();
            while (true)
            {
                Console.WriteLine($"{(int)Menu.Add} to Insert a row");
                Console.WriteLine($"{(int)Menu.Read} to read a row by Id");
                Console.WriteLine($"{(int)Menu.Update} to update a row");
                Console.WriteLine($"{(int)Menu.Delete} to delete a row");
                Console.WriteLine($"{(int)Menu.DisplayAll} to read all rows in table");
                Console.WriteLine($"{(int)Menu.Exit} to terminate");
                Console.WriteLine("Enter the number:");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case (int)MenuClass.Menu.Add:
                        employeeOperations.DoAdd();
                        Console.ReadKey();
                        break;
                    case (int)MenuClass.Menu.Read:
                        employeeOperations.DoRead();
                        Console.ReadKey();
                        break;
                    case (int)MenuClass.Menu.Update:
                        employeeOperations.DoUpdate();
                        Console.ReadKey();
                        break;
                    case (int)MenuClass.Menu.Delete:
                        employeeOperations.DoDelete();
                        Console.ReadKey();
                        break;
                    case (int)MenuClass.Menu.DisplayAll:
                        employeeOperations.DoDisplayAll();
                        Console.ReadKey();
                        break;
                    case (int)MenuClass.Menu.Exit:
                        Environment.Exit(0);
                        break;
                }
            }
        }

    }
}
