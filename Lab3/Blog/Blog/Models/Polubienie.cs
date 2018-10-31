using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Polubienie
    {
        public int ID { get; set; }
        //Umieśić UserId

        public bool Like { get; set; }
        public bool Dislike { get; set; }
        public DateTime DataPolubienia { get; set; }
    }
}