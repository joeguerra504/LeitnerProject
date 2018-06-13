using LeitnerProject.Core;
using Microsoft.EntityFrameworkCore;

namespace LeitnerProject.Infrastructure
{
   public class QuestionContext : DbContext
   {
      public DbSet<Question> Questions { get; set; }
      public DbSet<Answer> Answers { get; set; }
      public DbSet<Category> Categories { get; set; }
      public DbSet<Subcategory> Subcategories { get; set; }
      public DbSet<User> Users { get; set; }
      public DbSet<UserStatistics> UserStatistics { get; set; }
      public DbSet<Tests> Tests { get; set; }

      // TODO: need to add a NEW migration to seed the Db


      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         // Removed QuestionAnswer Class, as the relationship needs to be Question:Answer 1:N, not N:N
         //  modelBuilder.Entity<QuestionAnswer>()
         //              .HasKey(q => new { q.QuestionId, q.AnswerId });
         //  base.OnModelCreating(modelBuilder);

         // Need to create N:N relationships for CategoryUserstatistics, TestSubcategories, QuestionSubcategories, TestQuestions,
         // and UserTests, if these are not automatically created by new Migrations after new Dbsets have been added properly. 

      }


      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(
            "Server = (localdb)\\ProjectsV13; Database = LeitnerProjectDatabase;" +
            " Trusted_Connection = True; ");
      }
   }


}
