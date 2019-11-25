namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCategoryLinkINCategoryTrue : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Categories SET CategoryLink='/Shop/ByCategory/4' where Id =4");
            Sql("UPDATE Categories SET CategoryLink='/Shop/ByCategory/5' where Id =5");
            Sql("UPDATE Categories SET CategoryLink='/Shop/ByCategory/6' where Id =6");

        }
        
        public override void Down()
        {
        }
    }
}
