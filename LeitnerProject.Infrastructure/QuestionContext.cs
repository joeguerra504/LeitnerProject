using LeitnerProject.Core;
using Microsoft.EntityFrameworkCore;

namespace LeitnerProject.Infrastructure
{
    public class QuestionContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<QuestionAnswer>()
                        .HasKey(q => new { q.QuestionId, q.AnswerId });
            base.OnModelCreating(modelBuilder);

        }

        // TODO: May need to refactor QuestionContext after redoing the Database Model

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server = (localdb)\\ProjectsV13; Database = LeitnerProjectDatabase;" +
               " Trusted_Connection = True; ");
        }
    }


}
