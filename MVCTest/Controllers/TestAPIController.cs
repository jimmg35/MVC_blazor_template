using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVCTest.Models;
using MVCTest;
using System.Diagnostics;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestAPIController : ControllerBase
    {
        
        private cesiumiotContext db = new cesiumiotContext();

        // GET: api/<TestAPIController>
        [HttpGet]
        public List<PdStaticMrtStop> Get()
        {
            return db.PdStaticMrtStops.ToList();
        }



        // GET api/<TestAPIController>/5
        [HttpGet("get2")]
        public string Get(int id)
        {
            
            return "value"+id;
        }



        // POST api/<TestAPIController>
        public string Post([FromForm] string value1, [FromForm] string value2) // 
        {
            return value1 + value2; 
        }

        // PUT api/<TestAPIController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TestAPIController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
