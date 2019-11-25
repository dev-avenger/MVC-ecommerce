using EntityLib;
using EntityLib.EntityClass;
using System;
using System.Collections.Generic;
using Project.Models;
using System.Linq;
using System.Web;
using EntityLib.BusinessLayer;

namespace Project.Models
{
    public static class ModelHelper
    {
        public static List<Product> ToProductViewModel(this List<Product> products)
        {
            var model = new ProductViewModel();

            foreach (var prod in products)
            {
                model.products.Add(prod);
            }

            return model.products;
        }
        public static List<Product> ToHomeViewModel(this List<Product> products)
        {
            var model = new HomeViewModel();

            foreach (var prod in products)
            {
                model.products.Add(prod);
            }

            return model.products;
        }

        public static List<Slider> ToHomeViewModel(this List<Slider> sliders)
        {
            var model = new HomeViewModel();

            foreach (var slid in sliders)
            {
                model.sliders.Add(slid);
            }

            return model.sliders;
        }

        public static List<Category> ToHomeViewModel(this List<Category> categories)
        {
            var model = new HomeViewModel();

            foreach (var cat in categories)
            {
                model.categories.Add(cat);
            }
            return model.categories;
        }

        public static List<Category> ToSideBarViewModel(this List<Category> categories)
        {
            var sidebar = new SideBarViewModel();

            foreach (var cat in categories)
            {
                sidebar.categories.Add(cat);
            }
            return sidebar.categories;
        }

        public static List<ProductCategory> ToSideBarViewModel(this List<ProductCategory> productcategories)
        {
            var sidebar = new SideBarViewModel();

            foreach (var prod in productcategories)
            {
                sidebar.productcategories.Add(prod);
            }
            return sidebar.productcategories;
        }

        public static Product ToDetailViewModel(this Product product)
        {
            var model = new DetailsViewModel();
            model.product.Id = product.Id;
            model.product.Date = product.Date;
            model.product.ProductTitle = product.ProductTitle;
            model.product.ProductPrice = product.ProductPrice;
            model.product.ProductDesc = product.ProductDesc;
            model.product.ProductImg1 = product.ProductImg1;
            model.product.ProductImg2 = product.ProductImg2;
            model.product.ProductImg3 = product.ProductImg3;
            foreach (var item in product.size) {
                model.product.size.Add(item);
            }
            model.product.productcategory = product.productcategory;
            model.product.category = product.category;

            return model.product;
        }

        public static List<Product> ToDetailViewModel(this List<Product> product)
        {
            var model = new DetailsViewModel();
            foreach (var prod in product)
            {
                model.byproductcategories.Add(prod);
            }

            return model.byproductcategories;
        }

        public static List<Product> ToShopViewModel(this List<Product> products)
        {
            var model = new ShopViewModel();

            foreach (var prod in products)
            {
                model.products.Add(prod);
            }

            return model.products;
        }

        public static Customer ToCustomerViewModel(this Customer customer)
        {
            var model = new MyAccountViewModel();
            model.customer = customer;
            return model.customer;
        }


        //Converting Payment Tables into View Models
        public static List<BankAccountDetail> ToBankAccountDetailViewModel(this List<BankAccountDetail> bankaccountdetails)
        {
            var model = new PaymentViewModel();
            foreach (var bankaccountdetail in bankaccountdetails)
            {
                model.bankaccountdetails.Add(bankaccountdetail);
            }
            return model.bankaccountdetails;
        }

        public static List<EasyPaisaDetail> ToEasyPaisaViewModel(this List<EasyPaisaDetail> easypaisadetails)
        {
            var model = new PaymentViewModel();

            foreach (var easypaisadetail in easypaisadetails)
            {
                model.easypaisadetails.Add(easypaisadetail);
            }

            return model.easypaisadetails;
        }

        public static List<WesternUnionDetail> ToWesternUnionDetailViewModel(this List<WesternUnionDetail> westernuniondetails)
        {
            var model = new PaymentViewModel();
            foreach (var westernuniondetail in westernuniondetails)
            {
                model.westernuniondetails.Add(westernuniondetail);
            }
            return model.westernuniondetails;
        }

        //Converting Category Entity Class to CategoryViewModel Class

        public static CategoryViewModel ToCategoryViewModel(this Category category)
        {
            var model = new CategoryViewModel();
            
                model.Id = category.Id;
                model.CategoryDesc = category.CategoryDesc;
                model.CategoryTitle = category.CategoryTitle;
                model.CategoryLink = category.CategoryLink;
                

            return model;
        }

        public static List<CategoryViewModel> ToCategoryViewModelList(this List<Category> categories)
        {
            var model = new List<CategoryViewModel>();

            foreach (var category in categories)
            {
                model.Add(category.ToCategoryViewModel());
            }
            return model;
        }

        //Company Address ViewModel

        public static CompanyAddressViewModel ToCompanyAdressViewModel(this CompanyAddress companyaddress)
        {
            var model = new CompanyAddressViewModel();
            model.Id = companyaddress.Id;
            model.CompanyName = companyaddress.CompanyName;
            model.ShopNumber = companyaddress.ShopNumber;
            model.Area = companyaddress.Area;
            model.City = companyaddress.City;
            model.Country = companyaddress.Country;
            model.PhoneNumber = companyaddress.PhoneNumber;
            model.MobileNumber = companyaddress.MobileNumber;
            model.EmailAddress = companyaddress.EmailAddress;
            return model;
        }

        //SocialMediaLink ViewModel

        public static SocialMediaLinkViewModel ToSocialMediaLinkViewModel(this SocialMediaLink socialmedialink)
        {
            var model = new SocialMediaLinkViewModel();
            model.id = socialmedialink.id;
            model.facebook = socialmedialink.facebook;
            model.twitter = socialmedialink.twitter;
            model.instagram = socialmedialink.instagram;
            model.googleplus = socialmedialink.googleplus;
            model.youtube = socialmedialink.youtube;
            return model;
        }
    }
}