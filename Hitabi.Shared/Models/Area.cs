using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class Area
{
    public Guid Guid { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Pretecture> Pretectures { get; set; } = new List<Pretecture>();
}
