using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.ShoppingCart
{
    public class CartItem
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public int SizeId { get; set; }

        public float Subtotal
        {
            get { return (UnitPrice * Quantity); }
        }
    }
}