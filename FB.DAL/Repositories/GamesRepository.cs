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
        public GamesRepository()
        {

        }
        public GamesRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public ApplicationDbContext _context { get; }

        public GamesEntity GamesCreate(GamesEntity game)
        {
            _context.Games.Add(game);
            _context.SaveChanges();

            return game;
        }

        public bool GamesDelete(int id)
        {
            var gameToRemove = _context.Games.SingleOrDefault(x => x.Id == id); //returns a single item.

            if (gameToRemove != null)
            {
                _context.Games.Remove(gameToRemove);
                _context.SaveChanges();

                return true;
            }
            return false;
        }

        public List<GamesEntity> GamesGetAll()
        {
            return _context.Games.ToList();
        }

        public GamesEntity GamesGetById(int id)
        {
            return _context.Games.FirstOrDefault(game => game.Id == id);
        }

        public GamesEntity GamesUpdate(int id, GamesEntity game)
        {
            _context.Games.Update(game);
            _context.SaveChanges();
            return game;
        }
    }
}
