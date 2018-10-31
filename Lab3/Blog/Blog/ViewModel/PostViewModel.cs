using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.ViewModel
{
    public class PostViewModel
    {
        public Post Post { get; set; }
        public List<Comment> KomentarzePosta { get; set; }
        public Comment Komentarz { get; set; }
    }
}