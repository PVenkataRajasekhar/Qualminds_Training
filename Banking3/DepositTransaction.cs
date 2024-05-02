using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking3
{
    // Deposit Transaction class to show whether the money Deposit Executed or not
    public class DepositTransaction
    {
        //properties of DepositTransaction class
        private Account _account;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;

        public Account Account
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
        //constructor of DepositTransaction class
        public DepositTransaction(Account account, decimal amount)
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
            _executed = true;
            _success = _account.Deposit(_amount);
            if(_success==true)
               Print();
            if (_success == false)
            {
                _executed = false;
                Rollback();
                
            }
        }
        //Rollback 
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
                Console.WriteLine("DepositTransaction was successful");
                Console.WriteLine("the amount deposited is : {0}", _amount);
            }
            else
            {
                Console.WriteLine("DepositTransaction was unsuccessful");
            }
            if (_reversed == true)
            {
                Console.WriteLine("The transaction is reversed");
            }
        }
    }
}
