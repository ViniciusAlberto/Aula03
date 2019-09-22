using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Commentary
    {
        [ForeignKey("Book")]
        public long IdBook { get; set; }
        public string Description { get; set; }

        [ForeignKey("User")]
        public long IDUsuario { get; set; }
        public DateTime DateCommentary { get; set; }
        public Book Book {get;set;}

        public User User {get;set;}

    }
}