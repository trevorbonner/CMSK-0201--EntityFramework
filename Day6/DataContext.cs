﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Day6
{
    public  class DataContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public string DbPath { get; set; }

        public DataContext()
        {
            var path = AppContext.BaseDirectory;
            DbPath = Path.Join(path, "day6.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
