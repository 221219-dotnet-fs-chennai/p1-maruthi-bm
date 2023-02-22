using System;
using System.Collections.Generic;

namespace entity_layer.Entities;

public partial class Education
{
    public int TrainerId { get; set; }

    public int EducationId { get; set; }

    public string? Degree { get; set; }

    public string? InstituteName { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }

    public int? Grade { get; set; }

    public decimal? Cgpa { get; set; }

    public virtual UserDetail Trainer { get; set; } = null!;
}
