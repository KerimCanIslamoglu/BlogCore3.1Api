using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        [Route("api/[controller]/GetAllCategories")]
        public IEnumerable<CategoryModel> GetAllCategories()
        {
            return _categoryService.GetAllCategories().Select(x => new CategoryModel
            {
                Id = x.Id,
                CategoryName = x.CategoryName
            });
        }

        [HttpPost]
        [Route("api/[controller]/CreateNewCategory")]
        public void CreateNewCategory(CategoryModel categoryModel)
        {
            var category = new Category
            {
                Id = categoryModel.Id,
                CategoryName = categoryModel.CategoryName
            };

            _categoryService.CreateNewCategory(category);
        }

        [HttpGet]
        [Route("api/[controller]/GetCategoryById")]
        public CategoryModel GetCategoryById(int id)
        {
            var category = _categoryService.GetCategoryById(id);

            return new CategoryModel
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }

        [HttpGet]
        [Route("api/[controller]/GetCategoryByName")]
        public CategoryModel GetCategoryByName(string categoryName)
        {
            var category = _categoryService.GetCategoryByName(categoryName);

            return new CategoryModel
            {
                Id = category.Id,
                CategoryName = category.CategoryName
            };
        }
    }
}