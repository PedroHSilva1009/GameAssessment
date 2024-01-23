using System.Collections.Generic;
using GameAssessment.Models;

namespace GameAssessment.Interfaces
{
    public interface IGameRepository
    {
        ICollection<Game> get();
        void add(Game game);
    }
}