using Microsoft.AspNetCore.Mvc;
using Store.Interfaces;
using Store.Model;

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
        public IActionResult SelectAll()
        {
            return Ok(gameBusiness.SelectAll());
        }

        [HttpPost]
        public IActionResult Insert([FromBody] Game game)
        {
            if (game == null)
                return BadRequest();

            return Ok(gameBusiness.Insert(game));
        }

        [HttpPut]
        public IActionResult Update([FromBody] Game game)
        {
            if (game == null)
                return BadRequest();

            return Ok(gameBusiness.Update(game));
        }

        [HttpDelete]
        public IActionResult Delete(long id)
        {
            gameBusiness.Delete(id);
            return NoContent();
        }
    }
}
