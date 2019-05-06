using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        // GET api/Games
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Game 1", "Game 2","Game 3"};
        }

        // GET api/Games/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Game";
        }

        // POST api/Games
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/Games/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/Games/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
