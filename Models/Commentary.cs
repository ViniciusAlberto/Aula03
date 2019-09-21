using System;

namespace BookStore.Models
{
    public class Commentary
    {
        public long IdBook { get; set; }
        public string Description { get; set; }
        public long IDUsuario { get; set; }
        public DateTime DateCommentary { get; set; }

    }
}