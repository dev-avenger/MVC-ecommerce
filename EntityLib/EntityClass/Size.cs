using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class Size
    {
        public int Id { get; set; }
        public string size { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
    }
}