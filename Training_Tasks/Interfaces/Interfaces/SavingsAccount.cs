/*
 * SavingsAccount.cs
 * overrides abstract methods of abstract class
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// SavingsAccount class inherits the AbstractClass class 
    /// And overrides all abstract methods present in it.
    /// </summary>
    internal class SavingsAccount:AbstractClass
    {
        //constructor of SavingsAccount class 
        public SavingsAccount(string name,decimal balance)
        {
            base.Name=name;
            base.Balance = balance;
        }

        //overriding AddAccount abstract method of AbstractClass class
        public override void AddAccount()
        {
            Console.WriteLine($"Savings Account Added with name {base.Name} and Balance is {base.Balance}");
        }

        //overriding Withdraw abstract method of AbstractClass class
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"{amount} withdrawn from savings account of {base.Name}");
            base.Balance -= amount;
            Console.WriteLine($"Balance of the account is {base.Balance}");
        }

        //overriding Deposit abstract method of AbstractClass class
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"{amount} deposited to savings account of {base.Name}");
            base.Balance += amount;
            Console.WriteLine($"Balance of the account is {base.Balance}");
        }

        //Normal method of SavingsAcount class to find interest rate for balance amount in account
        public void InterestRate(decimal interest)
        {
            decimal TotalInterest = (base.Balance / (100 * 30)) * interest;
            Console.WriteLine($"Interest for your balance of {base.Balance} per day is {TotalInterest}");
        }
    }
}
