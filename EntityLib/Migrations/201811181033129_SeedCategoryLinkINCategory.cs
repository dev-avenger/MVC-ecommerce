namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCategoryLinkINCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryLink", c => c.String(maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryLink", c => c.String(nullable: false, maxLength: 100, unicode: false));
        }
    }
}
