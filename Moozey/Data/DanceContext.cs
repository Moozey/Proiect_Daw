using Microsoft.EntityFrameworkCore;
using Moozey.Models;

namespace Moozey.Data
{
    public class DanceContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<InstructorStyle> InstructorsStyles { get; set; }
        public DbSet<Style> Styles { get; set; }

        //CONSTRUCTORUL:
        public DanceContext(DbContextOptions<DanceContext> options): base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           //One to Many
            //modelBuilder.Entity<Style>()
                //.HasMany(s => s.InstructorStyle)
                //.WithOne(st => st.Style);

            modelBuilder.Entity<Student>()
              .HasMany(s => s.InstructorsStyles)
              .WithOne(st => st.Student);

            //Many to Many
            modelBuilder.Entity<InstructorStyle>()
                 .HasKey(ins => new { ins.StyleId, ins.InstructorId });

            modelBuilder.Entity<InstructorStyle>()
                        .HasOne<Instructor>(ins => ins.Instructor)
                        .WithMany(i => i.InstructorStyle)
                        .HasForeignKey(ins => ins.InstructorId);
           
            modelBuilder.Entity<InstructorStyle>()
                        .HasOne<Style>(ins => ins.Style)
                        .WithMany(s => s.InstructorStyle)
                        .HasForeignKey(ins => ins.StyleId);

            //One to One
           
            
         

            base.OnModelCreating(modelBuilder);
        }

      
    }
}
