using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Commentary
    {    
        public long IdBook { get; set; }
        public string Description { get; set; }

        public long IdUsuario { get; set; }
        public DateTime DateCommentary { get; set; }


    }
}