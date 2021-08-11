using Store.Model;
using System.Collections.Generic;

namespace Store.Interfaces
{
    public interface IGameRepository
    {
        void Delete(long id);

        Game Insert(Game game);

        List<Game> SelectAll();

        Game Update(Game game);
    }
}
