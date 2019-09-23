using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class OrderShoppingCar  
    {
        public long Id { get; set; }
        [ForeignKey("Book")]
        public long IdBook { get; set; }

        [ForeignKey("ShoppingCar")]
        public long IdShoppingCar { get; set; }
        public Book Book {get;set;}
          public ShoppingCar ShoppingCar{get;set;}
       
    }
}