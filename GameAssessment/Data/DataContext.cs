using GameAssessment.Models;
using Microsoft.EntityFrameworkCore;

namespace GameAssessment.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> users { get; set; }
        public DbSet<Game> games { get; set; }
        public DbSet<GameCategory> gameCategories { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<GameAssessmentOb> gameAssessments { get; set; }

        // Aqui você configura os relacionamentos dos models via C#, por exemplo as chaves primárias e estrangeiras
        // Sim, muito foda
        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Game>()
                .HasKey(e => e.gameId);
        }
    }
}