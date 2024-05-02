/*
 * Sample4.cs
 * This program creates a Sample class to declare, 
 * intialize and display all variables present in c# .Net.
 */

using System;
using System.Text;

namespace Day1
{
    /// <summary>
    /// Sample4 class stores and displays the details 
    /// using different data types.
    /// </summary>
    class Sample4
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Declaring and intialising variables to store values
            int id = 714709; // range[-2,147,483,648 to 2,147,483,647],size[4 bytes]
            string name = "Ganesh"; // range[1 to 2^31-1 characters]
            byte age = 32;// range[0 to 255],size[1byte = 8 bits]
            char gender = 'M';// single characterin single quote,size[2 bytes]
            float percentage = 75.50F;// range[±1.5 x 10−45 to ±3.4 x 1038],size[4 bytes]
            sbyte sb = -100;// range[-128 to 127],size[1 byte]
            short sh = 10000;// range[-32,768 to 32,767],size[2 bytes]
            ushort us = 2738;// range[0 to 65,535],size[2 bytes]
            uint ui = 198392939;//range[0 to 4,294,967,295],size[4 bytes]
            long l = -7247974399;//range[-9,223,372,036,854,775,808 to 9,223,372,036,854,775,807],size[8 bytes]
            ulong ul = 289381288488;//range[0 to 18,446,744,073,709,551,615],size[8 bytes]
            nint ni = 790504048; //range[Depends on platform (computed at runtime)],size[4 or 8 bytes]
            nuint nu = 646556566;//range[Depends on platform (computed at runtime)],size[4 or 8 bytes]
            double db = 23.1D;//range[±5.0 × 10−324 to ±1.7 × 10308],size[8 bytes]
            decimal dc = 23546.8M;//range[±1.0 x 10-28 to ±7.9228 x 1028],size[16 bytes]
            bool bo = true;//range[true or false],size[4 bytes]

            //Displaying the values
            Console.WriteLine("ID : {0}", id);
            Console.WriteLine("Name : {0}", name);
            Console.WriteLine("Age : " + age);
            Console.WriteLine("Gender : " + gender);
            Console.WriteLine("Percentage : {0:F}", percentage);
            Console.WriteLine("sbyte : " + sb);
            Console.WriteLine("short : " + sh);
            Console.WriteLine("ushort : " + us);
            Console.WriteLine("uint : " + ui);
            Console.WriteLine("nint : " + ni);
            Console.WriteLine("nuint : " + nu);
            Console.WriteLine("double : " + db);
            Console.WriteLine("decimal : " + dc);
            Console.WriteLine("bool : " + bo);
            Console.ReadKey();
        }
    }
}


