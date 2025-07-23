using System;
using System.Collections.Generic;

namespace StudentInformationSystem.Models;

public partial class Role
{
    public byte RoleId { get; set; }

    public string RoleName { get; set; } = null!;
}
