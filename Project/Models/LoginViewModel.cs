using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class LoginViewModel
    {
        public LoginViewModel()
        {
            sidebar = new SideBarViewModel();
        }
        public string Email { get; set; }
        public string Password { get; set; }

        public SideBarViewModel sidebar { get; set; }

    }
}