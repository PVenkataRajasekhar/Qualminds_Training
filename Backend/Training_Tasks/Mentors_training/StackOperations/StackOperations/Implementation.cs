using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOperations
{
    public class Implementation
    {
        Stack<int> stack = new Stack<int>(5);
        public void Initialize()
        {
            Console.WriteLine("Enter stack elements:");
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            stack.Push(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("stack elements are:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        public void Remove()
        {
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("stack elements after poping:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
        public void IsEmpty()
        {
            int n=stack.Count();
            if (n == 0)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }    
        }

        
        public void IsFull()
        {
            int n = stack.Count();
            if (n == 5)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
        public void RemoveAt(int num)
        {
            Stack<int> tempStack = new Stack<int>();
            while (stack.Count > 0)
            {
                int item = stack.Pop();
                if (item != num)
                {
                    tempStack.Push(item);
                }
            }
            while (tempStack.Count > 0)
            {
                int item = tempStack.Pop();
                stack.Push(item);
            }
            Console.WriteLine("Remaining Stack elements:");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
        }
    }
}
