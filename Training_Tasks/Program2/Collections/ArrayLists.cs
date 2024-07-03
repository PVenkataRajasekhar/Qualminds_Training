using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class ArrayLists
    {
        public ArrayList arrayList = new ArrayList();

        string str = "hii";

        int x = 11;

        DateTime d = DateTime.Parse("20-Apr-2024");
        public void Add()
        {
            arrayList.Add(str);

            arrayList.Add(x);

            arrayList.Add(d);

            Console.WriteLine("ArrayList After adding elements :");
            foreach (var o in arrayList)
            {

                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
        public void Update()
        {
            arrayList.RemoveAt(0);
            arrayList.Insert(0, "Hello");
            Console.WriteLine("ArrayList After Updating:");
            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
        public void Delete()
        {
            arrayList.RemoveAt(0);
            Console.WriteLine("ArrayList After Deleting:");
            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
        public void Reverse()
        { 
            arrayList.Reverse();
            Console.WriteLine("ArrayList After Reversing :");
            foreach (var o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
        public void Sort()
        {
            
            Console.WriteLine("ArrayList After Sorting :");
            foreach(var o in arrayList)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
        public void Contains()
        {
            Console.WriteLine("ArrayList Contains Method :");
            if (arrayList.Contains("Hello"))
                Console.WriteLine("Yes, exists at index " + arrayList.IndexOf("E"));
            else
                Console.WriteLine("No, doesn't exists");
            Console.WriteLine(".........................");
        }
        public void Clone()
        {
            ArrayList arrayList2 = new ArrayList();
            foreach (var o in arrayList)
            {
                arrayList2.Add(arrayList.Clone());
            }
            Console.WriteLine("ArrayList After Copying");
            foreach (var o in arrayList2)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine(".........................");
        }
    }
}
