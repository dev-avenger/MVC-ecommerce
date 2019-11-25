namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedSizeTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',1);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',1);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',1);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',1);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',2);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',2);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',2);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',2);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',3);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',3);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',3);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',3);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',4);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',4);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',4);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',4);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',5);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',5);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',5);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',5);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',6);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',6);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',6);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',6);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',7);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',7);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',7);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',7);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',8);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',8);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',8);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',8);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',9);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',9);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',9);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',9);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',10);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',10);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',10);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',10);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',11);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',11);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',11);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',11);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',12);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',12);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',12);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',12);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Small',13);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Medium',13);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Large',13);");
            Sql("INSERT INTO Sizes (Size, ProductId) VALUES('Extra Large',13);");

        }

        public override void Down()
        {
            Sql("DELETE FROM Sizes");
        }
    }
}
