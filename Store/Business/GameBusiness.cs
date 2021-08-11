using Store.Interfaces;
using Store.Model;
using System.Collections.Generic;

namespace Store.Business
{
    public class GameBusiness : IGameBusiness
    {
        private readonly IGameRepository repository;

        public GameBusiness(IGameRepository _repository)
        {
            repository = _repository;
        }

        public void Delete(long id)
        {
            repository.Delete(id);
        }

        public Game Insert(Game game)
        {
            return repository.Insert(game);
        }

        public List<Game> SelectAll()
        {
            return repository.SelectAll();
        }

        public Game Update(Game game)
        {
            return repository.Update(game);
        }
    }
}
