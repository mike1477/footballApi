using FB.SERVICES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FB.SERVICES.Interfaces
{
    public interface IGamesService
    {
        GamesCreateResponseDTO GamesCreate(GamesCreateRequestDTO GamesCreateRequestDTO);

        Task<GetAllResponseDTO> GamesGetAll();

        Task<GamesGetByIdResponseDTO> GamesGetById(int id);

        GamesUpdateResponseDTO GamesUpdate(int id, GamesUpdateRequestDTO GamesUpdateRequestDTO);

        bool GamesDelete(int id);
    }
}
