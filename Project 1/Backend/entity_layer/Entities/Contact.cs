using System;
using System.Collections.Generic;

namespace entity_layer.Entities;

public partial class Contact
{
    public int TrainerId { get; set; }

    public int ContactId { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? PhoneNo { get; set; }

    public string? SocialMedia { get; set; }

    public virtual UserDetail Trainer { get; set; } = null!;
}
