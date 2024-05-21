using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Core.Model;
namespace Customer.Core.Repository
{
    public interface ICustomerRepository
    {
        public List<CustomerModel> Get();
        public CustomerModel GetById(int id);
        public string Post(CustomerModel customer);
        public string Put(CustomerModel customer);
        public string Delete(int id);
    }
}
