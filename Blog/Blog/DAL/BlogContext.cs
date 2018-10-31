using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Blog.DAL
{
    public class BlogContext : DbContext
    {
        public BlogContext() : base("BlogContext")
        {
            Database.SetInitializer<BlogContext>(new BlogInitializer());
        }
        public DbSet<Comment> Komentarz { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Polubienie> Polubienie { get; set; }
        public DbSet<KategoriaPostu> KategoriaPostu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}