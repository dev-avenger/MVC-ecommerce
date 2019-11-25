using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerEmail { get; set; }
        public string CustomerPass { get; set; }
        public string CustomerCountry { get; set; }
        public string CustomerCity { get; set; }
        public string CustomerContact { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerImage { get; set; }

        //public ICollection<CustomerOrder> customerorders { get; set; }
        public ICollection<Payment> payments { get; set; }

    }
}