namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoria",
                c => new
                    {
                        KategoriaId = c.Int(nullable: false, identity: true),
                        NazwaKateogrii = c.String(),
                        OpisKategorii = c.String(),
                        NazwaPlikuIkony = c.String(),
                    })
                .PrimaryKey(t => t.KategoriaId);
            
            CreateTable(
                "dbo.Post",
                c => new
                    {
                        PostID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        ShortDescription = c.String(nullable: false, maxLength: 50),
                        Body = c.String(nullable: false, maxLength: 100),
                        DataUtworzenia = c.DateTime(nullable: false),
                        Kategoria_KategoriaId = c.Int(),
                    })
                .PrimaryKey(t => t.PostID)
                .ForeignKey("dbo.Kategoria", t => t.Kategoria_KategoriaId)
                .Index(t => t.Kategoria_KategoriaId);
            
            CreateTable(
                "dbo.Comment",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        DataWstawieniaKomentarza = c.DateTime(nullable: false),
                        Body = c.String(),
                        Zgloszony = c.Boolean(nullable: false),
                        Ukryty = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.Post", t => t.PostID, cascadeDelete: true)
                .Index(t => t.PostID);
            
            CreateTable(
                "dbo.KategoriaPostu",
                c => new
                    {
                        KategoriaPostuId = c.Int(nullable: false, identity: true),
                        PostID = c.Int(nullable: false),
                        KategoriaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KategoriaPostuId);
            
            CreateTable(
                "dbo.Polubienie",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Like = c.Boolean(nullable: false),
                        Dislike = c.Boolean(nullable: false),
                        DataPolubienia = c.DateTime(nullable: false),
                        CommentId = c.Int(),
                        PostID = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Post", "Kategoria_KategoriaId", "dbo.Kategoria");
            DropForeignKey("dbo.Comment", "PostID", "dbo.Post");
            DropIndex("dbo.Comment", new[] { "PostID" });
            DropIndex("dbo.Post", new[] { "Kategoria_KategoriaId" });
            DropTable("dbo.Polubienie");
            DropTable("dbo.KategoriaPostu");
            DropTable("dbo.Comment");
            DropTable("dbo.Post");
            DropTable("dbo.Kategoria");
        }
    }
}
