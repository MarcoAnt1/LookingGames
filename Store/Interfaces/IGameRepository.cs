using Store.Model;
using System.Collections.Generic;

namespace Store.Interfaces
{
    public interface IGameRepository
    {
        List<Game> Findall();
    }
}
