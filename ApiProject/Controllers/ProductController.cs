using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProject.Business.Abstract;
using ApiProject.Entities.Entities;
using ApiProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiProject.Controllers
{
    [Authorize]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        [Route("api/[controller]/GetAllProducts")]
        public IEnumerable<ProductModel> GetAllProducts()
        {
            return _productService.GetAllProducts().Select(x => new ProductModel
            {
                Id = x.Id,
                Description = x.Description,
                ImageUrl = x.ImageUrl,
                Name = x.Name,
                Price = x.Price
            });
        }

        [HttpGet]
        [Route("api/[controller]/GetProductById")]
        public ProductModel GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            return new ProductModel
            {
                Id = product.Id,
                Description = product.Description,
                ImageUrl = product.ImageUrl,
                Name = product.Name,
                Price = product.Price
            };
        }

        [HttpPost]
        [Route("api/[controller]/GetProductById")]
        public void CreateProduct(ProductModel productModel)
        {
            var product = new Product
            {
                Description = productModel.Description,
                ImageUrl = productModel.ImageUrl,
                Name = productModel.Name,
                Price = productModel.Price,
            };
            _productService.Create(product);
        }
    }
}