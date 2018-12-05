using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class UserBloga
    {
        public int UserBlogaID { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}