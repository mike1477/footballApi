using FB.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FB.DAL.Repositories.Interfaces
{
    public interface IGamesRepository
    {
        GamesEntity GamesCreate(GamesEntity games);

        List<GamesEntity> GamesGetAll();

        GamesEntity GamesGetById(int id);

        GamesEntity GamesUpdate(int id, GamesEntity games);

        bool GamesDelete(int id);
    }
}
