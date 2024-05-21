using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer.Core.Repository;
using Customer.Core.Model;
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
        
        public List<CustomerModel> Get()
        {
            return context.Customers.ToList<CustomerModel>();
        }
        public CustomerModel GetById(int id)
        {
            var customer = context.Customers.Find(id);
            if (customer != null)
            {
                return customer;
            }
            return null;
        }
        public string Post(CustomerModel customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
            return "Customer Record Created Successfully";
        }
        public string Put(CustomerModel customer)
        {
            var Cust = context.Customers.Find(customer);
            if (Cust == null)
            {
                return "Customer not found";
            }
            else
            {
                context.Customers.Update(customer);
                context.SaveChanges();
                return "Customer record updates succesfully";
            }
        }
        public string Delete(int id)
        {
            var customerToDelete = context.Customers.Find(id);
            if (customerToDelete != null)
            {
                context.Customers.Remove(customerToDelete);
                context.SaveChanges();
                return "Customer record deleted successfully";
            }
            else
            {
                return "Customer not found";
            }
        }
    }
}
