using GameAssessment.Interfaces;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAssessment.Controllers
{
    [ApiController]
    [Route("/games")]
    public class GameController : ControllerBase{
        private readonly IGameRepository _gameRepository;
        public GameController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;      
        }

        [HttpGet]
        [ProducesResponseType(200, Type = typeof(ICollection<GameController>))]
        public IActionResult getAllGames(){
            var games = _gameRepository.GetAllGames();

            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            
            return Ok(games);
        }

        [HttpPost]
        public IActionResult AddGame(Game gameBody){

                try
                {    
                    Game game = new Game(gameBody.gameName, gameBody.releaseDate, gameBody.producer, gameBody.gameAssessments, gameBody.gameCategories);
                    _gameRepository.addGame(game);

                    return Ok(game);
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex);
                }

            return;
        }
    }
}