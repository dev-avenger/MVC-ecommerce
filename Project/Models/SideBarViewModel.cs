using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class SideBarViewModel
    {
        public SideBarViewModel()
        {
            productcategories = new List<ProductCategory>();
            categories = new List<Category>();
           
        }
        public List<ProductCategory> productcategories { get; set; }

        public List<Category> categories { get; set; }

    }
}