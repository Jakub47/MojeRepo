namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blefsef : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserBloga",
                c => new
                    {
                        UserBlogaID = c.Int(nullable: false, identity: true),
                        EMail = c.String(),
                        Password = c.String(),
                        RememberMe = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.UserBlogaID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserBloga");
        }
    }
}
