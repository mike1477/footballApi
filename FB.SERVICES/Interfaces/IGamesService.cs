using FB.SERVICES.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace FB.SERVICES.Interfaces
{
    public interface IGamesService
    {
        GamesCreateResponseDTO GamesCreate(GamesCreateRequestDTO GamesCreateRequestDTO);

        GetAllResponseDTO GamesGetAll();

        GamesGetByIdResponseDTO GamesGetById(int id);

        GamesUpdateResponseDTO GamesUpdate(int id, GamesUpdateRequestDTO GamesUpdateRequestDTO);

        bool GamesDelete(int id);
    }
}
