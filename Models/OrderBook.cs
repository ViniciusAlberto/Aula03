using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class OrderBook  
    {
        public long Id { get; set; }
        [ForeignKey("Book")]
        public long IdBook { get; set; }

        [ForeignKey("Order")]
        public long IdOrder { get; set; }
        public Book Book {get;set;}
          public Order Order{get;set;}
       
           }
}