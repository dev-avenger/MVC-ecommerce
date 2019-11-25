using EntityLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ProductViewModel
    {
        public ProductViewModel()
        {
            products = new List<Product>();
        }
        public List<Product> products { get; set; }
    }
}