using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityLib.BusinessLayer;

namespace EntityLib
{
    public class Product
    {
        public Product()
        {
            size = new List<Size>();
        }
        public int Id { get; set; }

        public DateTime Date { get; set; }
        public string ProductTitle { get; set; }
        public string ProductImg1 { get; set; }
        public string ProductImg2 { get; set; }
        public string ProductImg3 { get; set; }
        public float ProductPrice { get; set; }
        public string ProductDesc { get; set; }
        public string ProductKeywords { get; set; }

        public IList<Size> size { get; set; }

        public int ProductCategoryId { get; set; }
        public ProductCategory productcategory { get; set; }

        public int CategoryId { get; set; }
        public Category category { get; set; }

        //public ICollection<CustomerOrder> customerorders { get; set; }
        //public ICollection<CartItem> cartitems { get; set; }


    }
}