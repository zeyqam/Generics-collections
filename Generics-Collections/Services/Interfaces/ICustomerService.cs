using Generics_Collections.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections.Services.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();
        Customer GetById(int id);
        List<Customer> GetAllByAge(int age);
        int GetCount();
    }
}
