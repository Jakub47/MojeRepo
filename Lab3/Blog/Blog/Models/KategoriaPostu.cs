using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class KategoriaPostu
    {
        public int KategoriaPostuId { get; set; }
        public int PostID { get; set; }
        public int KategoriaId { get; set; }
    }
}