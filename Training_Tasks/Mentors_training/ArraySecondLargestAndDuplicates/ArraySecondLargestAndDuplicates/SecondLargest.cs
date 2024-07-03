using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySecondLargestAndDuplicates
{
    internal class SecondLargest
    {
        public void Array()
        {
            Console.WriteLine("Enter Array size : ");
            int num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter array elements : ");
            int[] arr = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.Write($"Enter {i} element : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            for(int i = 0;i < num; i++)
            {
                for(int j = i+1; j < num; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                } 
            }
            Console.WriteLine(" The Second largest element of an array is :" + arr[1]);
        }
    }
}
