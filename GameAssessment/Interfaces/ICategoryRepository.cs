using GameAssessment.Models;

namespace GameAssessment.Interfaces;
public interface ICategoryRepository{
    ICollection<Category> get();
    void add(Category category);
    void update(Category category);
    void delete(Category category);
}