using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using EntityLib.EntityClass;

namespace EntityLib.BusinessLayer
{
    public class BusinessHandler
    {
        //ADMIN

        public List<Admin> GetAdmins()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Admins select a).ToList();
            }
        }

        public Admin GetAdmin(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Admins
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddAdmin(Admin admin)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Admins.Add(admin);
                dbcontext.SaveChanges();
                
            }
        }

        public void UpdateAdmin(int id,Admin admin)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Admins
                            where a.Id == id
                            select a).FirstOrDefault();

                found.AdminName = admin.AdminName;
                found.AdminEmail = admin.AdminEmail;
                found.AdminPass = admin.AdminPass;
                found.AdminImage = admin.AdminImage;
                found.AdminContact = admin.AdminContact;
                found.AdminCountry = admin.AdminCountry;
                found.AdminJob = admin.AdminJob;
                found.AdminAbout = admin.AdminAbout;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteAdmin(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var admin = (from s in dbcontext.Admins where s.Id == id select s).FirstOrDefault();
                dbcontext.Admins.Remove(admin);
                dbcontext.SaveChanges();
            }
        }

        //CartItem

        public List<CartItem> GetCartItems()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.CartItems select a).ToList();
            }
        }

        public CartItem GetCartItem(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.CartItems
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddCartItem(CartItem cartitem)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.CartItems.Add(cartitem);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateAdmin(int id, CartItem cartitem)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.CartItems
                             where a.Id == id
                             select a).FirstOrDefault();

                found.IpAddress = cartitem.IpAddress;
                found.Quantity = cartitem.Quantity;
                found.Size = cartitem.Size;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteCartItem(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var cartitem = (from s in dbcontext.CartItems where s.Id == id select s).FirstOrDefault();
                dbcontext.CartItems.Remove(cartitem);
                dbcontext.SaveChanges();
            }
        }

        //Category

        public List<Category> GetCategories()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Categories
                        .Include(a => a.products)
                        select a).ToList();
            }
        }

        public Category GetCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Categories
                        .Include(a => a.products)
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddCategory(Category category)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Categories.Add(category);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateCategory(int id, Category category)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Categories
                             where a.Id == id
                             select a).FirstOrDefault();

                found.CategoryTitle = category.CategoryTitle;
                found.CategoryDesc = category.CategoryDesc;
                found.CategoryLink = category.CategoryLink;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var category = (from s in dbcontext.Categories where s.Id == id select s).FirstOrDefault();
                dbcontext.Categories.Remove(category);
                dbcontext.SaveChanges();
            }
        }

        //Customer

        public List<Customer> GetCustomers()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Customers select a).ToList();
            }
        }

        public Customer GetCustomer(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Customers
                        where a.CustomerId == id
                        select a).FirstOrDefault();
            }
        }

        public Customer GetCustomer(string email)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Customers
                        where a.CustomerEmail == email
                        select a).FirstOrDefault();
            }
        }

        public void AddCustomer(Customer customer)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Customers.Add(customer);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateCustomer(int id, Customer customer)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Customers
                             where a.CustomerId == id
                             select a).FirstOrDefault();

                found.CustomerName = customer.CustomerName;
                found.CustomerEmail = customer.CustomerEmail;
                found.CustomerPass = customer.CustomerPass;
                found.CustomerCountry = customer.CustomerCountry;
                found.CustomerCity = customer.CustomerCity;
                found.CustomerContact = customer.CustomerContact;
                found.CustomerAddress = customer.CustomerAddress;
                found.CustomerImage = customer.CustomerImage;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteCustomer(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var customer = (from s in dbcontext.Customers where s.CustomerId == id select s).FirstOrDefault();
                dbcontext.Customers.Remove(customer);
                dbcontext.SaveChanges();
            }
        }

        //CustomerOrder

        public List<CustomerOrder> GetCustomerOrders()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.CustomerOrders select a).ToList();
            }
        }

        public CustomerOrder GetCustomerOrder(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.CustomerOrders
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddCustomerOrder(CustomerOrder customerorder)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.CustomerOrders.Add(customerorder);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateCustomerOrder(int id, CustomerOrder customerorder)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.CustomerOrders
                             where a.Id == id
                             select a).FirstOrDefault();

                found.DueAmount = customerorder.DueAmount;
                found.InvoiceNo = customerorder.InvoiceNo;
                found.OrderDate = customerorder.OrderDate;
                found.OrderStatus = customerorder.OrderStatus;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteCustomerOrder(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var customerorder = (from s in dbcontext.CustomerOrders where s.Id == id select s).FirstOrDefault();
                dbcontext.CustomerOrders.Remove(customerorder);
                dbcontext.SaveChanges();
            }
        }

        //Payment

        public List<Payment> GetPayments()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Payments select a).ToList();
            }
        }

        public Payment GetPayment(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Payments
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddPayment(Payment payment)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Payments.Add(payment);
                dbcontext.SaveChanges();

            }
        }

        public void UpdatePayment(int id, Payment payment)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Payments
                             where a.Id == id
                             select a).FirstOrDefault();

                found.InvoiceNo = payment.InvoiceNo;
                found.Amount = payment.Amount;
                found.PaymentMode = payment.PaymentMode;
                found.ReferenceNo = payment.ReferenceNo;
                found.Code = payment.Code;
                found.PaymentDate = payment.PaymentDate;
                found.CustomerIp = payment.CustomerIp;
                dbcontext.SaveChanges();

            }
        }

        public void DeletePayment(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var payment = (from s in dbcontext.Payments where s.Id == id select s).FirstOrDefault();
                dbcontext.Payments.Remove(payment);
                dbcontext.SaveChanges();
            }
        }

        //Product

        public List<Product> GetProducts()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Products select a)
                        .Include(a=>a.size)
                        .ToList();
            }
        }

        public Product GetProduct(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var context = (from a in dbcontext.Products
                               where a.Id == id
                               select a)
                               .Include(a=>a.size)
                               .FirstOrDefault();

                return context;
            }
        }

        public List<Product> GetProductsUsingProdCat(int Id)
        {
            using (var dbcontext = new EntityContext())
            {
                var context = (from a in dbcontext.Products
                               .Include(a => a.productcategory)
                               where a.Id == Id
                               select a.ProductCategoryId).FirstOrDefault();
                var product = (from b in dbcontext.Products
                               .Include(b => b.productcategory)
                               where b.ProductCategoryId == context
                               select b).ToList();

                return product;
            }
        }

        public List<Product> GetProductsUsingCat(int Id)
        {
            using (var dbcontext = new EntityContext())
            {
                var context = (from a in dbcontext.Products
                               .Include(a => a.category)
                               where a.Id == Id
                               select a.CategoryId).FirstOrDefault();
                var product = (from b in dbcontext.Products
                               .Include(b => b.category)
                               where b.CategoryId == context
                               select b).ToList();

                return product;
            }
        }

        public List<Product> GetProductByCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var context = (from a in dbcontext.Products
                               .Include(a => a.category)
                               where a.CategoryId == id
                               select a).ToList();

                return context;
            }
        }


        public List<Product> GetProductByProductCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var context = (from a in dbcontext.Products
                               .Include(a => a.productcategory)
                               where a.ProductCategoryId == id
                               select a).ToList();

                return context;
            }
        }
        public void AddProduct(Product product)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Products.Add(product);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateProduct(int id, Product product)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Products
                             where a.Id == id
                             select a).FirstOrDefault();

                found.Date = product.Date;
                found.ProductTitle = product.ProductTitle;
                found.ProductImg1 = product.ProductImg1;
                found.ProductImg2 = product.ProductImg2;
                found.ProductImg3 = product.ProductImg3;
                found.ProductPrice = product.ProductPrice;
                found.ProductDesc = product.ProductDesc;
                foreach (var item in product.size)
                {
                    found.size.Add(item);
                }
                found.ProductKeywords = product.ProductKeywords;

                dbcontext.SaveChanges();

            }
        }

        public void DeleteProduct(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var product = (from s in dbcontext.Products where s.Id == id select s).FirstOrDefault();
                dbcontext.Products.Remove(product);
                dbcontext.SaveChanges();
            }
        }

        //ProductCategory

        public List<ProductCategory> GetProductCategories()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.ProductCategorys select a).ToList();
            }
        }

        public ProductCategory GetProductCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.ProductCategorys
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddProductCategory(ProductCategory productcategory)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.ProductCategorys.Add(productcategory);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateProductCategory(int id, ProductCategory productcategory)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.ProductCategorys
                             where a.Id == id
                             select a).FirstOrDefault();

                found.ProductCategoryTitle = productcategory.ProductCategoryTitle;
                found.ProductCategoryDesc = productcategory.ProductCategoryDesc;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteProductCategory(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var productcategory = (from s in dbcontext.ProductCategorys where s.Id == id select s).FirstOrDefault();
                dbcontext.ProductCategorys.Remove(productcategory);
                dbcontext.SaveChanges();
            }
        }

        //Slider

        public List<Slider> GetSliders()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Sliders select a).ToList();
            }
        }

        public Slider GetSlider(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.Sliders
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddSlider(Slider slider)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.Sliders.Add(slider);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateSlider(int id, Slider slider)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.Sliders
                             where a.Id == id
                             select a).FirstOrDefault();

                found.SlideImage = slider.SlideImage;
                found.SlideName = slider.SlideName;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteSlider(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var slider = (from s in dbcontext.Sliders where s.Id == id select s).FirstOrDefault();
                dbcontext.Sliders.Remove(slider);
                dbcontext.SaveChanges();
            }
        }

        //Contact US Page

        public List<ContactUs> GetContactUsAll()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.ContactUSTable select a).ToList();
            }
        }

        public ContactUs GetContactUs(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.ContactUSTable
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddContactUs(ContactUs contactus)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.ContactUSTable.Add(contactus);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateContactUs(int id, ContactUs contactus)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.ContactUSTable
                             where a.Id == id
                             select a).FirstOrDefault();

                found.Time = contactus.Time;
                found.Name = contactus.Name;
                found.Email = contactus.Email;
                found.Subject = contactus.Subject;
                found.Message = contactus.Message;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteContactUs(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var contactus = (from s in dbcontext.ContactUSTable where s.Id == id select s).FirstOrDefault();
                dbcontext.ContactUSTable.Remove(contactus);
                dbcontext.SaveChanges();
            }
        }

        //LoginView User Email and password  Verification

        public Customer Login(string email,string password)
        {
            using (var dbcontext = new EntityContext())
            {
                var user = (from s in dbcontext.Customers
                            where s.CustomerEmail == email && s.CustomerPass == password
                            select s).FirstOrDefault();

                return user;
            }
        }

        //BankAccountDetail for Payment Options

        public List<BankAccountDetail> GetBankAccountDetailAll()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.BankAccountDetails select a).ToList();
            }
        }

        public BankAccountDetail GetGetBankAccountDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.BankAccountDetails
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddBankAccountDetail(BankAccountDetail bankaccountdetail)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.BankAccountDetails.Add(bankaccountdetail);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateBankAccountDetail(int id, BankAccountDetail bankaccountdetail)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.BankAccountDetails
                             where a.Id == id
                             select a).FirstOrDefault();

                found.BankName = bankaccountdetail.BankName;
                found.AccountNumber = bankaccountdetail.AccountNumber;
                found.BranchCode = bankaccountdetail.BranchCode;
                found.BranchName = bankaccountdetail.BranchName;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteBankAccountDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var bankaccountdetail = (from s in dbcontext.BankAccountDetails where s.Id == id select s).FirstOrDefault();
                dbcontext.BankAccountDetails.Remove(bankaccountdetail);
                dbcontext.SaveChanges();
            }
        }

        //EasyPaisaDetaill for Payment Options

        public List<EasyPaisaDetail> GetEasyPaisaDetailAll()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.EasyPaisaDetails select a).ToList();
            }
        }

        public EasyPaisaDetail GetEasyPaisaDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.EasyPaisaDetails
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddEasyPaisaDetail(EasyPaisaDetail easypaisadetail)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.EasyPaisaDetails.Add(easypaisadetail);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateEasyPaisaDetail(int id, EasyPaisaDetail easypaisadetail)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.EasyPaisaDetails
                             where a.Id == id
                             select a).FirstOrDefault();

                found.CategoryName = easypaisadetail.CategoryName;
                found.AccountName = easypaisadetail.AccountName;
                found.MobileNumber = easypaisadetail.MobileNumber;
                found.NICNumber = easypaisadetail.NICNumber;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteEasyPaisaDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var easypaisadetail = (from s in dbcontext.EasyPaisaDetails where s.Id == id select s).FirstOrDefault();
                dbcontext.EasyPaisaDetails.Remove(easypaisadetail);
                dbcontext.SaveChanges();
            }
        }

        //WesternUnionDetail for Payment Options

        public List<WesternUnionDetail> GetWesternUnionDetailAll()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.WesternUnionDetails select a).ToList();
            }
        }

        public WesternUnionDetail GetWesternUnionDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.WesternUnionDetails
                        where a.Id == id
                        select a).FirstOrDefault();
            }
        }

        public void AddWesternUnionDetail(WesternUnionDetail westernuniondetail)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.WesternUnionDetails.Add(westernuniondetail);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateWesternUnionDetail(int id, WesternUnionDetail westernuniondetail)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.WesternUnionDetails
                             where a.Id == id
                             select a).FirstOrDefault();

                found.AccountName = westernuniondetail.AccountName;
                found.FullName = westernuniondetail.FullName;
                found.MobileNumber = westernuniondetail.MobileNumber;
                found.NICNumber = westernuniondetail.NICNumber;
                found.Country = westernuniondetail.Country;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteWesternUnionDetail(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var westernuniondetail = (from s in dbcontext.WesternUnionDetails where s.Id == id select s).FirstOrDefault();
                dbcontext.WesternUnionDetails.Remove(westernuniondetail);
                dbcontext.SaveChanges();
            }
        }

        //CompanyAddress


        public CompanyAddress GetCompanyAddress()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.CompanyAddresses                   
                        select a).FirstOrDefault();
            }
        }

        public void AddCompanyAdress(CompanyAddress companyaddress)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.CompanyAddresses.Add(companyaddress);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateCompanyAddress(int id, CompanyAddress companyaddress)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.CompanyAddresses
                             where a.Id == id
                             select a).FirstOrDefault();

                found.CompanyName = companyaddress.CompanyName;
                found.ShopNumber = companyaddress.ShopNumber;
                found.Area = companyaddress.Area;
                found.City = companyaddress.City;
                found.Country = companyaddress.Country;
                found.PhoneNumber = companyaddress.PhoneNumber;
                found.MobileNumber = companyaddress.MobileNumber;
                found.EmailAddress = companyaddress.EmailAddress;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteCompanyAddress(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var companyAddress = (from s in dbcontext.CompanyAddresses where s.Id == id select s).FirstOrDefault();
                dbcontext.CompanyAddresses.Remove(companyAddress);
                dbcontext.SaveChanges();
            }
        }

        //SocialMediaLinks


        public SocialMediaLink GetSocialMediaLinks()
        {
            using (var dbcontext = new EntityContext())
            {

                return (from a in dbcontext.SocialMediaLinks
                        select a).FirstOrDefault();
            }
        }

        public void AddSocialMediaLink(SocialMediaLink socialmedialink)
        {
            using (var dbcontext = new EntityContext())
            {
                dbcontext.SocialMediaLinks.Add(socialmedialink);
                dbcontext.SaveChanges();

            }
        }

        public void UpdateSocialMediaLink(int id, SocialMediaLink socialmedialink)
        {
            using (var dbcontext = new EntityContext())
            {
                var found = (from a in dbcontext.SocialMediaLinks
                             where a.id == id
                             select a).FirstOrDefault();

                found.facebook = socialmedialink.facebook;
                found.twitter = socialmedialink.twitter;
                found.instagram = socialmedialink.instagram;
                found.googleplus = socialmedialink.googleplus;
                found.youtube = socialmedialink.youtube;
                dbcontext.SaveChanges();

            }
        }

        public void DeleteSocialMediaLink(int id)
        {
            using (var dbcontext = new EntityContext())
            {
                var socialmedialink = (from s in dbcontext.SocialMediaLinks where s.id == id select s).FirstOrDefault();
                dbcontext.SocialMediaLinks.Remove(socialmedialink);
                dbcontext.SaveChanges();
            }
        }


    }
}