using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Student
{
    [Key]
    [Column("number")]
    public int Number { get; set; }

    [Column("full_name")]
    [MaxLength(30)]
    public string? FullName { get; set; }

    [Column("group_number")]
    public int? GroupNumber { get; set; }

    [Column("birth_year", TypeName = "decimal(4, 0)")]
    public decimal? BirthYear { get; set; }

    public ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
