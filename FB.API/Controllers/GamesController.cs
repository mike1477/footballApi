using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FB.API.ViewModels;
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
        public IMapper _mapper;

        public IGamesService _gamesService { get; }

        public GamesController(IGamesService gamesService, IMapper mapper)
        {
            _gamesService = gamesService;
            _mapper = mapper;
        }
        // GET api/Games
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            GetAllResponseDTO GetAllResponseDTOs = await _gamesService.GamesGetAll();

            return Ok(GetAllResponseDTOs);
        }

        // GET api/Games/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            GamesGetByIdResponseDTO gamesGetByIdResponseDTO = await _gamesService.GamesGetById(id);

            return Ok(gamesGetByIdResponseDTO);
        }

        // POST api/Games
        [HttpPost]
        public IActionResult Post([FromBody]GameCreateViewModel game)
        {
            GamesCreateResponseDTO GamesCreateResponseDTO = _gamesService.GamesCreate(_mapper.Map<GameCreateViewModel, GamesCreateRequestDTO>(game));

            return StatusCode(StatusCodes.Status201Created, GamesCreateResponseDTO);
        }

        // PUT api/Games/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GameUpdateViewModel game)
        {
            GamesUpdateResponseDTO gamesUpdateResponseDTO = _gamesService.GamesUpdate(id, _mapper.Map<GameUpdateViewModel, GamesUpdateRequestDTO>(game));

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
