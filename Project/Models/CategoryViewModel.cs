using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string CategoryTitle { get; set; }
        public string CategoryDesc { get; set; }
        public string CategoryLink { get; set; }

    }
}