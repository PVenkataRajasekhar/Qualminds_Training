using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Stacks
    {
        Stack stack = new Stack();
        public void push()
        {
            stack.Push(1);
            stack.Push("hello");
            stack.Push(10.33);
            stack.Push(true);
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        public void pop()
        {
            stack.Pop();
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
        public void contains()
        {
            if (stack.Contains("Hii") == true)
            {
                Console.WriteLine("Element is found...!!");
            }

            else
            {
                Console.WriteLine("Element is not found...!!");
            }
        }
        public void count()
        {
            int c = 0;
            foreach (var item in stack)
            {
                c++;
            }
            Console.WriteLine("No of elements in stack are :"+c);
        }
    }
}
