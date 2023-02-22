using System;
using System.Collections.Generic;

namespace entity_layer.Entities;

public partial class Skill
{
    public int TrainerId { get; set; }

    public int SkillsId { get; set; }

    public string? Skills1 { get; set; }

    public string? Skills2 { get; set; }

    public string? Certificate { get; set; }

    public virtual UserDetail Trainer { get; set; } = null!;
}
