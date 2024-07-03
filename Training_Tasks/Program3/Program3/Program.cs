/*
* Sample3.cs
* This program creates a Sample class to, 
* intialize and add two integer variables and prints the result.
*/

using System;
using System.Text;

namespace Day1
{
    /// <summary>
    /// Sample3 class stores and displays the result by adding those two integer values. 
    /// </summary>
    class Sample03
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Declaration of two integer variables
            int firstNumber, secondNumber, result;

            //Taking the values of variables as user input
            Console.WriteLine("Enter FirstNumber:");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter SecondNumber:");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            //Adding the two values to result
            result = firstNumber + secondNumber;

            //Printing the result of addition of those two values
            Console.WriteLine("Addition of " + firstNumber + " and " + secondNumber + " is " + result);
            //  Console.WriteLine("Addition of {0} and {1} is {2}", firstNumber, secondNumber, result);
            Console.ReadKey();
        }
    }
}


/*
	Datatype	Conversion
	========	==========
	byte		Convert.ToByte()
	sbyte		Convert.ToSByte()
	short		Convert.ToInt16()
	ushort		Convert.ToUInt16()
	int			Convert.ToInt32()
	uint		Convert.ToUInt32()
	long		Convert.ToInt64()
	ulong		Convert.ToUInt64()
	float		Convert.ToSingle()
	double		Convert.ToDouble()
	decimal		Convert.ToDecimal()
	bool		Convert.ToBoolean()
	char		Convert.ToChar()
	DateTime	Convert.ToDateTime()
*/

