/*
 * Account.cs
 * implementation of Withdraw and Deposit methods
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Banking2
{

    /// <summary>
    /// Account class takes the Name of the Accountant
    /// And makes the transaction of amount and prints the other details of the employee
    /// </summary>
    public class Account
    {
        //declaration of properties
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
        public Account(decimal _balance, string _name)
        {
            _Balance = _balance;
            _Name = _name;
        }
        
        //Withdraw Method implementation
        public bool Withdraw(decimal amount)
        {
            if (amount < _balance && amount>0)
            {
                _balance -= amount;
                Console.WriteLine("amount Withdrawn");
                Console.WriteLine("transaction sucessful");
                Console.WriteLine("your account balabce is : {0}", _balance);
                Console.WriteLine();
                
            }
            else if(amount>_Balance)
            {
                Console.WriteLine("Insufficient Balance");
                Console.WriteLine("transaction failed");
                Console.WriteLine();
               
            }
            else
            {
                Console.WriteLine("enter valid Amount to Withdraw");
                Console.WriteLine();
               
            }
            return true;
            
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
            }
            else
            {
                Console.WriteLine("enter valid amount to deposit");
            }
            return true;
        }

        //print method to print details after transaction
        public void Print()
        {
            Console.WriteLine("your account balance is : {0}", _balance);
        }
    }
}

