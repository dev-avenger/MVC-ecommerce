namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedWesternUnionDetail : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO WesternUnionDetails (FullName, NICNumber,MobileNumber,AccountName,Country) VALUES('Faisal Nadeem','123-1234567-9','03131234567','Faisal Nadeem','Pakistan');");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM WesternUnionDetails");
        }
    }
}
