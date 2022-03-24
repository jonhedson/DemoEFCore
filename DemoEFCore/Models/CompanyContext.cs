using Microsoft.EntityFrameworkCore;

namespace DemoEFCore.Models
{
    public partial class CompanyContext : DbContext
    {
        public CompanyContext()
        {
        }

        public CompanyContext(DbContextOptions<CompanyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public DbSet<Information> Information { get; set; }
        public DbSet<Client> Clients { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<TeacherStudent> TeacherStudent { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<TeacherStudent>()
                .HasKey(t => new { t.StudentId, t.TeacherId });

            modelBuilder.Entity<TeacherStudent>()
            .HasOne(t => t.Student)
            .WithMany(t => t.TeacherStudent)
            .HasForeignKey(t => t.StudentId);

            modelBuilder.Entity<TeacherStudent>()
            .HasOne(t => t.Teacher)
            .WithMany(t => t.TeacherStudent)
            .HasForeignKey(t => t.TeacherId);






        }

    }
}
