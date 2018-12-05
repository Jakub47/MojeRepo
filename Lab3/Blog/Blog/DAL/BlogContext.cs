using Blog.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Blog.DAL
{
    public class BlogContext : IdentityDbContext<ApplicationUser>
    {
        public BlogContext() : base("BlogContext")
        {

        }

        static BlogContext()
        {
            //Database.SetInitializer<BlogContext>(new BlogInitializer());
        }

        public static BlogContext Create()
        {
            return new BlogContext();
        }

        public DbSet<Comment> Komentarz { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Polubienie> Polubienie { get; set; }
        public DbSet<KategoriaPostu> KategoriaPostu { get; set; }
        public DbSet<UserBloga> UserBloga { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}