using GameAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAssessment.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseMySQL("Server:localhost;Port:3306;Database=GameAssessment;User=aluno;Password=aluno"));
        }
        
        public DbSet<User> users { get; set; }
        public DbSet<Game> games { get; set; }
        public DbSet<GameCategory> gameCategories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<GameAssessmentOb> gameAssessments { get; set; }

    }
}