namespace Delegates
{
    public delegate void BitwiseHandler(int n1, int n2);
    public class Operators
    {
        public void BitwiseAND(int a, int b)
        {
            Console.WriteLine($"Bitwise AND operation of {a} and {b} is:{a & b} ");
        }
        public void BitwiseOR(int a, int b)
        {
            Console.WriteLine($"Bitwise OR operation of {a} and {b} is:{a | b} " );
        }
        public void BitwiseXOR(int a, int b)
        {
            Console.WriteLine($"Bitwise XOR operation of {a} and {b} is:{a ^ b} ");
        }

    }

    public class Program
    { 
        static void Main(string[] args)
        {
            Operators operators = new Operators();
            BitwiseHandler bitObj1, bitObj2, bitObj3, bitObj4 ;

            //single casting delegates
            bitObj1 = new BitwiseHandler(operators.BitwiseAND);
            bitObj2 = new BitwiseHandler(operators.BitwiseOR);
            bitObj3 = new BitwiseHandler(operators.BitwiseXOR);

            //multicasting a delegates
            bitObj4 = bitObj1 + bitObj2 + bitObj3;

            bitObj1(2, 3);
            bitObj2(4, 6);
            bitObj3(7, 9);
            bitObj4(12, 15);

        }
    }
}
