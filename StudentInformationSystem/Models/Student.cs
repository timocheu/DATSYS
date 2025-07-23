using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models;

public partial class Student : User
{
    public int UserId { get; set; }

    public string? Address { get; set; }

    public DateTime? EnrollmentDate { get; set; }

    public bool? Status { get; set; }

    public virtual ICollection<Grade> Grades { get; set; } = new List<Grade>();

    public virtual User User { get; set; } = null!;
}
