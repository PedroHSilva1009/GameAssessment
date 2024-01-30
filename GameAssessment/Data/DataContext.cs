using GameAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAssessment.Data
{
    public class DataContext : DbContext
    {
        public DbSet<User> user { get; set; }
        public DbSet<Game> game { get; set; }
        public DbSet<GameCategory> gameCategory { get; set; }
        public DbSet<Category> category { get; set; }
        public DbSet<GameAssessmentOb> gameassessment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            =>optionsBuilder.UseMySQL("Server=localhost;Port=3306;Database=gameassessment;User Id=aluno;Password=aluno");
        
         protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<GameAssessmentOb>()
                .HasKey(e => new { e.userId, e.gameId });

            modelBuilder.Entity<GameCategory>()
                .HasKey(e => new {e.game, e.category});
            }
    }
}