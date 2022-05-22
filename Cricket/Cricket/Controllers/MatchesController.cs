using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cricket.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cricket.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        // GET: api/Matches

        private readonly CricketDbContext _cricketdbcontext;

        public MatchesController(CricketDbContext cricketss)
        {
            _cricketdbcontext = cricketss;
        }


        // GET: api/Country
        [HttpGet]
        public IActionResult Get()
        {
            var getmatches = _cricketdbcontext.Matches.ToList();
            return Ok(getmatches);
        }

        // POST: api/Matches
        //[HttpPost]
        /*public void Post([FromBody] string value)
        {
        }

        // PUT: api/Matches/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }*/
    }
}
