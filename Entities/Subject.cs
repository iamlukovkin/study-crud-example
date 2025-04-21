using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities;

public class Subject
{
    [Key]
    [Column("number")]
    public int Number { get; set; }

    [Column("full_name")]
    [MaxLength(50)]
    public string? FullName { get; set; }

    [Column("hours_volume")]
    public int? HoursVolume { get; set; }

    public ICollection<Exam> Exams { get; set; } = new List<Exam>();
}
