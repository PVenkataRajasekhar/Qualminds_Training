/*
 * AbstractClass.cs
 * AbstractClass class is abstract class and derived from Interface1
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// AbstractClass class contains both abstract methods and concrete methods also
    /// And implementation for abstract methods should be in derived classes
    /// </summary>
    abstract class AbstractClass : Interface1
    {
       //properties of AbstractClass class
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public string SelectAccountType;

        //Concrete method of AbstractClass class
        public void AccountType()
        {
            SavingsAccount savings = new SavingsAccount(Name,Balance);
            CurrentAccount current = new CurrentAccount(Name,Balance);
            Console.WriteLine("Enter SavingsAccount for Creating Savings Account,CurrentAccount for creating current Account ");
            SelectAccountType = Console.ReadLine();
            if (SelectAccountType == "SavingsAccount")
            {
                savings.AddAccount();
            }
            else if (SelectAccountType == "CurrentAccount")
            {
                current.AddAccount();
            }
            else
            {
                Console.WriteLine("Enter valid Account name!");
            }
        }

        //methods of Interface1 class are made as abstract in AbstractClass class
        public abstract void AddAccount();
        public abstract void Withdraw(decimal amount);
        public abstract void Deposit(decimal amount);
    }
}
