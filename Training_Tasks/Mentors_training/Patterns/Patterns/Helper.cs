using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Patterns
{
    public class Helper
    {
        public void ReveseTriangle()
        {
            Console.WriteLine("Enter Number of rows you want:");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i = 1;i <= num; i++)
            {
                for(int j = num; j >=i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void Pyramid(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                for (int j = num-i; j >=1; j--)
                {
                    Console.Write(" ");
                }
                for (int k = i; k >=1; k--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

        }
    }
}
