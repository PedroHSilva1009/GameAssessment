using System.Collections.Generic;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameAssessment.Interfaces
{
    public interface IGameRepository
    {
        ICollection<Game> get();
        void add(Game game);
        void update(Game game);
        void deleteGame(Game game);
    }
}