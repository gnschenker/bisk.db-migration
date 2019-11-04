using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using bisk.model;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {
        private BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return Ok(_context.Blogs);
        }

        // POST api/values
        [HttpPost]
        public ActionResult<int> Post([FromBody] Blog blog)
        {
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return StatusCode(201, blog.BlogId);
        }
    }
}
