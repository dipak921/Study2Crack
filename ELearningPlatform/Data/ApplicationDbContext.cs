using ELearningPlatform.Models;
using Microsoft.EntityFrameworkCore;

namespace ELearningPlatform.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}
