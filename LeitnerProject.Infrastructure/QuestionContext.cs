using LeitnerProject.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
               "Server = (localdb)\\ProjectsV13; Database = LeitnerProjectDatabase;" +
               " Trusted_Connection = True; ");
        }
    }

    
}
