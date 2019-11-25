namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyAddressTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CompanyAddresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 50, unicode: false),
                        ShopNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        Area = c.String(nullable: false, maxLength: 500, unicode: false),
                        City = c.String(nullable: false, maxLength: 50, unicode: false),
                        Country = c.String(nullable: false, maxLength: 50, unicode: false),
                        PhoneNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        MobileNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        EmailAddress = c.String(nullable: false, maxLength: 100, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CompanyAddresses");
        }
    }
}
