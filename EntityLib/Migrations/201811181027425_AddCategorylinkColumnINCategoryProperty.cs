namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategorylinkColumnINCategoryProperty : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Categories", "CategoryLink", c => c.String(nullable: true, maxLength: 100, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Categories", "CategoryLink", c => c.String());
        }
    }
}
