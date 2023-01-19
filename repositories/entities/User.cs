using System;
using System.Collections.Generic;

namespace repositories.entities;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public int? PermissionId { get; set; }

    public string? Ip { get; set; }

    public int? AccountId { get; set; }

    public int? NumFreeTries { get; set; }

    public virtual ICollection<Action> Actions { get; } = new List<Action>();

    public virtual Permission? Permission { get; set; }
}
