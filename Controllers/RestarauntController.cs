﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitiesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestarauntController : ControllerBase
    {
        // GET: api/<RestarauntController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<RestarauntController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<RestarauntController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<RestarauntController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<RestarauntController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
