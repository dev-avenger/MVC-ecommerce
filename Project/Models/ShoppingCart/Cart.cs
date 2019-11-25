using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models.ShoppingCart
{
    public class Cart
    {
        private List<CartItem> items;
        public Cart()
        {
            items = new List<CartItem>();
        }
        public void Add(int Id,string ProductName,float UnitPrice, int Quantity,int SizeId, string ImageUrl)
        {
            Add(new CartItem { Id = Id, ProductName = ProductName, UnitPrice = UnitPrice, Quantity = Quantity, SizeId = SizeId, ImageUrl = ImageUrl });
        }

        private void Add(CartItem item)
        {
            if (item.Quantity < 1)
            {
                CartException ex = new CartException("Minimum allowed quantity is 1");
                ex.HelpLink = "http://www.google.com";
                throw ex;
            }
            if (item.UnitPrice < 0)
            {
                CartException ex = new CartException("item price can't be negative");
                ex.HelpLink = "http://www.google.com";
                throw ex;
            }
            CartItem found = items.Find(i => i.Id == item.Id);
            if (found == null)
            {
                items.Add(item);
            }
            else
            {
                found.Quantity += item.Quantity;
            }
        }
            public void Remove(int id)
            {
                CartItem found = items.Find(i => i.Id == id);
                if (found != null)
                {
                    items.Remove(found);
                }
            }
            public void UpdateQuantity(int id , int qty)
            {
                CartItem found = items.Find(i => i.Id == id);
                if (found != null)
                {
                    found.Quantity = qty;
                }
            }


            public IEnumerator<CartItem> GetEnumerator()
            {
                return ((IEnumerable<CartItem>)items).GetEnumerator();
            }

            public int NumberOfItems
            {
                get { return items.Count; }
            }
            public float TotalAmount
            {
                get
                    {
                        float sum = 0;
                        foreach (var item in items)
                        {
                            sum += item.Subtotal;
                        }
                        return sum;
                    }
            }
        }
    }