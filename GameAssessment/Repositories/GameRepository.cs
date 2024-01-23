using System.Runtime.Intrinsics.Arm;
using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;

namespace GameAssessment.Repositories
{
    public class GameRepository : IGameRepository
    {
        private readonly DataContext _context = new DataContext();

        public void add(Game game)
        {
            _context.game.Add(game);
            _context.SaveChanges();
        }

        public ICollection<Game> get()
        {
            return _context.game.ToList();
        }
    }
}