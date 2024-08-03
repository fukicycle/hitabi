using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class CopyInfo
{
    public Guid Guid { get; set; }

    public Guid TripScheduleGuid { get; set; }

    public Guid MemberGuid { get; set; }

    public DateTime DateTime { get; set; }

    public virtual Member Member { get; set; } = null!;

    public virtual TripSchedule TripSchedule { get; set; } = null!;
}
