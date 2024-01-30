using GameAssessment.Models;

namespace GameAssessment.Interfaces
{
    public interface IGameAssessmentRepository{
        void add(GameAssessmentOb gameAssessmentOb);
        void update(GameAssessmentOb gameAssessmentOb);
        ICollection<GameAssessmentOb>get();
        void delete(GameAssessmentOb gameAssessmentOb);
    }
}