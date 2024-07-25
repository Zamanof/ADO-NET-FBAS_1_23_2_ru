using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ADO_07._Annotations;

[Index(nameof(Email), IsUnique =true, Name ="UQ_Teacher_Email")]
internal class Teacher
{
    [Key]
    [Column("Id")]
    public int TeacherId { get; set; }
    [Required]
    [MaxLength(50)]
    public string? FirstName { get; set; }
    [Required]
    //[MaxLength(50)]
    [Column(TypeName ="varchar(250)")]
    public string? LastName { get; set; }
    [Required]
    public string? Email { get; set; }
    public DateTime BirthDay { get; set; }
    public float Salary {  get; set; }

    public float Bonus {  get; set; }
}
