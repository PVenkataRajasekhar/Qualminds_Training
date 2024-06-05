using Customer.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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
        public  Task<string> CallOtherApiGet(string accessToken);
        public Task<string> GetById(int id);
        public Task<string> Create(ProductModel productModel);
        public Task<string> Update(ProductModel productModel);
        public Task<string> Delete(int id);
    }
}
