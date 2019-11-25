using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class Payment
    {
        public int Id { get; set; }
        public string InvoiceNo { get; set; }
        public string Amount { get; set; }
        public string PaymentMode { get; set; }
        public string ReferenceNo { get; set; }
        public string Code { get; set; }
        public DateTime PaymentDate { get; set; }
        public string CustomerIp { get; set; }

        public int CustomerId { get; set; }
        public Customer customer { get; set; }
    }
}