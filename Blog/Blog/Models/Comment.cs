using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public int PostID { get; set; }
        public DateTime DataWstawieniaKomentarza { get; set; }
        public string Body { get; set; }
       

        public bool Zgloszony { get; set; }
        public bool Ukryty { get; set; }

        public virtual Post Post { get; set; }
    }
}