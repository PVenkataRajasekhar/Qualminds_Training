using Customer.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.core.ICustomerRepository
{
    public interface ICustomerRepository
    {
        public Task<CustomerModel> IPostRepository(CustomerModel customerModel);
    }
}
