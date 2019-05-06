using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FB.SERVICES.DTOs;
using FB.SERVICES.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FB.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        public IGamesService _gamesService { get; }

        public GamesController(IGamesService gamesService)
        {
            _gamesService = gamesService;
        }
        // GET api/Games
        [HttpGet]
        public IActionResult Get()
        {
            GetAllResponseDTO GetAllResponseDTOs = _gamesService.GamesGetAll();

            return Ok(GetAllResponseDTOs);
        }

        // GET api/Games/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            GamesGetByIdResponseDTO gamesGetByIdResponseDTO = _gamesService.GamesGetById(id);

            return Ok(gamesGetByIdResponseDTO);
        }

        // POST api/Games
        [HttpPost]
        public IActionResult Post([FromBody]GamesCreateRequestDTO testService)
        {
            GamesCreateResponseDTO GamesCreateResponseDTO = _gamesService.GamesCreate(testService);

            return StatusCode(StatusCodes.Status201Created, GamesCreateResponseDTO);
        }

        // PUT api/Games/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GamesUpdateRequestDTO testService)
        {
            GamesUpdateResponseDTO gamesUpdateResponseDTO = _gamesService.GamesUpdate(id, testService);

            return StatusCode(StatusCodes.Status201Created, gamesUpdateResponseDTO);
        }

        // DELETE api/Games/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            bool IsDeleted = _gamesService.GamesDelete(id);
            if (IsDeleted)
            {
                return StatusCode(StatusCodes.Status200OK);
            }

            return StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}
