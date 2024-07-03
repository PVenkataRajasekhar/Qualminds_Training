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

namespace BankingAssignment4
{
    /// <summary>
    /// Bank class calls Three transaction class methods 
    /// And Executes the transaction
    /// </summary>
    public class Bank
    {
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

        //ExecuteTransaction Method to call Execute method of WithdrawTransaction class
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            transaction.Execute();
        }

        //ExecuteTransaction Method to call Execute method of DepositTransaction class
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            transaction.Execute();
        }

        //ExecuteTransaction Method to call Execute method of TransferTransaction class
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            transaction.Execute();
        }
    }

}

