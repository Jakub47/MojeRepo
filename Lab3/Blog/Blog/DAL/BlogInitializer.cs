using Blog.Migrations;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Blog.DAL
{
    public class BlogInitializer : MigrateDatabaseToLatestVersion<BlogContext, Configuration>
    {
        public static void SeedBlogData(BlogContext context)
        {
            //POSTY
            var posty = new List<Post>
            {
                new Post() {Title = "Testowy Post",Body = "To jest mój pierwszy post", DataUtworzenia = DateTime.Now,
                    ShortDescription = "Pierwszy"},
                new Post() {Title = "Post o procesorach",Body = "CPU czyli centralna jednostka ... jest najważnieszja",
                    DataUtworzenia = DateTime.Now, ShortDescription = "CPU"},
                new Post() {Title = "Testowy o kartach graficznych",Body = "GPU głównym założeniem kart ... jest najszybsze",
                    DataUtworzenia = DateTime.Now,ShortDescription = "GPU"},
            };
            posty.ForEach(a => context.Post.AddOrUpdate(a));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }

            //Komentarze
            var komentarze = new List<Comment>
            {
                new Comment() {PostID = 1, DataWstawieniaKomentarza = DateTime.Now , Body = "FAjna koncepcja"},
                new Comment() {PostID = 2, DataWstawieniaKomentarza = DateTime.Now , Body = "CPU, a nie INTEL CPU??"},
                new Comment() {PostID = 2, DataWstawieniaKomentarza = DateTime.Now , Body = "Jaki Intel tylko AMD"},
                new Comment() {PostID = 3, DataWstawieniaKomentarza = DateTime.Now , Body = "Nivida Gtx 1060 się kłania"}
            };
            komentarze.ForEach(a => context.Komentarz.AddOrUpdate(a));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            //Kategorie
            var kategorie = new List<Kategoria>
            {
                new Kategoria() {NazwaKateogrii = "Procesory", OpisKategorii = "Katgoria majaca w sobie cpu", NazwaPlikuIkony = "CPU"},
                new Kategoria() {NazwaKateogrii = "Karty Graficzne", OpisKategorii = "Katgoria majaca w sobie gpu", NazwaPlikuIkony = "GPU"},
            };
            kategorie.ForEach(a => context.Kategoria.AddOrUpdate(a));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            //KategoriaPostu
            var kategoriePostu = new List<KategoriaPostu>
            {
                new KategoriaPostu() {KategoriaId = 1,PostID = 2},
                new KategoriaPostu() {KategoriaId = 1,PostID = 3},
                new KategoriaPostu() {KategoriaId = 1,PostID = 4},
            };
            kategoriePostu.ForEach(a => context.KategoriaPostu.AddOrUpdate(a));
            try
            {
                context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                foreach (var eve in e.EntityValidationErrors)
                {
                    Debug.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Debug.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}