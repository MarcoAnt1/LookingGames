using Store.Context;
using Store.Interfaces;
using Store.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Store.Repository
{
    public class GameRepository : IGameRepository
    {
        private readonly SqlServerContext context;

        public GameRepository(SqlServerContext _context)
        {
            context = _context;
        }

        public List<Game> SelectAll()
        {
            return context.Game.ToList();
        }

        public Game Insert(Game game)
        {
            try
            {
                context.Game.Add(game);
                context.SaveChanges();

                return game;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Game Update(Game game)
        {
            var result = context.Game.FirstOrDefault(g => g.Id == game.Id);
            if (result == null)
                return null;

            try
            {
                context.Game.Update(result).CurrentValues.SetValues(game);
                context.SaveChanges();

                return game;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Delete(long id)
        {
            var result = context.Game.FirstOrDefault(g => g.Id == id);
            if (result != null)
            {
                try
                {
                    context.Game.Remove(result);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            else
            {
                throw new Exception("Id don't exist.");
            }
        }
    }
}
