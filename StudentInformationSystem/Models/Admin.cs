using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models;

public partial class Admin
{
    public int UserId { get; set; }

    public bool? Status { get; set; }

    public virtual User User { get; set; } = null!;
}
