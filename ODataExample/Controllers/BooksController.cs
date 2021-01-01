using System.Linq;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataExample.Entities;
using ODataExample.EntityFramework;
using ODataExample.Utilities;

namespace ODataExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ODataController
    {
        private BookStoreContext _db;
        public BooksController(BookStoreContext context)
        {
            _db = context;
            if (context.Books.Count() == 0)
            {
                foreach (var b in DataSource.GetBooks())
                {
                    context.Books.Add(b);
                    context.Presses.Add(b.Press);
                }
                context.SaveChanges();
            }
        }

        // GET api/values
        [EnableQuery]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Books);
        }

        // GET api/values/5
        [EnableQuery]
        public IActionResult Get(int id)
        {
            return Ok(_db.Books.FirstOrDefault(c => c.Id == id));
        }

        // POST api/values
        [EnableQuery]
        public IActionResult Post([FromBody]Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
            return Created(book);
        }
    }
}