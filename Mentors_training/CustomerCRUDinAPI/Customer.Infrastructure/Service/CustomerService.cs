using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Core.Service;
using Customer.Core.Model;
using Customer.Core.Repository;


namespace Customer.Infrastructure.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public string CreateCustomer(CustomerModel customer)
        {
           
            return _customerRepository.Post(customer);
        }

        public CustomerModel GetCustomerById(int customerId)
        {
            return _customerRepository.GetById(customerId);
        }

        public IEnumerable<CustomerModel> GetAllCustomers()
        {
            return _customerRepository.Get();
        }

        public void UpdateCustomer(CustomerModel customer)
        {
            
            _customerRepository.Put(customer);
        }

        public void DeleteCustomer(int customerId)
        {
      
            _customerRepository.Delete(customerId);
        }
        public Task<string> CallOtherApiGet(string accessToken)
        {
            return _customerRepository.CallOtherApiMethod(accessToken);
        }
        public Task<string> GetById(int id)
        {
            return _customerRepository.GetProductUsingId(id);
        }
        public Task<string> Create(ProductModel productModel)
        {
            return _customerRepository.CreateProducts(productModel);
        }
        public Task<string> Update(ProductModel productModel)
        {
            return _customerRepository.UpdateProducts(productModel);
        }
        public Task<string> Delete(int id)
        {
            return _customerRepository.DeleteProducts(id);
        }
    }
}
