using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking3
{
    public class TransferTransaction
    {
        private Account _toAccount;
        private Account _fromAccount;
        private decimal _amount;
        private bool _executed = false;
        private bool _success = false;
        private bool _reversed = false;
        DepositTransaction _theDeposit;
        WithdrawTransaction _theWithdraw;

        public Account _FromAccount
        {
            set { _fromAccount = value; }
            get { return _fromAccount; }
        }
        public Account _ToAccount
        {
            set { _toAccount = value; }
            get { return _toAccount; }
        }
        public decimal Amount
        {
            set { _amount = value; }
            get { return _amount; }
        }
        public bool Executed { get { return _executed; } }
        public bool Success { get { return _success; } }
        public bool Reversed { get { return _reversed; } }

        public TransferTransaction(Account _FromAccount, Account  ToAccount, decimal _amount)
        {
            _fromAccount = _FromAccount;
            _toAccount = ToAccount;
            Amount = _amount;
            _theWithdraw = new WithdrawTransaction(_fromAccount, Amount);
            _theDeposit = new DepositTransaction(_toAccount, Amount);
        }
        public void Execute()
        {
            if (_executed)
            {
                throw new Exception("cannot execute this transaction as it has already executed");
            }
            _executed = true;
            _theWithdraw.Execute();
            _theDeposit.Execute();
            if (_theWithdraw.Success == true && _theDeposit.Success == true)
            {
                _success = true;
            }
            else
            {
                _success = false;
            }
            if (_success == false)
            {
                _executed = false;
                Rollback();

            }
        }
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
                Console.WriteLine("TransferTransaction was successful");
                Console.WriteLine("the amount transfered is : {0}", _amount);
            }
            else
            {
                Console.WriteLine("TransferTransaction was unsuccessful");
            }
            if (_reversed == true)
            {
                Console.WriteLine("The transaction is reversed");
            }
        }
    }
}
