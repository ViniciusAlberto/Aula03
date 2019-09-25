using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class ShoppingCar  
    {
        public long Id { get; set; } 
        public long IdBook { get; set; }
        public int Count { get; set; }
        public double Price { get; set; }   
        public long idClient {get;set;}
       
    }
}