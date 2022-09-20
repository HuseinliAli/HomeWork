using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //loosely cupled
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService=productService;
        }

        [HttpGet]
        public List<Product>Get()
        {
            var result = _productService.GetAll();
            return result.Data;
        }
    }
}
