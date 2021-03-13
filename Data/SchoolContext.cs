using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        // tinfo200:[2021-03-12-marioc6-dykstra1] - DbSet is to create a property to each of the entity set.
        // tinfo200:[2021-03-12-marioc6-dykstra1] - DbSet also corresponds within the table under "Names".
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        // tinfo200:[2021-03-12-marioc6-dykstra1] - Including ModelBuilder to create & config a model which helps with the MVC controller constructor.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
