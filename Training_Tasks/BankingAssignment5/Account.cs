/*
 * Account.cs
 * It implements the Amount Withdraw,Deposit,Transfer methods  
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment5
{
    /// <summary>
    /// Account class contains three types of money transaction methods 
    /// That do the transaction of money by using name,amount properties
    /// </summary>
    public class Account
    {
        //properties of Account class
        private decimal balance;
        private string name;

        public decimal Balance
        {
            set { balance = value; }
            get { return balance; }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        //constructor of Account class
        public Account(decimal Balance, string Name)
        {
            balance = Balance;
            name = Name;
        }

        //Withdraw method implementation
        public bool Withdraw(decimal amount)
        {
            if (amount <= balance && amount > 0)
            {
                balance -= amount;
                Console.WriteLine($"amount Withdrawn by {name}");
                Console.WriteLine("transaction successful");
                Console.WriteLine($"{name} account balance is : {balance}");
                Console.WriteLine();
                return true;
            }
            else if (amount > Balance)
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine("transaction failed");
                Console.WriteLine();
                return false;
            }
            else
            {
                Console.WriteLine("enter valid Amount to Withdraw");
                return false;
            }

        }


        //Deposit Method For amount Deposit
        public bool Deposit(decimal amount)
        {
            if (amount >= 0)
            {
                balance += amount;
                Console.WriteLine($"Amount deposited to {name}");
                Console.WriteLine($"{name} account balance is : {balance}");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("enter valid amount to deposit");
                Console.WriteLine();
                return false;
            }
        }
        //transfer Method implementation
        public bool transfer(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine("Amount transfer is successful");
                Console.WriteLine($"{name} account balance is : {balance}");
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("enter valid amount to transfer");
                Console.WriteLine();
                return false;
            }
        }
        //print method implementation
        public bool Print()
        {
            Console.WriteLine($"{name} account balance is : {balance}");
            Console.WriteLine();
            return true;
        }
    }
}
