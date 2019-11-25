using EntityLib.BusinessLayer;
using EntityLib.EntityClass;
using Project.Models;
using Project.Models.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class ContactUsController : Controller
    {
        // GET: ContactUs
        public ActionResult Index()
        {
            var model = new ContactUSViewModel();
            model.sidebar.categories = new BusinessHandler().GetCategories().ToSideBarViewModel();
            model.sidebar.productcategories = new BusinessHandler().GetProductCategories().ToSideBarViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddContactUs(ContactUSViewModel contactusmodel)
        {

            new BusinessHandler().AddContactUs(contactusmodel.contactus);                
            return RedirectToAction("Index", "ContactUs");
        }
    }
}