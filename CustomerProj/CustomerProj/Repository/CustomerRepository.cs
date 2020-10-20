using CustomerProj.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerProj.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly pharmacy_dbContext _context;

        public CustomerRepository(pharmacy_dbContext context)
        {
            _context = context;
        }
        public IQueryable<Customer> DeleteCustomer(int id)
        {
            IQueryable<Customer> customers = _context.Customer.Where(a => a.CustomerId == id);
            _context.Customer.Remove(customers.FirstOrDefault());
            _context.SaveChangesAsync();
            return customers;
        }

        public List<Customer> GetCustomer()
        {
            return _context.Customer.ToList();
        }

        public IQueryable<Customer> GetCustomer(int id)
        {
            return _context.Customer.Where(a => a.CustomerId == id);
        }

        public void PostCustomer(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChangesAsync();
        }

        public Customer PutCustomer(int id, Customer customer)
        {
            _context.Entry(customer).State = EntityState.Modified;
            _context.SaveChangesAsync();
            return customer;
        }
    }
}
