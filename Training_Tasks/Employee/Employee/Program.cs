namespace Employee
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Emp obj = new Emp("Ram", 1000);
            Console.WriteLine(obj.GetDetails()); 
           Emp obj1 = new Emp("ravi", 2000);
            Console.WriteLine(obj1.GetDetails()); 
        }
    }
}
