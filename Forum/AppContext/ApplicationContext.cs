using Forum.Models;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Forum.AppContext
{
    public class ApplicationContext: DbContext
    {
        private static readonly ILoggerFactory MyLoggerFactory
            = LoggerFactory.Create(builder => { builder.AddSerilog(); });
        public ApplicationContext()
        {
            DbPath = System.IO.Path.Join(@"..\", "test.db");
        }
        public string DbPath { get; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseLoggerFactory(MyLoggerFactory).UseSqlite($"Data Source={DbPath}");
    }
}
