using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingAssignment5
{
    public abstract class Transaction
    {
        protected decimal amount;
        private bool executed;
        private bool reversed;
        private DateTime dateStamp;
        
        public bool Executed
        {
            get { return executed; }
        }
        public bool Reversed
        {
            get{ return reversed; }
        }
        public DateTime DateStamp
        {
            get { return dateStamp; }
        }
        public Transaction(decimal Amount)
        {
            amount = Amount;
        }
        public abstract bool Success
        {
            get;
        }
        public abstract void Print();
        public virtual void Execute() 
        {
            if (executed)
            {
                throw new Exception("Transaction Executed already");
            }
            executed = true;
            dateStamp = DateTime.Now;
        }
        public virtual void Rollback()
        {
            if (reversed)
            {
                throw new Exception("Transaction already reversed");
            }
            reversed= true;
            dateStamp= DateTime.Now;
        }
    }
}
