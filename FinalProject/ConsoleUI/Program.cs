using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            foreach (var item in productManager.GetByProductPrice(4, 200))
            {
                Console.WriteLine(item.ProductName);
            }
        }
    }
}
