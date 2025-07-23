using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models;

public partial class Course
{
    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseCode { get; set; }

    public string? Description { get; set; }

    public byte? Credits { get; set; }

    public int TeacherId { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual Teacher Teacher { get; set; } = null!;
}
