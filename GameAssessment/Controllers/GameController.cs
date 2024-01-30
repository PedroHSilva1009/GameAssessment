using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;
using Google.Protobuf.WellKnownTypes;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Expressions;
using System;

namespace GameAssessment.Controllers;

    [ApiController]
    [Route("games")]    
    public class GameController : Controller{
        
        private readonly IGameRepository _gameRepository;
        public GameController(IGameRepository gameRepository){
            _gameRepository = gameRepository;
        }



        [HttpGet]
        public IActionResult getAllGames(){
            var games = _gameRepository.get();

            if(games.Count<=0){
                return NotFound("No games found");
            }
            
            return Ok(games);
        }


        [HttpPost]
        public IActionResult AddGame(Game reqBody){   
                string gameId = Guid.NewGuid().ToString();
                Game game = new Game(gameId, reqBody.gameName, reqBody.releaseDate, reqBody.producer);

                _gameRepository.add(game);

                return Ok(game);
                
            }


        [HttpPut("{gameId}")]
        public IActionResult updateGame(Game reqBody){
            string gameId = HttpContext.Request.RouteValues["gameId"].ToString();

            var gameFound = _gameRepository.get().Where(x => x.gameId == gameId).ToList();

            if(gameFound.Count() <= 0 || gameFound.Equals(null)){
                return NotFound("Game not found");
            }

            var game = gameFound[0];

            game.gameName = reqBody.gameName;
            game.releaseDate = reqBody.releaseDate;
            game.producer = reqBody.producer;

            _gameRepository.update(game);            

            return Ok(game);
        }

        [HttpDelete("{gameid}")]
        public IActionResult deleteGame(){
            string gameId = HttpContext.Request.RouteValues["gameId"].ToString();

            var gameFound = _gameRepository.get().Where(gameDb => gameDb.gameId==gameId).ToList();

            if(gameFound.Count <= 0 || gameFound.Equals(null)){
                return NotFound("Game not found");
            }

            var game = gameFound[0];

            _gameRepository.deleteGame(game);

            return Ok("Game deleted");
        }

        [HttpGet("{gameId}")]
        public IActionResult findGameById(){
            string gameId = HttpContext.Request.RouteValues["gameId"].ToString();

            var gameFound = _gameRepository.get().Where(gameDb => gameDb.gameId == gameId).ToList();

            if(gameFound.Count <= 0 || gameFound.Equals(null)){
                return NotFound("Game not found");
            }

            return Ok(gameFound);
        }


    }
    
