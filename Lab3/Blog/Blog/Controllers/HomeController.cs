using Blog.DAL;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private BlogContext db = new BlogContext();

        // GET: Home
        public ActionResult Index()
        {
            var listaPostow = db.Post.ToList();
            ViewBag.blog = listaPostow;
            return View();
        }
    }
}