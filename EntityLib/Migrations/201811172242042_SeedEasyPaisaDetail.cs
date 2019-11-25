namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedEasyPaisaDetail : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO EasyPaisaDetails (CategoryName, NICNumber,MobileNumber,AccountName) VALUES('EasyPaisa','123-1234567-9','03131234567','Faisal Nadeem');");
        }

        public override void Down()
        {
            Sql("DELETE FROM EasyPaisaDetails");
        }
    }
}
