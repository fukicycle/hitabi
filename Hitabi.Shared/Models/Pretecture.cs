using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class Pretecture
{
    public Guid Guid { get; set; }

    public string Name { get; set; } = null!;

    public Guid AreaGuid { get; set; }

    public string Icon { get; set; } = null!;

    public virtual Area Area { get; set; } = null!;

    public virtual ICollection<TripSchedule> TripSchedules { get; set; } = new List<TripSchedule>();
}
