using System;
using System.Collections.Generic;

namespace entity_layer.Entities;

public partial class Company
{
    public int TrainerId { get; set; }

    public int CompanyId { get; set; }

    public string? TrainerCompany { get; set; }

    public string? Industry { get; set; }

    public string? StratDate { get; set; }

    public string? EndDate { get; set; }

    public virtual UserDetail Trainer { get; set; } = null!;
}
