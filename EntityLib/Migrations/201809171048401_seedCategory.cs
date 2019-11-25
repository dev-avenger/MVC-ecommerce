namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedCategory : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Categories (CategoryTitle, CategoryDesc) VALUES('men','Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting,');");
            Sql("INSERT INTO Categories (CategoryTitle, CategoryDesc) VALUES('women','It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.');");
            Sql("INSERT INTO Categories (CategoryTitle, CategoryDesc) VALUES('kids','Contrary to popular belief, Lorem Ipsum is not simply random text. It has roots in a piece of classical Latin literature from 45 BC.');");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Categories WHERE CategoryTitle = 'men' ;");
            Sql("DELETE FROM Categories WHERE CategoryTitle = 'women'; ");
            Sql("DELETE FROM Categories WHERE CategoryTitle = 'kids'; ");
        }
    }
}
