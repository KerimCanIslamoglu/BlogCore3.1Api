using ApiProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using ApiProject.Entities.Entities;
using ApiProject.Business.Concrete;

namespace ApiProject.DataAccess.Concrete
{
   public class PostDal:EfCoreGenericRepository<Post, ApplicationDbContext>, IPostDal
    {
    }
}
