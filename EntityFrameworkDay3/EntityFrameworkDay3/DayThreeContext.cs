using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDay3
{
    public class DayThreeContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseSchedule> CourseSchedules { get; set; }

        public string DbPath { get; set; }

        public DayThreeContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day3.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
