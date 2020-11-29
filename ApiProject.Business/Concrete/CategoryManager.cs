using ApiProject.Business.Abstract;
using ApiProject.DataAccess.Abstract;
using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }


        public void CreateNewCategory(Category category)
        {
            _categoryDal.Create(category);
        }

        public List<Category> GetAllCategories()
        {
            return _categoryDal.GetAll();
        }

        public Category GetCategoryById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public Category GetCategoryByName(string categoryName)
        {
            return _categoryDal.GetCategoryByName(categoryName);
        }
    }
}
