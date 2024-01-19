using System.Runtime.Intrinsics.Arm;
using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;

namespace GameAssessment.Repositories
{   
    public class GameRepository : IGameRepository{
        private readonly DataContext _context =  new DataContext();

        public void addGame(Game game)
        {
            _context.Add(game);
            _context.SaveChanges();
        }

        public ICollection<Game> GetAllGames()
        {
            return _context.games.ToList();
        }
    }
}