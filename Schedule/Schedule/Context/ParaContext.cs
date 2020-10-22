using Microsoft.EntityFrameworkCore;
using Schedule.Models;

namespace Schedule.Context
{
    public class ParaContext : DbContext
    {
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Para> Paras { get; set; }

        public ParaContext()
        {
            Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;UserId=root;Password=root;database=sch_db;");
        }
    }
}