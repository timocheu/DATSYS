using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models;

public partial class UserLogin : User
{
    public int UserId { get; set; }

    public string? Username { get; set; }

    public string PasswordHash { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
