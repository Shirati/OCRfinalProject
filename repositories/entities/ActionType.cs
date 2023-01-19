using System;
using System.Collections.Generic;

namespace repositories.entities;

public partial class ActionType
{
    public int ActionTypeId { get; set; }

    public string? ActionTypeName { get; set; }

    public virtual ICollection<Action> Actions { get; } = new List<Action>();
}
