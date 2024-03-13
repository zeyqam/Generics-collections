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

        public List<Customer> GetOrderByage(string sortOrder)
        {
            if (sortOrder.ToLower() == "ascending")
            {
                return AppDbContext.customers.OrderBy(m => m.Age).ToList();
            }
            else if (sortOrder.ToLower() == "descending")
            {
                return AppDbContext.customers.OrderByDescending(m => m.Age).ToList();
            }
            else
            {
                throw new ArgumentException(" ascending veya descending istifade edin.");
            }
        }
    }
}
