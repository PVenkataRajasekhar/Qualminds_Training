using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericCollections.Program;
using System.Collections.Generic;
using System.Collections;

namespace GenericCollections
{
    public class lists
    {
        public void Subtract()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            List<int> list2 = new List<int>();
            list2.Add(10);
            list2.Add(37);

            Subtraction<List<int>> listSubtraction = new Subtraction<List<int>>();
            listSubtraction.FirstNumber = list;
            listSubtraction.SecondNumber = list2;

            List<int> firstNo = listSubtraction.FirstNumber;
            List<int> secondNo = listSubtraction.SecondNumber;
            List<int> combinedList = new List<int>();

            // Ensure both lists have the same number of elements
            if (list.Count == list2.Count)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    combinedList.Add(list[i] - list2[i]);
                }
            }
            else
            {
                Console.WriteLine("Both lists must have the same number of elements.");
            }
            // Output combined list
            foreach (int value in combinedList)
            {
            Console.Write(value + " ");
            }
            Console.WriteLine();
            
        }
    }
}
