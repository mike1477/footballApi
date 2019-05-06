using FB.SERVICES.DTOs;
using FB.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FB.SERVICES
{
    public class GamesService : IGamesService
    {
        public GamesCreateResponseDTO GamesCreate(GamesCreateRequestDTO GamesCreateRequestDTO)
        {
            return new GamesCreateResponseDTO
            {
                Test = "Hello World from GamesCreate method in service."
            };
        }

        public bool GamesDelete(int id)
        {
            return true;
        }

        public GetAllResponseDTO GamesGetAll()
        {
            return new GetAllResponseDTO
            {
                Test = "Hello World from GamesGetAll method in service."
            };
        }

        public GamesGetByIdResponseDTO GamesGetById(int id)
        {
            return new GamesGetByIdResponseDTO
            {
                Test = "Hello World from GamesGetById method in service."
            };
        }

        public GamesUpdateResponseDTO GamesUpdate(GamesUpdateRequestDTO gamesUpdateRequestDTO)
        {
            return new GamesUpdateResponseDTO
            {
                Test = gamesUpdateRequestDTO.Test
            };
        }
    }
}
