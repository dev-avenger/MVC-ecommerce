using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class DetailsViewModel
    {
        public DetailsViewModel()
        {
            sidebar = new SideBarViewModel();
            product = new Product();
            byproductcategories = new List<Product>();
        }
        public SideBarViewModel sidebar { get; set; }
        public Product product { get; set; }
        public List<Product> byproductcategories { get; set; }

    }
}