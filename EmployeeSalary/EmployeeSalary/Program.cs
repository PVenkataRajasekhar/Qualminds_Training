namespace EmployeeSalary
{
    public abstract class Payment
    {
        public abstract void ProcessPayment(decimal amount);
    }
    public class Associates:Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine(" ");
        }
    }
    public class Leads : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine(" ");
        }
    }
    public class Testers : Payment
    {
        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine(" ");
        }
    }
    public class EcommercePlatform
    {
        public void checkout(Payment payment,decimal amount)
        {
            payment.ProcessPayment(amount);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            EcommercePlatform platform = new EcommercePlatform();

            Payment associates = new Associates();
            Payment leads = new Leads();
            Payment testers = new Testers();
        }
    }
}
