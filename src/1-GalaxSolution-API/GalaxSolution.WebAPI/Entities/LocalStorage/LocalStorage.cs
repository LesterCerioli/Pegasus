using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GalaxSolution.WebAPI.Entities.LocalStorage
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocalStorage : ControllerBase
    {
        // GET: api/<LocalStorage>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LocalStorage>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LocalStorage>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LocalStorage>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LocalStorage>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
