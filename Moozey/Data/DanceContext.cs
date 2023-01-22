using Microsoft.EntityFrameworkCore;
using Moozey.Models;

namespace Moozey.Data
{
    public interface IDesignTimeDbContextFactory<out TContext> where TContext : DbContext
    {

    }
    public class DanceContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DanceContext(DbContextOptions<DanceContext> options): base(options) 
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
