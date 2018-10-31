using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Kategoria
    {
        public int KategoriaId { get; set; }
        public string NazwaKateogrii { get; set; }
        public string OpisKategorii { get; set; }
        public string NazwaPlikuIkony { get; set; }

        public List<Post> Post { get; set; }
    }
}