using Customer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Core.Service
{
    public interface ICustomerService
    {
        CustomerModel GetCustomerById(int customerId);
        IEnumerable<CustomerModel> GetAllCustomers();
        string CreateCustomer(CustomerModel customer);
        void UpdateCustomer(CustomerModel customer);
        void DeleteCustomer(int customerId);
    }
}
