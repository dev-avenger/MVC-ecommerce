using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EntityLib.BusinessLayer;

namespace EntityLib
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryLink { get; set; }

        public ICollection<Product> products { get; set; }

    }
}