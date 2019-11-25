using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.ShoppingCart
{
    public class CartException:Exception
    {
        public CartException() { }
        public CartException(string msg) : base(msg)
        { }

    }
}