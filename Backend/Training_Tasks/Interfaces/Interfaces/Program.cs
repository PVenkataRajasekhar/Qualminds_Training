/*
 * Program.cs
 * Author : Rajasekhar
 * Interface implementation
 */
namespace Interfaces
{
    /// <summary>
    /// Program class calls Transaction class method
    /// And makes the transaction of amount and prints the other details of the accountant
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main(string[] args)
        {
            //Exception handling
            try
            {
                Transaction transaction = new Transaction();
                transaction.TransactionMethod();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("This is interface program");
            }
        }
    }
}
