using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
    public class zzz : ControllerBase
    {
        TestContext _context;
        public zzz(TestContext Eman)
        {
            _context = Eman;
        }


        // GET: api/<zzz>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Department.Include(e=>e.Employee).ToList()) ;
           
        }

        // GET api/<zzz>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<zzz>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok(_context.Employee.ToList());
        }

        // PUT api/<zzz>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<zzz>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
