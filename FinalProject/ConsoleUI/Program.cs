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
            //GetProduct();
            //GetCategory();
            //GetAllProductTest();


        }

        /*private static void GetAllProductTest()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            var result = productManager.GetAll();

            if(result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCategory()
        {
            CategoryManager categoryManager = new CategoryManager(new EFCategoryDal());

            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void GetProduct()
        {
            ProductManager productManager = new ProductManager(new EFProductDal());

            var result = productManager.GetProductDetails();

            if(result.Success==true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.ProductName+"----------"+item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
                
        }*/
    }
}
