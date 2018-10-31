using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class PolubienieKomentarza : Polubienie
    {
        public int CommentId { get; set; }
    }
}