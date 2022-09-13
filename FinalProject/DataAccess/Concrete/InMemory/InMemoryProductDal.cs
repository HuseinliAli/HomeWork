using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product> 
            {
                new Product{ProductID=1,CategoryID=1,ProductName="Stekan",UnitPrice=15,UnitsInStock=20},
                new Product{ProductID=2,CategoryID=1,ProductName="Kamera",UnitPrice=4500,UnitsInStock=6},
                new Product{ProductID=3,CategoryID=2,ProductName="Telefon",UnitPrice=1499,UnitsInStock=99},
                new Product{ProductID=4,CategoryID=2,ProductName="Klaviatura",UnitPrice=349,UnitsInStock=3},
                new Product{ProductID=5,CategoryID=2,ProductName="Eynek",UnitPrice=120,UnitsInStock=34}
            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete  = _products.SingleOrDefault(p=>p.ProductID==product.ProductID);
            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetByCategory(int categoryid)
        {
            return _products.Where(p => categoryid==p.CategoryID).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID==product.ProductID);
            productToUpdate.ProductID = product.ProductID;
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryID = product.CategoryID;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }
    }
}
