using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using EntityLib.EntityClass.EntityConfigurations;

namespace EntityLib.EntityClass
{
    public class EntityContext: DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategorys { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<ContactUs> ContactUSTable { get; set; }
        public DbSet<BankAccountDetail> BankAccountDetails { get; set; }
        public DbSet<EasyPaisaDetail> EasyPaisaDetails { get; set; }
        public DbSet<WesternUnionDetail> WesternUnionDetails { get; set; }
        public DbSet<CompanyAddress> CompanyAddresses { get; set; }
        public DbSet<SocialMediaLink> SocialMediaLinks { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdminConfigurations());
            modelBuilder.Configurations.Add(new CartItemConfigurations());
            modelBuilder.Configurations.Add(new CategoryConfigurations());
            modelBuilder.Configurations.Add(new CustomerConfigurations());
            modelBuilder.Configurations.Add(new CustomerOrderConfigrations());
            modelBuilder.Configurations.Add(new PaymentConfigurations());
            modelBuilder.Configurations.Add(new ProductCategoryConfigurations());
            modelBuilder.Configurations.Add(new ProductConfigurations());
            modelBuilder.Configurations.Add(new SliderConfigurations());
            modelBuilder.Configurations.Add(new ContactUsConfigurations());
            modelBuilder.Configurations.Add(new SizeConfiguration());
            modelBuilder.Configurations.Add(new BankAccountDetailConfigurations());
            modelBuilder.Configurations.Add(new EasyPaisaDetailConfigurations());
            modelBuilder.Configurations.Add(new WesternUnionDetailConfigurations());
            modelBuilder.Configurations.Add(new CompanyAddressConfigurations());
            modelBuilder.Configurations.Add(new SocialMediaLinkConfigurations());

            base.OnModelCreating(modelBuilder);
        }

    }
}