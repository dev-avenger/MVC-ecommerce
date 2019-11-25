using EntityLib;
using EntityLib.BusinessLayer;
using Project.Models;
using Project.Models.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class MyAccountController : Controller
    {
        // GET: MyAccount
        public ActionResult Index()
        {
            string email = Session["Username"] as string;
            var model = new MyAccountViewModel();
            model.customer = new BusinessHandler().GetCustomer(email).ToCustomerViewModel();
            model.paymentviewmodel.bankaccountdetails = new BusinessHandler().GetBankAccountDetailAll().ToBankAccountDetailViewModel();
            model.paymentviewmodel.easypaisadetails = new BusinessHandler().GetEasyPaisaDetailAll().ToEasyPaisaViewModel();
            model.paymentviewmodel.westernuniondetails = new BusinessHandler().GetWesternUnionDetailAll().ToWesternUnionDetailViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        [HttpPost]
        public ActionResult UpdateCustomer(Customer customer)
        {
            new BusinessHandler().UpdateCustomer(customer.CustomerId, customer);

            return Content("Success");
        }

        public ActionResult DeleteCustomer(int id)
        {
            new BusinessHandler().DeleteCustomer(id);
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index","Home");
        }
    }
}