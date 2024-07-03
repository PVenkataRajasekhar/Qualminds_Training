/*
 * Interface1.cs
 * contains only properties and methods without body
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    /// <summary>
    /// Interface class contains methods without body
    /// And implementation should be in derived classes
    /// </summary>
    internal interface Interface1
    {
        string Name { get; set; }
        decimal Balance { get; set; }

        //Methods with definition of interface
        public void AddAccount();
        public void Withdraw(decimal amount);
        public void Deposit(decimal amount);
    }
}
