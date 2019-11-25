using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EntityLib.EntityClass
{
    public class BankAccountDetail
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string AccountNumber { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }

    }
}