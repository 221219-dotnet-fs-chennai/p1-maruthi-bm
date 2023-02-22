using System;
using System.Collections.Generic;

namespace entity_layer.Entities;

public partial class UserDetail
{
    public int TrainerId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? Age { get; set; }

    public string? Password { get; set; }

    public string? Gender { get; set; }

    public string? Location { get; set; }

    public string? Domain { get; set; }

    public virtual ICollection<Company> Companies { get; } = new List<Company>();

    public virtual ICollection<Contact> Contacts { get; } = new List<Contact>();

    public virtual ICollection<Education> Educations { get; } = new List<Education>();

    public virtual ICollection<Skill> Skills { get; } = new List<Skill>();
}
