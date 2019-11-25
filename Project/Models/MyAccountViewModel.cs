using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class MyAccountViewModel
    {
        public MyAccountViewModel()
        {
            paymentviewmodel = new PaymentViewModel();
        }
        public Customer customer { get; set; }

        public PaymentViewModel paymentviewmodel { get; set; }
        
    }
}