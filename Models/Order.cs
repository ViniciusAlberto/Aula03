using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore.Models
{
    public class Order  
    {
        public long Id { get; set; }

        public long IdBook { get; set; }
        public int Count { get; set; }

        public double Price { get; set; }
       
        public long IdUser { get; set; }
 
        public long IdStatus { get; set; }
       
           }
}