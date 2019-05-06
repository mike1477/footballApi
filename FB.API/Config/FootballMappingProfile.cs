using AutoMapper;
using FB.API.ViewModels;
using FB.SERVICES.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FB.API.Config
{
    public class FootballMappingProfile : Profile
    {
        public FootballMappingProfile()
        {
            CreateMap<GameCreateViewModel, GamesCreateRequestDTO>();
            CreateMap<GameUpdateViewModel, GamesUpdateRequestDTO>();
        }
    }
}
