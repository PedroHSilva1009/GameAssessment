using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;

namespace GameAssessment.Repositories;

public class GameAssessmentRepository : IGameAssessmentRepository
{
    private readonly DataContext _context = new DataContext();

    public void add(GameAssessmentOb gameAssessmentOb)
    {
        _context.gameassessment.Add(gameAssessmentOb);
        _context.SaveChanges();
    }

    public void delete(GameAssessmentOb gameAssessmentOb)
    {
        _context.gameassessment.Remove(gameAssessmentOb);
        _context.SaveChanges();
    }

    public ICollection<GameAssessmentOb> get()
    {
        return _context.gameassessment.ToList();
    }

    public void update(GameAssessmentOb gameAssessmentOb)
    {
        _context.gameassessment.Update(gameAssessmentOb);
        _context.SaveChanges();
    }
}
