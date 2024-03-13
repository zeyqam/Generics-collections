using Generics_Collections.Data;
using Generics_Collections.Models;
using Generics_Collections.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections.Services
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> GetAll()
        {
            return AppDbContext.customers;
        }

        public Customer GetById(int id)
        {
            return id==null? throw new ArgumentNullException() : AppDbContext.customers.FirstOrDefault(m => m.Id==id);
        } 

        public List<Customer> GetAllByAge(int age)
        {
            return AppDbContext.customers.Where(m=>m.Age==age).ToList();
        }

        public int GetCount()
        {
            return AppDbContext.customers.Count();
        }
    }
}
