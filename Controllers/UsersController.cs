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
    public class UsersController : ControllerBase
    {
        
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
                

            return DataFake.Users();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
              return DataFake.Users().Where(x=> x.Id == id).FirstOrDefault();            
        }

        // POST api/values
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public void Post([FromBody] User user)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] User user)
        {
            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            
        }

        [HttpGet("{id}/order")]    
        public ActionResult<IEnumerable<Order>> Order([FromQuery] int id)
        {
              return DataFake.Order().Where(x=> x.IdClient == id).ToList();            
        }

        [HttpGet("{id}/shoppingcar")]    
        public ActionResult<IEnumerable<ShoppingCar>> ShoppingCar([FromQuery] int id)
        {
              return DataFake.ShoppingCar().Where(x=> x.IdClient == id).ToList();            
        }

           [HttpGet("{id}/commentary")]    
        public ActionResult<IEnumerable<Commentary>> Commentary([FromRoute] int id)
        {
            
            return DataFake.Commentarys().Where(x=> x.idUser == id).ToList();
        }

    }
}
