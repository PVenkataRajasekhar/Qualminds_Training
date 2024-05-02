using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * CurrentAccount.cs
 * overrides abstract methods of abstract class
 */
namespace Interfaces
{
    /// <summary>
    /// CurrentAccount class inherits the AbstractClass class 
    /// And overrides all abstract methods present in it.
    /// </summary>
    internal class CurrentAccount:AbstractClass
    {
        //constructor of CurrentAccount class 
        public CurrentAccount(string name, decimal balance)
        {
            base.Name = name;
            base.Balance = balance;
        }

        //overriding AddAccount abstract method of AbstractClass class
        public override void AddAccount()
        {
            Console.WriteLine($"current Account Added with name {base.Name} and Balance is {base.Balance}");
        }

        //overriding Withdraw abstract method of AbstractClass class
        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"{amount} withdrawn from current account of {base.Name}");
            base.Balance -= amount;
            Console.WriteLine($"Balance of the account is {base.Balance}");
        }

        //overriding Deposit abstract method of AbstractClass class
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"{amount} deposited to current account of {base.Name}");
            base.Balance += amount;
            Console.WriteLine($"Balance of the account is {base.Balance}");
        }
    }
}
