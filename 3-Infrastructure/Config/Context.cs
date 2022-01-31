using System;
namespace Config{
    public class Context : DbContext{
        public Context(DbContextOptions<Context> options) : base(options){ }
        public DbSet<Pessoa> Pessoas{get; set;}
    }
}