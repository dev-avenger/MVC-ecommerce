namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedBankAccoutDetail : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BankAccountDetails (BankName, AccountNumber,BranchCode,BranchName) VALUES('UBL','70100900192','0423','Shadara Lahore');");

        }

        public override void Down()
        {
            Sql("DELETE FROM BankAccountDetails");

        }
    }
}
