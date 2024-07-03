/*
 * Transaction.cs
 * Implementation for Transaction of amount from account
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Transaction class contains TransactionMethod method
    /// which takes the user input and calls the different accounts
    /// </summary>
    internal class Transaction
    {
        //TransactionMethod method implementation
        public void TransactionMethod()
        {
            Console.WriteLine("Enter Accountant name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Amount you are depositing:");
            decimal Balance = Convert.ToDecimal(Console.ReadLine());

            CurrentAccount current = new CurrentAccount(Name, Balance);
            SavingsAccount savings = new SavingsAccount(Name, Balance);
            current.AccountType();
            if (current.SelectAccountType == "SavingsAccount")
            {
                savings.AddAccount();
                Console.WriteLine("Enter Withdraw to withdraw money or Deposit to deposit money");
                string Option = Console.ReadLine();
                if (Option == "Withdraw")
                {
                    Console.WriteLine("Enter Amount to Withdraw");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    savings.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("Enter Amount to deposit");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    savings.Deposit(amount);
                }
            }
            else
            {
                current.AddAccount();
                Console.WriteLine("Enter Withdraw to withdraw money or Deposit to deposit money");
                string Option = Console.ReadLine();
                if (Option == "Withdraw")
                {
                    Console.WriteLine("Enter Amount to Withdraw");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    current.Withdraw(amount);

                }
                else
                {
                    Console.WriteLine("Enter Amount to deposit");
                    decimal amount = Convert.ToDecimal(Console.ReadLine());
                    current.Deposit(amount);
                }
            }
        }
    }
}
