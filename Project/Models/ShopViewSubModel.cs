using EntityLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ShopViewSubModel
    {
        public ShopViewSubModel()
        {
            ByCategories = new List<Product>();
            ByProductCategories = new List<Product>();
        }
        public List<Product> ByCategories { get; set; }
        public List<Product> ByProductCategories { get; set; }
    }
}