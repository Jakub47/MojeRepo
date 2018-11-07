using Blog.DAL;
using Blog.Models;
using Blog.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class PostController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Post
        public ActionResult Index()
        {
            var posty = db.Post.ToList();
            var vm = new List<PostViewModel>();

            posty.ForEach(a =>
            vm.Add(new PostViewModel() { Post = a,
                KomentarzePosta = db.Komentarz.Where(c => c.PostID == a.PostID).ToList(),
                Komentarz = new Comment() }));
            
            return View(vm);
        }

        [ChildActionOnly]
        public PartialViewResult Komentarz(int id)
        {
            ViewBag.ID = id;
            Comment Komentarz = new Comment();
            return PartialView("_CommentForm", Komentarz);
        }

        [HttpPost]
        public ActionResult Index(Comment Komentarz)
        {
            Komentarz.DataWstawieniaKomentarza = DateTime.Now;
            db.Komentarz.Add(Komentarz);
            db.SaveChanges();

            var komentarzePosta = db.Komentarz.Where(a => a.PostID == Komentarz.PostID).ToList();

            return PartialView("_Comments", komentarzePosta);
        }
    }
}