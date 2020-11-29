using ApiProject.Business.Concrete;
using ApiProject.DataAccess.Abstract;
using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.DataAccess.Concrete
{
    public class ProductDal : EfCoreGenericRepository<Product, ApplicationDbContext>, IProductDal
    {
    }
}
