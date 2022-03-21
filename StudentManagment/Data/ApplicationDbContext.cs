using Microsoft.EntityFrameworkCore;
using StudentManagment.Models;

namespace StudentManagment.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student_Course>()
                .HasOne(s => s.Student)
                .WithMany(sc => sc.Student_Courses)
                .HasForeignKey(si => si.StudentId);

            modelBuilder.Entity<Student_Course>()
                .HasOne(s => s.Course)
                .WithMany(sc => sc.Student_Courses)
                .HasForeignKey(si => si.CourseId);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Student_Course> Student_Courses { get; set;}
    }
}
