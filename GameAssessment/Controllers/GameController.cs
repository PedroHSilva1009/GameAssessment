using GameAssessment.Interfaces;
using GameAssessment.Models;
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
            
            return Ok(games);
        }


        [HttpPost]
        public IActionResult AddGame(Game reqBody){   
            Game game = new Game(reqBody.gameName, reqBody.releaseDate, reqBody.producer);
            _gameRepository.add(game);
            return Ok(game);
            }

        }
    
