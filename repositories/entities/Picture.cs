using System;
using System.Collections.Generic;

namespace repositories.entities;

public partial class Picture
{
    public int PictureId { get; set; }

    public int? ActionId { get; set; }

    public string? SourceFileUrl { get; set; }

    public string? ResultFileUrl { get; set; }

    public virtual Action? Action { get; set; }
}
