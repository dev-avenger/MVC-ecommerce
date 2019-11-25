namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedSlider : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Sliders (SlideName, SlideImage) VALUES('slide1','~/admin_area/slides_images/1.jpg');");
            Sql("INSERT INTO Sliders (SlideName, SlideImage) VALUES('slide2','~/admin_area/slides_images/2.jpg');");
            Sql("INSERT INTO Sliders (SlideName, SlideImage) VALUES('slide3','~/admin_area/slides_images/3.jpg');");
            Sql("INSERT INTO Sliders (SlideName, SlideImage) VALUES('slide4','~/admin_area/slides_images/4.jpg');");
            Sql("INSERT INTO Sliders (SlideName, SlideImage) VALUES('slide5','~/admin_area/slides_images/5.jpg');");

        }

        public override void Down()
        {
            Sql("DELETE FROM Sliders WHERE SlideName = 'slide1' ;");
            Sql("DELETE FROM Sliders WHERE SlideName = 'slide2'; ");
            Sql("DELETE FROM Sliders WHERE SlideName = 'slide3'; ");
            Sql("DELETE FROM Sliders WHERE SlideName = 'slide4'; ");
            Sql("DELETE FROM Sliders WHERE SlideName = 'slide5'; ");
        }
    }
}
