using CustomerProj.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProj.Repository
{
    public interface ICustomerRepository
    {
        public List<Customer> GetCustomer();
        public IQueryable<Customer> GetCustomer(int id);
        public Customer PutCustomer(int id, Customer customer);
        public void PostCustomer(Customer customer);
        public IQueryable<Customer> DeleteCustomer(int id);
    }
}
