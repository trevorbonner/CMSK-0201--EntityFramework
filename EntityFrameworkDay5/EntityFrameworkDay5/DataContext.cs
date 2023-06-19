using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkDay5
{
    public class DataContext : DbContext
    {
        public DbSet<Parent> Parents { get; set; }
        public DbSet<ChildLayerOne> ChildLayerOnes { get; set; }
        public DbSet<ChildLayerTwo> ChildLayerTwos { get; set; }
        public DbSet<OffShoot> OffShoots { get; set; }
        public string DbPath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day5.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
