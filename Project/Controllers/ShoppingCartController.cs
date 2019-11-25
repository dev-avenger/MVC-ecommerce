using EntityLib;
using EntityLib.BusinessLayer;
using Newtonsoft.Json;
using Project.Models;
using Project.Models.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Cart cart = (Cart)Session["Cart"];
            cart.Remove(id);
            Session.Add("Cart", cart);
            return RedirectToAction("Index", "ShoppingCart");
        }

        [HttpGet]
        public ActionResult Get(int id)
        {
            List<Product> products = new BusinessHandler().GetProductsUsingCat(id).ToProductViewModel();
            var item = JsonConvert.SerializeObject(products, Formatting.None, new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore });

            return Json(item, JsonRequestBehavior.AllowGet);
        }


    }
}