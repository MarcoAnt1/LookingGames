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

        public List<Game> FindAll()
        {
            return repository.Findall();
        }
    }
}
