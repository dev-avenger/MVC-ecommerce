using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public string ProductCategoryTitle { get; set; }
        public string ProductCategoryDesc { get; set; }

        public ICollection<Product> products { get; set; }
    }
}