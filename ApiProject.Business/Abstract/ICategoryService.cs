using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Abstract
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        void CreateNewCategory(Category category);
        Category GetCategoryById(int id);
        Category GetCategoryByName(string categoryName);

    }
}
