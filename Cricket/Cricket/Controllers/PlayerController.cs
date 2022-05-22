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
    public class PlayerController : ControllerBase
    {

        private readonly CricketDbContext _cricketdbcontext;

        public PlayerController(CricketDbContext cricketss)
        {
            _cricketdbcontext = cricketss;
        }


        // GET: api/Country
        [HttpGet]
        public IActionResult Get()
        {
            var getplayer = _cricketdbcontext.Player.ToList();
            return Ok(getplayer);
        }

        // GET: api/Player/5
       // [HttpGet("{id}", Name = "Get")]
      //  public string Get(int id)
       // {
        //    return "value";
        //}

        // POST: api/Player
       /* [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
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
