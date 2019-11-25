namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablesWithRelationsInitial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminName = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdminEmail = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdminPass = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdminImage = c.String(maxLength: 500, unicode: false),
                        AdminContact = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdminCountry = c.String(maxLength: 500, unicode: false),
                        AdminJob = c.String(nullable: false, maxLength: 50, unicode: false),
                        AdminAbout = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IpAddress = c.String(nullable: false, maxLength: 50, unicode: false),
                        Quantity = c.Int(nullable: false),
                        Size = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryTitle = c.String(nullable: false, maxLength: 50, unicode: false),
                        CategoryDesc = c.String(nullable: false, maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ProductTitle = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductImg1 = c.String(nullable: false, maxLength: 500, unicode: false),
                        ProductImg2 = c.String(nullable: false, maxLength: 500, unicode: false),
                        ProductImg3 = c.String(nullable: false, maxLength: 500, unicode: false),
                        ProductPrice = c.Double(nullable: false),
                        ProductDesc = c.String(nullable: false, maxLength: 1000, unicode: false),
                        ProductKeywords = c.String(nullable: false, maxLength: 500, unicode: false),
                        ProductCategoryId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.ProductCategories", t => t.ProductCategoryId, cascadeDelete: true)
                .Index(t => t.ProductCategoryId)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.ProductCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCategoryTitle = c.String(nullable: false, maxLength: 50, unicode: false),
                        ProductCategoryDesc = c.String(nullable: false, maxLength: 1000, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CustomerOrders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DueAmount = c.Double(nullable: false),
                        InvoiceNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        OrderDate = c.DateTime(nullable: false),
                        OrderStatus = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerEmail = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerPass = c.String(nullable: false, maxLength: 50, unicode: false),
                        CustomerCountry = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerCity = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerContact = c.String(nullable: false, maxLength: 100, unicode: false),
                        CustomerAddress = c.String(nullable: false, maxLength: 500, unicode: false),
                        CustomerImage = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        CustomerId = c.Int(nullable: false),
                        Id = c.Int(nullable: false),
                        InvoiceNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Amount = c.String(nullable: false, maxLength: 50, unicode: false),
                        PaymentMode = c.String(nullable: false, maxLength: 100, unicode: false),
                        ReferenceNo = c.String(nullable: false, maxLength: 50, unicode: false),
                        Code = c.String(nullable: false, maxLength: 50, unicode: false),
                        PaymentDate = c.DateTime(nullable: false),
                        CustomerIp = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => new { t.CustomerId, t.Id })
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Sliders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SlideName = c.String(nullable: false, maxLength: 100, unicode: false),
                        SlideImage = c.String(nullable: false, maxLength: 500, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Products", "ProductCategoryId", "dbo.ProductCategories");
            DropForeignKey("dbo.Products", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Payments", new[] { "CustomerId" });
            DropIndex("dbo.Products", new[] { "CategoryId" });
            DropIndex("dbo.Products", new[] { "ProductCategoryId" });
            DropTable("dbo.Sliders");
            DropTable("dbo.Payments");
            DropTable("dbo.Customers");
            DropTable("dbo.CustomerOrders");
            DropTable("dbo.ProductCategories");
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
            DropTable("dbo.CartItems");
            DropTable("dbo.Admins");
        }
    }
}
