using FB.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace FB.SERVICES.DTOs
{
    public class GetAllResponseDTO
    {
        public List<GamesEntity> AllGamesReturned { get; set; }
    }
}
