﻿using System.ComponentModel.DataAnnotations;

namespace ADO_07._Annotations;

internal class Group
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string? GroupName { get; set; }
    [Required]
    [Range(0, 12)]
    public int GroupRating {  get; set; }
    [Required]
    [Range(1, 4)]
    public int CourseYear { get; set; }
    public List<Student> Students { get; set; } = []; 
}
