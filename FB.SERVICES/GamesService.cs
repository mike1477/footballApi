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

        public GamesCreateResponseDTO GamesCreate(GamesCreateRequestDTO gamesCreateRequestDTO)
        {
            var gamesEntity = new GamesEntity
            {
                TeamAway = gamesCreateRequestDTO.TeamAway,
                TeamHome = gamesCreateRequestDTO.TeamHome,
                Stadium = gamesCreateRequestDTO.Stadium
            };

            GamesEntity gamesRepositoryResponse = _gamesRepository.GamesCreate(gamesEntity);

            return new GamesCreateResponseDTO
            {
                ReturnedGame = gamesRepositoryResponse
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
                AllGamesReturned = gamesGetAllRepositoryResponse
            };
        }

        public GamesGetByIdResponseDTO GamesGetById(int id)
        {
            GamesEntity gameGetByIdRepositoryResponse = _gamesRepository.GamesGetById(id);

            return new GamesGetByIdResponseDTO
            {
                GameReturned = gameGetByIdRepositoryResponse
            };
        }

        public GamesUpdateResponseDTO GamesUpdate(int id, GamesUpdateRequestDTO gamesUpdateRequestDTO)
        {
            var gamesEntity = new GamesEntity
            {
                TeamAway = gamesUpdateRequestDTO.TeamAway,
                TeamHome = gamesUpdateRequestDTO.TeamHome,
                Stadium = gamesUpdateRequestDTO.Stadium
            };

            GamesEntity gamesUpdatedRepositoryResponse = _gamesRepository.GamesUpdate(id, gamesEntity);

            return new GamesUpdateResponseDTO
            {
                GameUpdated = gamesUpdatedRepositoryResponse
            };
        }
    }
}
