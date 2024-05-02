namespace GenericCollections
{
    public class Program
    {
        public class Subtraction<T>
        {
            private T firstNumber;

            public T FirstNumber
            {
                get { return firstNumber; }
                set { firstNumber = value; }
            }
            private T secondNumber;

            public T SecondNumber
            {
                get { return secondNumber; }
                set { secondNumber = value; }
            }
        }
        public class StringConcatenate<T>
        {
            private T first;
            public T First
            {
                get { return first; }
                set { first = value; }
            }
            private T second;
            public T Second
            {
                get { return second; }
                set { second = value; }
            }
        }

        static void Main(string[] args)
        {
            Subtraction<float> subtraction = new Subtraction<float>();
            subtraction.FirstNumber = 103.67f;
            subtraction.SecondNumber = 98.7f;

            float firstNO = subtraction.FirstNumber;
            float secondNO = subtraction.SecondNumber;
            float result = firstNO - secondNO;
            Console.WriteLine(result);

            Subtraction<int> subtraction1 = new Subtraction<int>();
            subtraction1.FirstNumber = 50;
            subtraction1.SecondNumber = 10;

            int FirstNO = subtraction1.FirstNumber;
            int SecondNO = subtraction1.SecondNumber;
            int Result = FirstNO - SecondNO;
            Console.WriteLine(Result);

            lists l = new lists();
            l.Subtract();

            linkedlists ll = new linkedlists();
            ll.Subtract();

            StringConcatenate<string> concat = new StringConcatenate<string>();
            concat.First = "Hii I am Rajasekhar";
            concat.Second = "Hello I am Ramu";

            string firstString = concat.First;
            string secondString = concat.Second;
            string resultString = firstString +"\n" +secondString;
            Console.WriteLine(resultString);
        }
    }
}


