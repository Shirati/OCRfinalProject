using System;
using System.Collections.Generic;

namespace repositories.entities;

public partial class Action
{
    public int ActionId { get; set; }

    public int? ActionTypeId { get; set; }

    public int? UserId { get; set; }

    public int? PaymentId { get; set; }

    public bool? IsSucceeded { get; set; }

    public virtual ActionType? ActionType { get; set; }

    public virtual ICollection<Picture> Pictures { get; } = new List<Picture>();

    public virtual User? User { get; set; }
}
