/*
 * Program.cs
 * Author : Rajasekhar
 * Transaction of Amount from one bank to other
 */

namespace BankingAssignment5
{
    /// <summary>
    /// Program class calls Bank class methods
    /// And makes the transaction of amount and prints the other details of the employee
    /// </summary>
    /// Enumeration to store list of constants

    enum MenuOption
    {
        NewAccount,
        Withdraw,
        Deposit,
        Transfer,
        PrintHistory,
        Quit
    }
    public class Program
    {
        //properties required
        static int num;

        //ReadUserOption method to print the available options to the users
        static int ReadUserOption()
        {

            //do_while loop 
            do
            {
                Console.WriteLine("Enter the MenuOption......");
                Console.WriteLine("0 for NewAccount");
                Console.WriteLine("1 for Withdraw");
                Console.WriteLine("2 for Deposit");
                Console.WriteLine("3 for transfer");
                Console.WriteLine("4 for printHistory");
                Console.WriteLine("5 for Quit");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0 || num > 5);
            return num;
        }

        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main()
        {
            //Bank class instance
            Bank bank = new Bank();
            //While loop for looping the application until we do exit
            while (true)
            {
                //Function call 
                ReadUserOption();
                //Switch case to go to the implementation that user want to do
                switch (num)
                {
                    case (int)MenuOption.NewAccount:
                        try
                        {
                            Console.WriteLine("Enter the Name of the Accountant:");
                            string name1 = Console.ReadLine();
                            Console.WriteLine("Enter initial amount you are going to Deposit:");
                            decimal Amount = Convert.ToDecimal(Console.ReadLine());
                            Account account = new Account(Amount, name1);
                            bank.AddAccount(account);
                            Console.WriteLine($"{name1} account has been added to bank!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Number format exception");
                        }
                        break;
                    case (int)MenuOption.Withdraw:
                        DoWithdraw(bank);
                        break;
                    case (int)MenuOption.Deposit:
                        DoDeposit(bank);
                        break;
                    case (int)MenuOption.Transfer:
                        DoTransfer(bank, bank);
                        break;
                    case (int)MenuOption.PrintHistory:
                        DoPrint(bank);
                        break;

                }
                if (num == (int)MenuOption.Quit)
                {
                    Console.WriteLine("transaction Ended");
                    break;
                }
            }
        }
        //FindAccount method to find the Account is present in the bank list or not
        private static Account FindAccount(Bank fromBank)
        {
            string name = Console.ReadLine();
            Account result = fromBank.GetAccount(name);
            if (result == null)
            {
                Console.WriteLine($"No account found with Name {name}");
            }
            return result;
        }
        //private DoWithdraw method to call withdrawTransaction class methods
        private static void DoWithdraw(Bank fromBank)
        {
            Console.WriteLine("Enter Accountant Name to withdraw amount:");
            Account fromAccount = FindAccount(fromBank);
            if (fromAccount == null) return;
            Console.WriteLine("please give the amount to withdraw");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            WithdrawTransaction withdrawTransaction = new WithdrawTransaction(fromAccount, amount);
            fromBank.ExecuteTransaction(withdrawTransaction);
        }
        //private DoDeposit method to call DepositTransaction class methods 
        private static void DoDeposit(Bank toBank)
        {
            Console.WriteLine("Enter Accountant Name to deposit money :");
            Account toAccount = FindAccount(toBank);
            if (toAccount == null) return;
            Console.WriteLine("please give the amount to deposit");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            DepositTransaction depositTransaction = new DepositTransaction(toAccount, amount);
            toBank.ExecuteTransaction(depositTransaction);

        }
        //private DoTransfer method to call TransferTransaction class methods
        private static void DoTransfer(Bank fromBank, Bank toBank)
        {
            Console.WriteLine("Enter Name of the accountant from which amount to be withdrawn:");
            Account fromAccount = FindAccount(fromBank);
            Console.WriteLine("Enter Name of the accountant to which amount to be deposited:");
            Account toAccount = FindAccount(toBank);
            if (fromAccount == null) return;
            if (toAccount == null) return;
            Console.WriteLine("please give the amount to transfer");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            TransferTransaction transferTransaction = new TransferTransaction(fromAccount, toAccount, amount);
            fromBank.ExecuteTransaction(transferTransaction);
        }
        private static void DoPrint(Bank bank)
        {
            bank.PrintTransactionHistory();
        }
    }
}

 