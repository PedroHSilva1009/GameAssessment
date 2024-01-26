using GameAssessment.Data;
using GameAssessment.Interfaces;
using GameAssessment.Models;

namespace GameAssessment.Repositories;
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context = new DataContext();

        public ICollection<User> get()
        {
            return _context.user.ToList();
        }

        public void register(User user)
        {
            _context.user.Add(user);
            _context.SaveChanges();
        }

}