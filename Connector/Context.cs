using Entities;
using Microsoft.EntityFrameworkCore;

namespace Connector;

public class Context : DbContext
{
    private static Context? _context;
    public DbSet<Student> Students { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Exam> Exams { get; set; }

    public static Context GetInstance()
    {
        if (_context == null)
        {
            throw new NullReferenceException("Context is null");
        }
        return _context;
    }

    private Context(DbContextOptions<Context> options) : base(options)
    {
    }
    
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
    
    public static Context CreateContext()
    {
        var options = new DbContextOptionsBuilder<Context>()
            .UseNpgsql(ConnectionFactory.GetInstance().CreateConnectionString())
            .Options;
        _context = new Context(options);
        return _context;
    }
    
}