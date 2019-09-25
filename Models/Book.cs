using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Book
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public DateTime DatePublish { get; set; }

        public long Count { get; set; }

          public double Price { get; set; }

     
    }
}