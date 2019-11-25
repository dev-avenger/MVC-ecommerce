using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class ContactUSViewModel
    {
        public ContactUSViewModel()
        {
            sidebar = new SideBarViewModel();
        }
        public ContactUs contactus { get; set; }
        public SideBarViewModel sidebar { get; set; }
    }
}