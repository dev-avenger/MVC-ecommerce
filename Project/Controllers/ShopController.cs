using EntityLib.BusinessLayer;
using Project.Models;
using Project.Models.ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace Project.Controllers
{
    public class ShopController : Controller
    {
        // GET: Shop
        public ActionResult Index(int? page=1,int? pageSize=6)
        {
            var model = new ShopViewModel();
            model.products = new BusinessHandler().GetProducts().ToShopViewModel();
            model.sidebar.categories = new BusinessHandler().GetCategories().ToSideBarViewModel();
            model.sidebar.productcategories = new BusinessHandler().GetProductCategories().ToSideBarViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        public ActionResult Details(int id)
        {
            var model = new DetailsViewModel();
            model.product = new BusinessHandler().GetProduct(id).ToDetailViewModel();
            
            model.sidebar.categories = new BusinessHandler().GetCategories().ToSideBarViewModel();
            model.byproductcategories = new BusinessHandler().GetProductsUsingProdCat(id).ToDetailViewModel();
            model.sidebar.productcategories = new BusinessHandler().GetProductCategories().ToSideBarViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        [HttpGet]
        public ActionResult Add()
        {
            Cart cart = Session["Cart"] as Cart;
            if (cart == null)
            {
                cart = new Cart();
            }

            int id = Convert.ToInt32(Request.QueryString["id"]);
            string productName = Request.QueryString["ProductName"];
            float price = Convert.ToSingle(Request.QueryString["UnitPrice"]);
            int qty = Convert.ToInt32(Request.QueryString["Quantity"]);
            int sizeId = Convert.ToInt32(Request.QueryString["SizeId"]);
            string imageUrl = Request.QueryString["ImageUrl"];
            cart.Add(id, productName, price, qty, sizeId, imageUrl);
            Session.Add("Cart", cart);

            return RedirectToAction("Index","Home");
        }

        public ActionResult ByCategory(int id)
        {
            var model = new ShopViewModel();
            model.products = new BusinessHandler().GetProducts().ToShopViewModel();
            model.sidebar.categories = new BusinessHandler().GetCategories().ToSideBarViewModel();
            model.sidebar.productcategories = new BusinessHandler().GetProductCategories().ToSideBarViewModel();
            model.category = new BusinessHandler().GetCategory(id);
            model.shopviewsubmodel.ByCategories = new BusinessHandler().GetProductByCategory(id).ToShopViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

        public ActionResult ByProductCategory(int id)
        {
            var model = new ShopViewModel();
            model.products = new BusinessHandler().GetProducts().ToShopViewModel();
            model.sidebar.categories = new BusinessHandler().GetCategories().ToSideBarViewModel();
            model.sidebar.productcategories = new BusinessHandler().GetProductCategories().ToSideBarViewModel();
            model.productcategory = new BusinessHandler().GetProductCategory(id);
            model.shopviewsubmodel.ByProductCategories = new BusinessHandler().GetProductByProductCategory(id).ToShopViewModel();
            ViewBag.Categories = new BusinessHandler().GetCategories().ToCategoryViewModelList();
            ViewBag.CompanyAddress = new BusinessHandler().GetCompanyAddress().ToCompanyAdressViewModel();
            ViewBag.SocialMediaLink = new BusinessHandler().GetSocialMediaLinks().ToSocialMediaLinkViewModel();
            ViewBag.MyCart = (Cart)Session["Cart"];
            ViewBag.UserName = (string)Session["Username"];
            return View(model);
        }

    }
}