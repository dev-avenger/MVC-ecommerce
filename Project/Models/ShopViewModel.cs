using EntityLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ShopViewModel
    {
        public ShopViewModel()
        {
            products = new List<Product>();
            sidebar = new SideBarViewModel();
            shopviewsubmodel = new ShopViewSubModel();
        }
        public List<Product> products { get; set; }
        public SideBarViewModel sidebar { get; set; }
        public ShopViewSubModel shopviewsubmodel { get; set; }
        public Category category { get; set; }
        public ProductCategory productcategory { get; set; }

    }
}