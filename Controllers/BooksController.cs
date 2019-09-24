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
    public class BooksController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return new Book[] {
            new Book(){
                Id=1,
                Title = "Livro 1",
                Genre = "Fiction",
                DatePublish = DateTime.Now.AddYears(-9),
                Count = 10,
                Price = 20.35
            },
            new Book(){
                Id=2,
                Title = "Livro 2",
                Genre = "Computing",
                DatePublish = DateTime.Now.AddYears(-2),
                Count = 35,
                Price = 49.99
            }};
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            if( id.Equals(1))
            {
             return new Book(){
                Id=1,
                Title = "Livro 1",
                Genre = "Fiction",
                DatePublish = DateTime.Now.AddYears(-9),
                Count = 10,
                Price = 20.35
             };
            }
            else
            if(id.Equals(2))
            {
               return  new Book(){
                Id=2,
                Title = "Livro 2",
                Genre = "Computing",
                DatePublish = DateTime.Now.AddYears(-2),
                Count = 35,
                Price = 49.99
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

        [HttpGet("{id}")]
        public ActionResult<Book> Commentary(int id)

        {
            return null;
        }
    }
}
