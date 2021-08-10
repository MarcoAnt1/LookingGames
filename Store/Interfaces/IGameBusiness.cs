using Store.Model;
using System.Collections.Generic;

namespace Store.Interfaces
{
    public interface IGameBusiness
    {
        List<Game> FindAll();
    }
}
