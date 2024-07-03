using Customer.core.ICustomerRepository;
using Customer.core.Model;
using Customer.core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Infrastructure.Service
{
    public class CustomerService:ICustomerService
    {
        private readonly ICustomerRepository _CustomerRepository;

        public CustomerService(ICustomerRepository CustomerRepository)
        {
            _CustomerRepository=CustomerRepository;
        }
        public async Task<CustomerModel> IPostService(CustomerModel model)
        {
            return await _CustomerRepository.IPostRepository(model);
        }
    }
}
