using Microsoft.AspNetCore.Mvc;
using ms_studentTendency.Context;
using ms_studentTendency.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ms_studentTendency.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private TrendingTechnologiesContext _context;
        public TechnologyController(TrendingTechnologiesContext contex)
        {
            _context = contex;
        }
        // GET: api/<TechnologyController>
        [HttpGet]
        public IEnumerable<Technology> Get()
        {
            return _context.Technologies.Where(s => s.active )
                                      .ToList(); 
        }

        // GET api/<TechnologyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TechnologyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<TechnologyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TechnologyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
