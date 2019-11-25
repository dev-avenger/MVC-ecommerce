using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class ContactUs
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}