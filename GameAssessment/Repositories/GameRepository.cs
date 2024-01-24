using System.Runtime.Intrinsics.Arm;
using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;
using Microsoft.AspNetCore.Mvc;

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

        public void update(Game game)
        {
            _context.game.Update(game);
            _context.SaveChanges();
        }

        public void deleteGame(Game game)
        {
            _context.game.Remove(game);
            _context.SaveChanges();
        }
    }
}