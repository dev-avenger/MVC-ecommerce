namespace EntityLib.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSocialMediaLinkTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SocialMediaLinks",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        facebook = c.String(nullable: false, maxLength: 200, unicode: false),
                        twitter = c.String(nullable: false, maxLength: 200, unicode: false),
                        instagram = c.String(nullable: false, maxLength: 200, unicode: false),
                        googleplus = c.String(nullable: false, maxLength: 200, unicode: false),
                        youtube = c.String(nullable: false, maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SocialMediaLinks");
        }
    }
}
