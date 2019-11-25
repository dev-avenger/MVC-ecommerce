using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EntityLib.BusinessLayer;
using Project.Models;
using Project.Models.ShoppingCart;

namespace Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new HomeViewModel();
            model.products = new BusinessHandler().GetProducts().ToHomeViewModel();
            model.sliders = new BusinessHandler().GetSliders().ToHomeViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}