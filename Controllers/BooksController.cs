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
    public class BooksController : Controller
    {
        // GET api/values
        [HttpGet]
     
        public ActionResult<IEnumerable<Book>> Get()
        {
            return DataFake.Books();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            return DataFake.Books().Where(x=> x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
     
        public void Post([FromBody] Book book)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("{id}/commentary")]    
        public ActionResult<IEnumerable<Commentary>> Commentary([FromRoute] int id)
        {
            
            return DataFake.Commentarys().Where(x=> x.IdBook == id).ToList();
        }

        [HttpGet("{id}/order")]    
        public ActionResult<IEnumerable<Order>> Order([FromRoute] int id)
        {            
            return DataFake.Orders().Where(x=> x.IdBook == id).ToList();
        }

        [HttpGet("Genre/{genre}")]   
        
        public ActionResult<IEnumerable<Book>> Genre([FromRoute] string genre)
        {            
            return DataFake.Books().Where(x=> x.Genre == genre).ToList();
        }
    }
}
