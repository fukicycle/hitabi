using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class LoginType
{
    public Guid Guid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
