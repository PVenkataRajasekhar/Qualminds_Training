using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySecondLargestAndDuplicates
{
    public class Duplicates
    {
        int num;
        ArrayList arrayList=new ArrayList();
        public void RemoveDuplicates()
        {
            arrayList.Add(25);
            arrayList.Add("Anna");
            arrayList.Add(false);
            arrayList.Add(25);
            arrayList.Add(DateTime.Now);
            arrayList.Add(112.22);
            arrayList.Add("Anna");
            arrayList.Add(false);
            for(int i=0;i<arrayList.Count; i++)
            {
                    for (int j = i + 1; j < arrayList.Count; j++)
                    {
                        if (arrayList[i].Equals(arrayList[j]) && arrayList[j] != null)
                        {
                            arrayList.RemoveAt(j);
                        }
                    }
                    Console.WriteLine(arrayList[i]);
            }
        }
    }
}
