using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperations
{
    public class InputOutput
    {
       
        public enum Menu
        {
            Empty,
            push,
            full,
            pop,
            popSpecificElement
        }
        public int ReadUserOption()
        {
            Console.WriteLine($"Enter {(int)Menu.Empty} to check whether stack is {Menu.Empty}");
            Console.WriteLine($"Enter {(int)Menu.push} to {Menu.push} the elements into stack");
            Console.WriteLine($"Enter {(int)Menu.full} to check whether stack is {Menu.full}");
            Console.WriteLine($"Enter {(int)Menu.pop} to {Menu.pop} the elements from stack");
            Console.WriteLine($"Enter {(int)Menu.popSpecificElement} to {Menu.popSpecificElement} from stack");
            int num=Convert.ToInt32( Console.ReadLine());
            return num;
        }
        public int ElementRemove()
        {
            Console.WriteLine("Enter element to remove from stack : ");
            int num=Convert.ToInt32( Console.ReadLine());
            return num;
        }
    }
}
