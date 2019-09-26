using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Commentary
    {    
        public long IdBook { get; set; }
        public string Description { get; set; }

        public long IdUser { get; set; }
        public DateTime DateCommentary { get; set; }


    }
}