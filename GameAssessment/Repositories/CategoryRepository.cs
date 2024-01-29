using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;

namespace GameAssessment.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly DataContext _context = new DataContext();

    public void add(Category category)
    {
        _context.category.Add(category);
        _context.SaveChanges();
    }

    public ICollection<Category> get()
    {
       return _context.category.ToList();
    }

    public void update(Category category)
    {
        _context.category.Update(category);
    }
    public void delete(Category category)
    {
        _context.category.Remove(category);
    }
}