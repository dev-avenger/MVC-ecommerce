namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SizeClassandConfiguration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        size = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sizes");
        }
    }
}
