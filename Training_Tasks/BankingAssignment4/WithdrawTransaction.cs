/*
 * WithdrawTransaction.cs
 * It contains the Execute method Which calls the Withdraw method of Account class 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BankingAssignment4
{
    /// <summary>
    /// WithdrawTransaction contains three types of methods 
    /// Execute,RollBack,Print methods 
    /// If execution fails then it rollbacks the transaction and prints the status of the transaction
    /// by using print method
    /// </summary>
    public class WithdrawTransaction
    {
        //Properties of WithdrawTransaction method
        private Account _account;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;

        public Account _Account
        {
            set { _account = value; }
            get { return _account; }
        }
        public decimal Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        //Constructor of WithdrawTransaction class
        public WithdrawTransaction(Account account, decimal amount)
        {
            _account = account;
            _amount = amount;
        }

        //Execute Method to check whether transaction is executed or not
        public void Execute()
        {
            if (_executed)
            {
                throw new Exception("cannot execute this transaction as it has already executed");
            }
            _success = _account.Withdraw(_amount);
            if (_success == false)
            {
                _executed = false;
                Rollback();

            }
        }

        //Rollback method to rollback if Execution not done
        public void Rollback()
        {
            _reversed = true;
            if (_executed == false && _reversed == true)
            {
                Print();
            }
        }
        public void Print()
        {
            if (_success == true)
            {
                Console.WriteLine("WithdrawTransaction is successful");
                Console.WriteLine("the amount withdrawn is : {0}", _amount);
            }
            else
            {
                Console.WriteLine("WithdrawTransaction is unsuccessful");
            }
            if (_reversed == true)
            {
                Console.WriteLine("The transaction is reversed");
            }
        }

    }
}
