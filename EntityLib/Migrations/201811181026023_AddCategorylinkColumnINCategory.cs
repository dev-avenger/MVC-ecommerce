namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCategorylinkColumnINCategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryLink", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "CategoryLink");
        }
    }
}
