/*
 * Account.cs
 * implementation of Withdraw and Deposit methods
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking3
{

    /// <summary>
    /// Account class takes the Name of the Accountant
    /// And makes the transaction of amount and prints the other details of the employee
    /// </summary>
    public class Account
    {
        //propeties of Account class
        private decimal _balance;
        private string _name;

        public decimal _Balance
        {
            set { _balance = value; }
            get { return _balance; }
        }
        public string _Name
        {
            set { _name = value; }
            get { return _name; }
        }

        //constructor of Account class
        public Account(decimal _balance, string _name)
        {
            _Balance = _balance;
            _Name = _name;
        }

        //Withdraw method implementation
        public bool Withdraw(decimal amount)
        {
            if (amount < _balance && amount > 0)
            {
                _balance -= amount;
                Console.WriteLine("amount Withdrawn");
                Console.WriteLine("transaction sucessful");
                Console.WriteLine("your account balance is : {0}", _balance);
                Console.WriteLine();
                return true;
            }
            else if (amount > _Balance)
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
                _balance += amount;
                Console.WriteLine("your deposit is sucessful");
                Console.WriteLine("your account balance is : {0}", _balance);
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
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine("your transfer is sucessful");
                Console.WriteLine("your account balance is : {0}", _balance);
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
            Console.WriteLine("your account balance is : {0}", _balance);
            Console.WriteLine();
            return true;
        }
    }
}
