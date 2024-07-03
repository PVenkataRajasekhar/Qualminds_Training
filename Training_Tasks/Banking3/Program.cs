/*
 * Program.cs
 * Author : Rajasekhar
 * Transaction of Amount of the Accountant
 */
using System;

namespace Banking3
{
    /// <summary>
    /// Program class calls Account class methods
    /// And makes the transaction of amount and prints the other details of the employee
    /// </summary>
    /// Enumeration to store list of constants
    enum MenuOption
    {
        Withdraw,
        Deposit,
        Transfer,
        Print,
        Quit
    }
    public class Program
    {
        static int num;
        static int ReadUserOption()
        {

            //do_while loop 
            do
            {
                Console.WriteLine("Enter the MenuOption......");
                Console.WriteLine("0 for Withdraw");
                Console.WriteLine("1 for Deposit");
                Console.WriteLine("2 for transfer");
                Console.WriteLine("3 for print");
                Console.WriteLine("4 for Quit");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num <0 || num > 4);
            return num;
        }
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Main()
        {
            Account account = new Account(10000.00m, "Rajasekhar");
            Account account2 = new Account(500.00m, "Ravi");
            Console.WriteLine("Enter name of the Accountant");
            string name = Console.ReadLine();
            while (true)
            {
                if (name == account._Name)
                {
                    Console.WriteLine("Balance of the Accountant : {0}", account._Balance);
                    ReadUserOption();
                }
                else
                {
                    Console.WriteLine("Enter valid name of Accountant");
                    Main();
                }

                switch (num)
                {
                    case (int)MenuOption.Withdraw:
                        DoWithdraw(account);
                        break;
                    case (int)MenuOption.Deposit:
                        DoDeposit(account);
                        break;
                    case (int)MenuOption.Transfer:
                        DoTransfer(account,account2);
                        break;
                    case (int)MenuOption.Print:
                        DoPrint(account);
                        break;

                }
                if (num == (int)MenuOption.Quit)
                {
                    Console.WriteLine("transaction Ended");
                    break;
                }
            }
        }

    //private DoWithdraw method to call withdrawTransaction class methods
    private static void DoWithdraw(Account account)
    {
        Console.WriteLine("please give the amount to withdraw");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        WithdrawTransaction withdrawTransaction = new WithdrawTransaction(account, amount);
        withdrawTransaction.Execute();
    }
    //private DoDeposit method to call DepositTransaction class methods 
    private static void DoDeposit(Account account)
    {
        Console.WriteLine("please give the amount to deposit");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        DepositTransaction depositTransaction = new DepositTransaction(account, amount);
        depositTransaction.Execute();
        
    }
    //private DoTransfer method to call TransferTransaction class methods
    private static void DoTransfer(Account account,Account account2)
    {
        Console.WriteLine("please give the amount to transfer");
        decimal amount = Convert.ToDecimal(Console.ReadLine());
        TransferTransaction transferTransaction = new TransferTransaction(account,account2,amount);
        transferTransaction.Execute();
    }
    private static void DoPrint(Account account)
    {
        account.Print();
    }
    } 
}   
