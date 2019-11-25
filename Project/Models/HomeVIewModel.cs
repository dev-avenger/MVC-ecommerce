using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            products = new List<Product>();
            sliders = new List<Slider>();
            categories = new List<Category>();
        }
        public List<Product> products { get; set; }
        public List<Slider> sliders { get; set; }
        public List<Category> categories { get; set; }
    }
}