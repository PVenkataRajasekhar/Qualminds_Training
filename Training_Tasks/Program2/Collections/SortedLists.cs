using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class SortedLists
    {
        SortedList sortedList = new SortedList();
        public void Add()
        {
            sortedList.Add(1.02, "This");
            sortedList.Add(1.07, "Is");
            sortedList.Add(1.04, "SortedList");
            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
        public void Delete()
        {
            sortedList.RemoveAt(sortedList.Count - 1);
            foreach(var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }
        public void count()
        {
            Console.WriteLine(sortedList.Count); 
        }
        public void contains()
        {
            if (sortedList.Contains(1.03))
            {
                Console.WriteLine("element is present");
            }
            else
            {
                Console.WriteLine("element is not present");
            }
        }
    }
}
