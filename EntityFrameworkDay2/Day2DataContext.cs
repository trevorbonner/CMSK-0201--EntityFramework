using Domain;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDay2
{
    public class Day2DataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
        public string DbPath { get; set; }

        public Day2DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day2.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
