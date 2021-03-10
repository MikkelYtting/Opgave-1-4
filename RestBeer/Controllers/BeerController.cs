using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Opgave_1_og_Unit_tests_Obligatorisk_opg_1;
using RestBeer.Mangers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestBeer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BeerController : ControllerBase
    {
        private readonly BeerManager _manager = new BeerManager();
        // GET: api/<BeerController>
        [HttpGet]
        public IEnumerable<Beer> Get()
        {
            return _manager.getAll();
        }

        // GET api/<BeerController>/5
        [HttpGet("{id}")]
        public Beer Get(int id)
        {
            return _manager.GetById(id);
        }

        // POST api/<BeerController>
        [HttpPost]
        public Beer Post([FromBody] Beer value)
        {
            return _manager.Add(value);
        }

        // PUT api/<BeerController>/5   
        [HttpPut("{id}")]
        public Beer Put(int id, [FromBody] Beer value)
        {
            return _manager.Update(id, value);
        }

        // DELETE api/<BeerController>/5
        [HttpDelete("{id}")]
        public Beer Delete(int id)
        {
            return _manager.Delete(id);
        }
    }
}
