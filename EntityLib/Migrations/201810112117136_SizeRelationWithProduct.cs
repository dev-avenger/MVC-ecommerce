namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SizeRelationWithProduct : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SizeId", c => c.Int(nullable: false));
            AddColumn("dbo.Sizes", "product_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Sizes", "product_Id");
            AddForeignKey("dbo.Sizes", "product_Id", "dbo.Products", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sizes", "product_Id", "dbo.Products");
            DropIndex("dbo.Sizes", new[] { "product_Id" });
            DropColumn("dbo.Sizes", "product_Id");
            DropColumn("dbo.Products", "SizeId");
        }
    }
}
