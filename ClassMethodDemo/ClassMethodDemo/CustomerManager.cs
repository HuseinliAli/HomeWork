using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Name} is succesfully added to database");
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine($"{customer.Name} is succesfully deleted to database");
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("*****************Customer`s Information*****************\n");
            Console.WriteLine($"Name and Surname: {customer.Name} {customer.Surname}");
            Console.WriteLine($"Market Value: {customer.TotalPrice}");
            Console.WriteLine("\n********************************************************\n");
        }
    }
}
