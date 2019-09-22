using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Order  
    {
        public long Id { get; set; }
        [ForeignKey("Book")]
        public long IdBook { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
        [ForeignKey("User")]
        public long IdClient { get; set; }
        [ForeignKey("OrderStatus")]
        public long IdStatus { get; set; }

        public Book Book {get;set;}

         public User User {get;set;}

          public OrderStatus OrderStatus {get;set;}
       
           }
}