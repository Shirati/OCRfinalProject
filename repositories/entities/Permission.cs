using System;
using System.Collections.Generic;

namespace repositories.entities;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string? PremissionName { get; set; }

    public virtual ICollection<User> Users { get; } = new List<User>();
}
