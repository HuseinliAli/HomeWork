using System;

namespace ClassMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Ali";
            customer1.Surname = "Huseynli";
            customer1.TotalPrice = 1289.75;

            Customer customer2 = new Customer();
            customer2.Name = "Badam";
            customer2.Surname = "Erikli";
            customer2.TotalPrice = 567.4;

            Customer customer3 = new Customer();
            customer3.Name = "Sebine";
            customer3.Surname = "Bedelova";
            customer3.TotalPrice = 35.6;

            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            //Console.WriteLine("*****************Customer`s Information*****************\n");
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine($"Name and Surname: {customer.Name} {customer.Surname}");
            //    Console.WriteLine($"Market Value: {customer.TotalPrice}");
            //    Console.WriteLine("\n********************************************************\n");
            //}

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);
            Console.WriteLine();
            customerManager.DeleteCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
            customerManager.DeleteCustomer(customer3);
            Console.WriteLine();
            customerManager.ListCustomer(customer1);
            customerManager.ListCustomer(customer2);
            customerManager.ListCustomer(customer3);
        }
    }
}