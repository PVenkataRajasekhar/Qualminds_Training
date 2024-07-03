using Customer.core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.core.Service
{
    public interface ICustomerService
    {
        public Task<CustomerModel> IPostService(CustomerModel customerModel);
    }
}
