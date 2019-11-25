namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PaymentMethodTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BankAccountDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BankName = c.String(nullable: false, maxLength: 50, unicode: false),
                        AccountNumber = c.String(nullable: false, maxLength: 100, unicode: false),
                        BranchCode = c.String(nullable: false, maxLength: 50, unicode: false),
                        BranchName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EasyPaisaDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 50, unicode: false),
                        NICNumber = c.String(nullable: false, maxLength: 50, unicode: false),
                        MobileNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        AccountName = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WesternUnionDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false, maxLength: 50, unicode: false),
                        NICNumber = c.String(nullable: false, maxLength: 50, unicode: false),
                        MobileNumber = c.String(nullable: false, maxLength: 20, unicode: false),
                        AccountName = c.String(nullable: false, maxLength: 100, unicode: false),
                        Country = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WesternUnionDetails");
            DropTable("dbo.EasyPaisaDetails");
            DropTable("dbo.BankAccountDetails");
        }
    }
}
