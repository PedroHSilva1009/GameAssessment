using GameAssessment.Interfaces;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAssessment.Controllers;
[ApiController]
[Route("gameAssessment")]
public class GameAssessmentController : Controller{
    private readonly IGameAssessmentRepository _gameAssessment;
    public GameAssessmentController(IGameAssessmentRepository gameAssessmentRepository){
         _gameAssessment = gameAssessmentRepository;
    }

    [HttpPost]
    public IActionResult addGameAssessment(GameAssessmentOb reqBody){
        GameAssessmentOb gameAssessment = new(reqBody.userId, reqBody.gameId, reqBody.gameReview,
                                                reqBody.gameAssessment, reqBody.hoursPlayed);

        _gameAssessment.add(gameAssessment);

        return Ok(
            new ApiResponse<GameAssessmentOb>("Assessment send", gameAssessment)
        );
            
    }
}