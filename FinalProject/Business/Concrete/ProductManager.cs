using Business.Abstract;
using Business.CCS;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        ICategoryService _categoryService;

        public ProductManager(IProductDal inMemoryProductDal, ICategoryService categoryService)
        {
            _productDal=inMemoryProductDal;
            _categoryService=categoryService;   
        }

        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            var result = BusinessRules.Run(ChechIfProductCountOfCategoryCorrect(product.CategoryID),
                CheckIfProductNamesAreSameOrNot(product.ProductName),
                CheckCategoryCount());
            if(result != null)
            {
                return result;
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

            return new ErrorResult();
        }

        public IDataResult<List<Product>> GetAll()
        {
            if(DateTime.Now.Hour==5)
            {
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),Messages.ProductListed);
        }

        public  IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryID==id));
        }

        public IDataResult<Product> GetByID(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductID==id));
        }

        public IDataResult<List<Product>> GetByProductPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice>=min && p.UnitPrice<=max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }

        private IResult ChechIfProductCountOfCategoryCorrect(int categoryId)
        {
            int result = _productDal.GetAll(p => p.CategoryID == categoryId).Count;
            if (result>=10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }

        private IResult CheckIfProductNamesAreSameOrNot(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Count;
            if (result>0)
            {
                return new ErrorResult(Messages.ProductNamesAreSameOrNot);
            }
            return new SuccessResult();
        }

        private IResult CheckCategoryCount()
        {

            var result = _categoryService.GetAll();
            if(result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryLimitBounds);
            }
            return new SuccessResult();
        }
    }
}
