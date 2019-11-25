using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib
{
    public class CustomerOrder
    {
        public int Id { get; set; }
        public float DueAmount { get; set; }
        public string InvoiceNo { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }

        //public int CustomerId { get; set; }
        //public Customer customer { get; set; }

        //public ICollection<CartItem> cartitems { get; set; }
    }
}