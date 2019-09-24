using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return null;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> New()
        {

           return null;
        }

         [HttpGet]
        public ActionResult<IEnumerable<Order>> Delivered()
        {

           return null;
        }

          public ActionResult<IEnumerable<Order>> Canceled()
        {

           return null;
        }

         public ActionResult<IEnumerable<Order>> Approved()
        {

           return null;
        }

        
         public ActionResult<IEnumerable<Order>> AwaitingPayment()
        {
           return null;
        }

        [HttpGet("{id}")]
        [Route("orders/{id}/book/{idBook}")]
        public ActionResult<Order> Book(int id, int idBook)
        {
            return new Order(){
                Id =1,
                IdBook=2,
                IdStatus =1,
                Price = 90.00,
                IdClient =1

            };
        }
    }
}
