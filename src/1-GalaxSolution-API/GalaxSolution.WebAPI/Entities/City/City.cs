using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxSolution.WebAPI.Entities.City
{
    [Route("api/[controller]")]
    [ApiController]
    public class City : ControllerBase
    {
        // GET: api/<City>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<City>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<City>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<City>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<City>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
