using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GetAPI : ControllerBase
    {
        TestContext _context;
        public GetAPI(TestContext myBbRef)
        {
            _context = myBbRef;
        }


        // GET: api/<GetAPI>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Employee.ToList());
        }

        // GET api/<GetAPI>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GetAPI>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GetAPI>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GetAPI>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
