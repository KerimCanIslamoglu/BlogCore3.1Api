using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAllProducts();

        Product GetProductById(int id);

        void Create(Product product);
        void Update(Product product);

        void Delete(Product product);
    }
}
