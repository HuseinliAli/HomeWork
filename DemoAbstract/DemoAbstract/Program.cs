using System;
using DemoAbstract.Abstract;
using DemoAbstract.Concrete;
using DemoAbstract.Adapters;

namespace DemoAbstract
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(
                new Customer 
                { 
                    DateOfBirth=new DateTime(2004, 7, 31),
                    FirstName="Ali",
                    LastName="Huseinli",
                    NationalityID="AZ111111" 
                });
            Console.ReadKey();
        }
    }
}
