using FB.DAL.Entities;
using FB.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FB.DAL.Repositories
{
    public class GamesRepository : IGamesRepository
    {
        public GamesEntity GamesCreate(GamesEntity games)
        {
            return games;
        }

        public bool GamesDelete(int id)
        {
            return true;
        }

        public List<GamesEntity> GamesGetAll()
        {
            // for testing repo connection with service.
            var game = new GamesEntity
            {
                Stadium = "test",
                Team1 = "test",
                Team2 = "test"
            };

            var list = new List<GamesEntity>();

            list.Add(game);

            return list;
        }

        public GamesEntity GamesGetById(int id)
        {
            // for testing repo connection with service.
            return new GamesEntity
            {
                Stadium = "test",
                Team1 = "test",
                Team2 = "test"
            };
        }

        public GamesEntity GamesUpdate(GamesEntity games)
        {
            // for testing repo connection with service.
            return new GamesEntity
            {
                Stadium = "test",
                Team1 = "test",
                Team2 = "test"
            };
        }
    }
}
