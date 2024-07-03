using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Hashtables
    {
        Hashtable hashtable = new Hashtable();
        public void Add()
        {
            hashtable.Add(1, "One"); //adding a key/value using the Add() method
            hashtable.Add(2, "Two");
            hashtable.Add(3, "Three");
            foreach (int key in hashtable.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, hashtable[key]));
            }
        }
        public void Update()
        {
            if (hashtable.ContainsKey(1))
            {
                hashtable[1] = "four";
            }
            foreach (int key in hashtable.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, hashtable[key]));
            }
        }
        public void Delete()
        {
            hashtable.Remove(1);
            foreach(int key in hashtable.Keys)
            {
                Console.WriteLine(String.Format("{0}: {1}", key, hashtable[key]));
            }
        }
        public void Count()
        {
            int c = 0;
            foreach(int key in hashtable.Keys)
            {
                c++;
            }
            Console.WriteLine("no of elements in HashTable are : "+c);
        }
        public void Contains()
        {
            Console.WriteLine("Enter a string if it contains in HashTable or not");
            string s = Console.ReadLine();
            if (hashtable.ContainsValue(s))
            {
                Console.WriteLine("Hashtable contains value :"+s);
            }
            else
            {
                Console.WriteLine("hashtable doesnot contain value :"+s);
            }
        }
    }
}
