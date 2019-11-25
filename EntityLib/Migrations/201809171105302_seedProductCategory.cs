namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedProductCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO ProductCategories (ProductCategoryTitle, ProductCategoryDesc) VALUES('jackets','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,');");
            Sql("INSERT INTO ProductCategories (ProductCategoryTitle, ProductCategoryDesc) VALUES('accessories','It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.');");
            Sql("INSERT INTO ProductCategories (ProductCategoryTitle, ProductCategoryDesc) VALUES('shoes','Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC.');");
            Sql("INSERT INTO ProductCategories (ProductCategoryTitle, ProductCategoryDesc) VALUES('coats','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,');");
            Sql("INSERT INTO ProductCategories (ProductCategoryTitle, ProductCategoryDesc) VALUES('t-shirts','It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.');");
        }

        public override void Down()
        {
            Sql("DELETE FROM ProductCategories WHERE ProductCategoryTitle = 'jackets' ;");
            Sql("DELETE FROM ProductCategories WHERE ProductCategoryTitle = 'accessories'; ");
            Sql("DELETE FROM ProductCategories WHERE ProductCategoryTitle = 'shoes'; ");
            Sql("DELETE FROM ProductCategories WHERE ProductCategoryTitle = 'coats'; ");
            Sql("DELETE FROM ProductCategories WHERE ProductCategoryTitle = 't-shirts'; ");
        }
    }
}
