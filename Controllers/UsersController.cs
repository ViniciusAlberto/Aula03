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
            return new User[] { new User(){
                Id =1,
                Name = "Vinicius Alberto"
            },
            new User(){
                Id =2,
                Name= "João Maria"
            } };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            if(id.Equals(1)){
              return  new User(){
                Id =1,
                Name = "Vinicius Alberto"
               };
            }
            else
             if(id.Equals(2))
                {
                    return new User(){
                         Id =2,
                         Name= "João Maria"
                     };  
                }            
            else
            {
                return null;
            }
            
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
    }
}
