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
    public class StadiumController : ControllerBase
    {

        private readonly CricketDbContext _cricketdbcontext;

        public StadiumController(CricketDbContext cricketss)
        {
            _cricketdbcontext = cricketss;
        }


        // GET: api/Country
        [HttpGet]
        public IActionResult Get()
        {
            var getstadium = _cricketdbcontext.Stadium.ToList();
            return Ok(getstadium);
        }

        // POST: api/Stadium
        /*[HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Stadium/5
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
