using FB.DAL.Entities;
using FB.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<GamesEntity>> GamesGetAll()
        {
            var games = await _context.Games.ToListAsync();
            return games;
        }

        public async Task<GamesEntity> GamesGetById(int id)
        {
            var gameFromDatabase = await _context.Games.FirstOrDefaultAsync(game => game.Id == id);
            return gameFromDatabase;
        }

        public GamesEntity GamesUpdate(int id, GamesEntity game)
        {
            var entity = _context.Games.Find(id);
            entity.Stadium = game.Stadium;
            entity.TeamAway = game.TeamAway;
            entity.TeamHome = game.TeamHome;
            _context.SaveChanges();

            return entity;         
        }
    }
}
