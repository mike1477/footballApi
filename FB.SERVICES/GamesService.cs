using FB.DAL.Entities;
using FB.DAL.Repositories.Interfaces;
using FB.SERVICES.DTOs;
using FB.SERVICES.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FB.SERVICES
{
    public class GamesService : IGamesService
    {
        public GamesService(){}

        public GamesService(IGamesRepository gamesRepository)
        {
            _gamesRepository = gamesRepository;
        }

        public IGamesRepository _gamesRepository { get; }

        public GamesCreateResponseDTO GamesCreate(GamesCreateRequestDTO GamesCreateRequestDTO)
        {
            var gamesEntity = new GamesEntity
            {
                Stadium = "stadium",
                Team1  = "team1",
                Team2 = "team2"
            };

            GamesEntity gamesRepositoryResponse = _gamesRepository.GamesCreate(gamesEntity);

            return new GamesCreateResponseDTO
            {
                Test = gamesRepositoryResponse.Stadium
            };
        }

        public bool GamesDelete(int id)
        {
            return _gamesRepository.GamesDelete(id);
        }

        public GetAllResponseDTO GamesGetAll()
        {
            List<GamesEntity> gamesGetAllRepositoryResponse = _gamesRepository.GamesGetAll();

            return new GetAllResponseDTO
            {
                Test = "working"
            };
        }

        public GamesGetByIdResponseDTO GamesGetById(int id)
        {
            GamesEntity gameGetByIdRepositoryResponse = _gamesRepository.GamesGetById(id);

            return new GamesGetByIdResponseDTO
            {
                Test = gameGetByIdRepositoryResponse.Stadium
            };
        }

        public GamesUpdateResponseDTO GamesUpdate(GamesUpdateRequestDTO gamesUpdateRequestDTO)
        {
            //for testing
            var gamesEntity = new GamesEntity();

            GamesEntity gamesUpdatedRepositoryResponse = _gamesRepository.GamesUpdate(gamesEntity);

            return new GamesUpdateResponseDTO
            {
                Test = gamesUpdateRequestDTO.Test
            };
        }
    }
}
