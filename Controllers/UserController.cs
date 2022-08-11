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
    public class UserController : ControllerBase
    {
        private TrendingTechnologiesContext _context;

        public UserController(TrendingTechnologiesContext contex)
        {
            _context = contex;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _context.Users;
        }

        // GET api/<UserController>/5
        [HttpGet("{email}")]
        public User Get(string email)
        {
            return _context.Users.FirstOrDefault(s => s.userEmail == email);
        }

        // POST api/<UserController>
        [HttpPost]
        public User Post([FromBody] User user)
        {
            var response= _context.Users.FirstOrDefault(s => s.userEmail == user.userEmail);
            if (response == null)
            {
                _context.Users.Add(user);

                _context.SaveChanges();
                return user;
            }
            return response;
           
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
