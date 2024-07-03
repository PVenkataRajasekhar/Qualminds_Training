using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Queues
    {
        Queue queue = new Queue();
        public void enqueue()
        {
            queue.Enqueue(1);
            queue.Enqueue("hello");
            queue.Enqueue(10.33);
            queue.Enqueue(true);
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void dequqeue()
        {
            queue.Dequeue();
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
        public void contains()
        {
            if (queue.Contains("Hii") == true)
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
            foreach (var item in queue)
            {
                c++;
            }
            Console.WriteLine("No of elements in queue are :" + c);
        }
    }
}
