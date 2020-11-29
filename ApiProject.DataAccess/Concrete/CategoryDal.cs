using ApiProject.Business.Abstract;
using ApiProject.Business.Concrete;
using ApiProject.DataAccess.Abstract;
using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ApiProject.DataAccess.Concrete
{
    public class CategoryDal : EfCoreGenericRepository<Category, ApplicationDbContext>, ICategoryDal
    {
        private ApplicationDbContext _dbContext;
        public CategoryDal(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
      
        public Category GetCategoryByName(string categoryName)
        {
            return _dbContext.Categories.Where(x => x.CategoryName == categoryName).FirstOrDefault();
        }
    }
}
