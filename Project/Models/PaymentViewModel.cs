using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class PaymentViewModel
    {
        public PaymentViewModel()
        {
            easypaisadetails = new List<EasyPaisaDetail>();
            bankaccountdetails = new List<BankAccountDetail>();
            westernuniondetails = new List<WesternUnionDetail>();

        }
        public List<BankAccountDetail> bankaccountdetails { get; set; }
        public List<WesternUnionDetail> westernuniondetails { get; set; }
        public List<EasyPaisaDetail> easypaisadetails { get; set; }


    }
}