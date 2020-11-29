using System;
using System.Collections.Generic;
using System.Text;

namespace ApiProject.Entities.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }

    }
}
