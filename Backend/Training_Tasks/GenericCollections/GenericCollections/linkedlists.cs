using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GenericCollections.Program;

namespace GenericCollections
{
    public class linkedlists
    {
        public void Subtract()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(32);
            list.AddLast(2);
            LinkedList<int> list2 = new LinkedList<int>();
            list2.AddLast(80);
            list2.AddLast(37);

            Subtraction<LinkedList<int>> linkedlistSubtraction = new Subtraction<LinkedList<int>>();
            linkedlistSubtraction.FirstNumber = list;
            linkedlistSubtraction.SecondNumber = list2;

            LinkedList<int> firstNo = linkedlistSubtraction.FirstNumber;
            LinkedList<int> secondNo = linkedlistSubtraction.SecondNumber;
            
            LinkedList<int> resultList = SubtractLinkedLists(list, list2);
            // Output combined list
            foreach (int value in resultList)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
        static LinkedList<int> SubtractLinkedLists(LinkedList<int> list, LinkedList<int> list2)
        {
            LinkedList<int> resultList = new LinkedList<int>();

            // Ensure both lists have the same number of elements
            if (list.Count != list2.Count)
            {
                throw new ArgumentException("Both lists must have the same number of elements.");
            }

            // Perform addition
            LinkedListNode<int> node1 = list.First;
            LinkedListNode<int> node2 = list2.First;
            while (node1 != null && node2 != null)
            {
                resultList.AddLast(node1.Value - node2.Value);
                node1 = node1.Next;
                node2 = node2.Next;
            }

            return resultList;
        }
    }
}

