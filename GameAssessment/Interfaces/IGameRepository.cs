using System.Collections.Generic;
using GameAssessment.Models;

namespace GameAssessment.Interfaces
{
    public interface IGameRepository
    {
        ICollection<Game> GetAllGames();
        void addGame(Game game);
    }
}