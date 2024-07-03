namespace Arrays
{
    public class Program
    {
       static void Main(string[] args)
        {
            SingleDimensionalArray singleDimensionalArray=new SingleDimensionalArray();
            singleDimensionalArray.implement();
            singleDimensionalArray.ChangeArrayElements(arr1);
            singleDimensionalArray.ReverseArray(arr1);
            MultiDimensionalArray multiDimensionalArray=new MultiDimensionalArray();
            MultiDimensionalArray.implement();
            JaggedArray jaggedArray=new JaggedArray();
            jaggedArray.Implement();
        }
    }
    public class SingleDimensionalArray
    {
        //initializing the array
        static int[] arr1= new int[5] { 10, 20, 30, 40, 50 };
        public void implement()
        {
                    Console.WriteLine("printing the array elements");
            //printing the array elements
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            int n = 0;
            foreach (int i in arr1)
            {
                n++;
            }

            Console.WriteLine("printing the array elements after assigning the elements to another element");
            //assigning and accessing the array
            int[] arr2=new int[n];
            for(int i=0;i< arr2.Length;i++)
            {
                arr2[i] = arr1[i];
            }
             
            foreach (int i in arr2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("printing the array elements after changing some elements");
            ChangeArrayElements(arr1);
            //printing arr1 elements
            foreach (int i in arr1)
            {
                Console.WriteLine(i); 
            }
            Console.WriteLine();

            Console.WriteLine("printing the array elements after reversing the array");
            ReverseArray(arr1);
            //printing arr1 elements
            foreach (int i in arr1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
         static void ReverseArray(int[] arr1) => Array.Reverse(arr1);
        //passing single dimensional array as argument
        static void ChangeArrayElements(int[] arr1)
        {
            // Change the value of the first three array elements.
            arr1[0] = 17;
            arr1[1] = 23;
            arr1[2] = 42;
        }
        
    }
    public class MultiDimensionalArray
    {
          //declaring the multidimensional array
            string[,] cars = { { "volvo","Benz","safari" }, { "subaru","kia","audi" } };
            public void Implement()
            {
            Console.WriteLine("printing two dimensional array elements");
            //printing the multidimensional array
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(cars[i, j]+"\t");
                   
                }
                Console.WriteLine("\n");
            }
            }
    }
    public class JaggedArray
    {
        int[][] jagged_arr = new int[4][];
            public void Implement()
            {
            // Initialize the elements
            jagged_arr[0] = new int[] { 1, 2, 3, 4 };
            jagged_arr[1] = new int[] { 11, 34, 67 };
            jagged_arr[2] = new int[] { 89, 23 };
            jagged_arr[3] = new int[] { 0, 45, 78, 53, 99 };

            Console.WriteLine("printing jagged array elements");
            // Display the array elements:
            for (int i = 0; i < jagged_arr.Length; i++)
            {

                // Print the row number
                System.Console.Write("Row({0}): ", i);

                for (int k = 0; k < jagged_arr[i].Length; k++)
                {

                    // Print the elements in the row
                    System.Console.Write("{0} ",jagged_arr[i][k]);
                }
                System.Console.WriteLine();
            }
            }
    }
}
