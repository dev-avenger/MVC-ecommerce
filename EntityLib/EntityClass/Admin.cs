using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class Admin
    {
        public int Id { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public string AdminPass { get; set; }
        public string AdminImage { get; set; }
        public string AdminContact { get; set; }
        public string AdminCountry { get; set; }
        public string AdminJob { get; set; }
        public string AdminAbout { get; set; }
    }
}