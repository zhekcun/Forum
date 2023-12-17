using Forum.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum.AppContext
{
    public class AppContext: DbContext
    {
        public AppContext()
        {
            DbPath = System.IO.Path.Join(@"..\", "test.db");
        }
        public string DbPath { get; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
    }
}
