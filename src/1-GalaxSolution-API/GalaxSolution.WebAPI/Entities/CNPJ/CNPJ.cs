<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using System;
=======
﻿using System;
>>>>>>> master
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalaxSolution.WebAPI.Entities.CNPJ
{
<<<<<<< HEAD
    [Route("api/[controller]")]
    [ApiController]
    public class CNPJ : ControllerBase
    {
        // GET: api/<CNPJ>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CNPJ>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CNPJ>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CNPJ>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CNPJ>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
=======
    public class CNPJ
    {
>>>>>>> master
    }
}
