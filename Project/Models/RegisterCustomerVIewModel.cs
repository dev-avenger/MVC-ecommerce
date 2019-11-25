using EntityLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class RegisterCustomerViewModel
    {
        public RegisterCustomerViewModel()
        {
            sidebar = new SideBarViewModel();
        }
        public Customer customer { get; set; }
        public SideBarViewModel sidebar { get; set; }
    }
}