using ApiProject.Business.Abstract;
using ApiProject.DataAccess.Abstract;
using ApiProject.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Create(Product product)
        {
            _productDal.Create(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAllProducts()
        {
            return _productDal.GetAll();
        }

        public Product GetProductById(int id)
        {
            return _productDal.GetById(id);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
