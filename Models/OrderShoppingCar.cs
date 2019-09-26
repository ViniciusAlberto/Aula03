using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class OrderShoppingCar  
    {
        public long Id { get; set; }
 
      public long IdBook { get; set; }
      
        public long IdUser { get; set; }

       
    }
}