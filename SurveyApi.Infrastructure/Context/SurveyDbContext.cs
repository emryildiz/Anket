using Microsoft.EntityFrameworkCore;
using SurveyApi.Domain.Entities;

namespace SurveyApi.Infrastructure.Context
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }

        public DbSet<Team> Team { get; set; }

        public DbSet<Survey> Surveys { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Choice> Choices { get; set; }
    }
}
