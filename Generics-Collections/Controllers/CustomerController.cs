using Generics_Collections.Services;
using Generics_Collections.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Collections.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerService _customerService;
        public CustomerController()
        {
            _customerService = new CustomerService();
        }
        public void GetAll()
        {
            foreach (var item in _customerService.GetAll())
            {
                Console.WriteLine(item.FullName+"-" + item.Address + "-" +item.Age);    
            }
        }

        public void GetById()
        {
            try
            {
                int id = 4;
                var result = _customerService.GetById(id);
                Console.WriteLine(result.FullName + "-" + result.Address + "-" + result.Age);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void GetAllByAge()
        {
            int age = 21;
            foreach (var item in _customerService.GetAllByAge(age))
            {
                Console.WriteLine(item.FullName + "-" + item.Address + "-" + item.Age);
            }

        }
        public void GetACountOfDatas()
        {
            Console.WriteLine(_customerService.GetCount());
        }
    }
}
