using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        //loosely cupled
        public IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService=productService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _productService.GetAll();

            if(result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetByID(int id)
        {
            var result = _productService.GetByID(id);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);

            if(result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
    }
}
