using Store.Context;
using Store.Interfaces;
using Store.Model;
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

        public List<Game> Findall()
        {
            return context.Game.ToList();
        }
    }
}
