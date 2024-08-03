using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripScheduleDetailComment
{
    public Guid Guid { get; set; }

    public Guid TripScheduleDatailGuid { get; set; }

    public Guid? MemberGuid { get; set; }

    public string Comment { get; set; } = null!;

    public string? Url { get; set; }

    public DateTime DateTime { get; set; }

    public virtual Member? Member { get; set; }

    public virtual TripScheduleDetail TripScheduleDatail { get; set; } = null!;
}
