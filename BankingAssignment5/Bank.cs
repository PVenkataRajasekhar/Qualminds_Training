/*
 * Bank class
 * to Execute transaction
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BankingAssignment5
{
    /// <summary>
    /// Bank class calls Three transaction class methods 
    /// And Executes the transaction
    /// </summary>
    public class Bank
    {
        private List<Transaction> transactions=new List<Transaction>();
        //List to add the accounts that are given by the user
        public List<Account> accounts = new List<Account>();

        //AddAccount method to Add accounts to the list 
        public void AddAccount(Account account)
        {
            accounts.Add(account);
        }

        //GetAccount method to get the accounts present int the accounts list
        public Account GetAccount(string name)
        {
            foreach (var account in accounts)
            {
                if (account.Name == name)
                {
                    return account;
                }
            }
            return null;

        }

        //ExecuteTransaction Method to call Execute method of all three classes
        public void ExecuteTransaction(Transaction transaction)
        {
            transactions.Add(transaction);
            transaction.Execute();
        }
        public void PrintTransactionHistory()
        {
            foreach (Transaction transaction in transactions)
            {
                transaction.Print();
            }
        }
    }

}

