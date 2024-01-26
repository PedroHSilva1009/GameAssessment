using GameAssessment.Models;

namespace GameAssessment.Interfaces
{
    public interface IUserRepository{
        void register(User user);
        ICollection<User> get();
    }
}