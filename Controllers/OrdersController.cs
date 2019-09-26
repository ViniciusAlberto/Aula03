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
        public ActionResult<IEnumerable<Order>> Get()
        {
            return DataFake.Orders();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return DataFake.Orders().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
    
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

         [HttpGet("New")]
        public ActionResult<IEnumerable<Order>> New()
        {

            return DataFake.Orders().Where(x => x.IdStatus == (long)DataFake.OrderStatus.New).ToList();
        }

          [HttpGet("Delivered")]
        public ActionResult<IEnumerable<Order>> Delivered()
        {

            return DataFake.Orders().Where(x => x.IdStatus == (long)DataFake.OrderStatus.Delivered).ToList();
        }

        [HttpGet("Canceled")]
        public ActionResult<IEnumerable<Order>> Canceled()
        {

            return DataFake.Orders().Where(x => x.IdStatus == (long)DataFake.OrderStatus.Canceled).ToList();
        }
        [HttpGet("Approved")]
        public ActionResult<IEnumerable<Order>> Approved()
        {         
            return DataFake.Orders().Where(x => x.IdStatus == (long)DataFake.OrderStatus.Approved).ToList();
        }
        [HttpGet("AwaitingPayment")]
        public ActionResult<IEnumerable<Order>> AwaitingPayment()
        {
            return DataFake.Orders().Where(x => x.IdStatus == (long)DataFake.OrderStatus.AwaitingPayment).ToList();
        }

        [HttpGet("{id}/status")]
        public ActionResult<long> Status([FromRoute] int id)
        {
            return DataFake.Orders().Where(x => x.Id == id).FirstOrDefault().IdStatus;
        }

    }
}
