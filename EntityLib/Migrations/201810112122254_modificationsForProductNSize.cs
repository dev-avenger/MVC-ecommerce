namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class modificationsForProductNSize : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Sizes", name: "product_Id", newName: "ProductId");
            RenameIndex(table: "dbo.Sizes", name: "IX_product_Id", newName: "IX_ProductId");
            DropColumn("dbo.Products", "SizeId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "SizeId", c => c.Int(nullable: false));
            RenameIndex(table: "dbo.Sizes", name: "IX_ProductId", newName: "IX_product_Id");
            RenameColumn(table: "dbo.Sizes", name: "ProductId", newName: "product_Id");
        }
    }
}
