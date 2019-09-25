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
            return DataFake.Order();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
              return DataFake.Order().Where(x=> x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] Order order)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order order)
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

           return DataFake.Order().Where(x=> x.IdStatus == (long)DataFake.OrderStatus.New).ToList();
        }

         [HttpGet]
        public ActionResult<IEnumerable<Order>> Delivered()
        {

           return DataFake.Order().Where(x=> x.IdStatus == (long)DataFake.OrderStatus.Delivered).ToList();
        }

          public ActionResult<IEnumerable<Order>> Canceled()
        {

           return DataFake.Order().Where(x=> x.IdStatus == (long)DataFake.OrderStatus.Canceled).ToList();
        }

         public ActionResult<IEnumerable<Order>> Approved()
        {

           return DataFake.Order().Where(x=> x.IdStatus == (long)DataFake.OrderStatus.New).ToList();
        }
        
         public ActionResult<IEnumerable<Order>> AwaitingPayment()
        {
           return DataFake.Order().Where(x=> x.IdStatus == (long)DataFake.OrderStatus.AwaitingPayment).ToList();
        }

        [HttpGet("{id}/status")]    
        public ActionResult<int> Status([FromRoute] int id)
        {            
            return DataFake.Order().Where(x=> x.IdBook == id).FirstOrDefault().IdStatus;
        }
     
    }
}
