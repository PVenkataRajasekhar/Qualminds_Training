/*
 * Program.cs
 * Author : Rajasekhar
 * Transaction of Amount of the Accountant
 */
using Banking;
using Banking2;
using System;
using System.ComponentModel;
using System.Threading.Channels;

/// <summary>
/// Program class calls Account class methods
/// And makes the transaction of amount and prints the other details of the employee
/// </summary>

namespace Banking
{
    /// <summary>
    /// The entry point for the application.
    /// </summary>
    /// <param name="args"> A list of command line arguments</param>
    /// Enumeration to store list of constants
    enum MenuOption
    {
        Withdraw,
        Deposit,
        Print,
        Quit
    }

    
    public class Program
    {
        static int num;
        static void ReadUserOption()
        {   //do_while loop 
            do
            {
                Console.WriteLine("Enter the MenuOption......");
                Console.WriteLine($"0 for {MenuOption.Withdraw}");
                Console.WriteLine($"1 for {MenuOption.Deposit}");
                Console.WriteLine($"2 for {MenuOption.Print}");
                Console.WriteLine($"3 for {MenuOption.Quit}");
                num = Convert.ToInt32(Console.ReadLine());

            } while (num < 0 && num > 3);
        }
        
        static void Main()
        {
            Method();
        }
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args"> A list of command line arguments</param>
        static void Method()
        {
            Account account = new Account(10000.00m, "Rajasekhar");
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
    
        //private DoWithdraw method to call withdraw method in Account class
        private static void DoWithdraw(Account account )
        {
            Console.WriteLine("please give the amount to withdraw");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Withdraw(amount);
        }

        //private DoDeposit method to call Deposit method in Account class
        private static void DoDeposit(Account account)
        {
            Console.WriteLine("please give the amount to deposit");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            account.Deposit(amount);
        }

        //private DoPrint method to call print method in Account class
        private static void DoPrint(Account account)
        {
            account.Print();
        }
    }
           

}

