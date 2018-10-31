using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Blog.Models
{
    public class Post
    {
        public int PostID { get; set; }
        [Required]
        [StringLength(50,ErrorMessage = "Tytuł jest zbyt długi")]
        public string Title { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Dodaj krótki tekst ")]
        public string ShortDescription { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "Dodaj opis")]
        public string Body { get; set; }
        public DateTime DataUtworzenia { get; set; }
        public List<string> NazwyObrazkow { get; set; }

        public virtual ICollection<Comment> Komentarze { get; set; }
    }
}