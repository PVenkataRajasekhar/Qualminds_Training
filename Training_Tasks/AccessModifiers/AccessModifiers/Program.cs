using System.Runtime.CompilerServices;

namespace AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Demo demo = new Demo();

            demo.Hello();
            
        }

        protected void Name()
        {
            Console.WriteLine("I am Rajasekhar");
        }
    }
    public class Demo : Program
    {
        Program program = new Program();
        
        private int a = 10;
        public void Hello()
        {
            Console.WriteLine("hello everyone");
            Name();
            Console.WriteLine(a);
        }
    }
    
}
