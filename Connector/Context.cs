using Microsoft.EntityFrameworkCore;

namespace Connector;
using Entities;

public class Context(DbContextOptions<Context> options) : DbContext(options)
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Exam> Exams { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().ToTable("student");
        modelBuilder.Entity<Subject>().ToTable("subject");
        modelBuilder.Entity<Exam>().ToTable("exam");

        modelBuilder.Entity<Exam>()
            .HasKey(e => new { e.StudentId, e.SubjectId, e.DateOfExam });

        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Student)
            .WithMany(s => s.Exams)
            .HasForeignKey(e => e.StudentId)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Exam>()
            .HasOne(e => e.Subject)
            .WithMany(s => s.Exams)
            .HasForeignKey(e => e.SubjectId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    public static Context Create(string connectionString)
    {
        var options = new DbContextOptionsBuilder<Context>()
            .UseNpgsql(connectionString)
            .Options;
        return new Context(options);
    }
}
