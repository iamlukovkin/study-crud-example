using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Exam
{
    [Column("student")] public int StudentId { get; set; }

    [Column("subject")] public int SubjectId { get; set; }

    [Column("date_of_exam")] public DateTime DateOfExam { get; set; }

    [Column("mark", TypeName = "decimal(1, 0)")]
    public decimal? Mark { get; set; }

    public Student Student { get; set; }
    public Subject Subject { get; set; }
}