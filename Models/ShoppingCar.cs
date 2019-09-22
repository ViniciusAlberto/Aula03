using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class ShoppingCar  
    {
        public long Id { get; set; }
        [ForeignKey("Book")]
        public long IdBook { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
        [ForeignKey("User")]
    

        public Book Book {get;set;}

         public User User {get;set;}

 
       
           }
}