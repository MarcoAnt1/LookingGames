using Microsoft.AspNetCore.Mvc;
using Store.Interfaces;

namespace Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GameController : Controller
    {
        private readonly IGameBusiness gameBusiness;

        public GameController(IGameBusiness _business)
        {
            gameBusiness = _business;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            return Ok(gameBusiness.FindAll());
        }
    }
}
