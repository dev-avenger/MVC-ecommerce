namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedCompanyAddressTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CompanyAddresses (CompanyName, ShopNumber,Area,City,Country,PhoneNumber,MobileNumber,EmailAddress) VALUES('ComputerFever','Shop#304,First Floor','Center Plaza, Gulberg','Lahore','Pakistan','042-31245679','0313-1234567','computerfever@gmail.com');");

        }

        public override void Down()
        {
            Sql("DELETE FROM CompanyAddresses");

        }
    }
}
