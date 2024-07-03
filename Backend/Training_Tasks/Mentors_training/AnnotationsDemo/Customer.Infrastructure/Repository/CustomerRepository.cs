using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.core.ICustomerRepository;
using Customer.core.Model;
using Customer.Infrastructure.Context;

namespace Customer.Infrastructure.Repository
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly CustomerCrudDbContext context;
        public CustomerRepository(CustomerCrudDbContext Context)
        {
            context = Context;
        }
        public async Task<CustomerModel> IPostRepository(CustomerModel customerModel)
        {
            var customer = await context.Customers.AddAsync(customerModel);
            await context.SaveChangesAsync();
            return customer.Entity;
        }
    }
}
