using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class CartItem
    {
        public int Id { get; set; }
        public string IpAddress { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }

        //public int ProductId { get; set; }
        //public Product product { get; set; }
        //public int CustomerOrderId { get; set; }
        //public CustomerOrder customerorder { get; set; }

    }
}