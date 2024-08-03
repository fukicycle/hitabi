using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripMember
{
    public Guid Guid { get; set; }

    public Guid TripScheduleGuid { get; set; }

    public Guid? MemberGuid { get; set; }

    public virtual Member? Member { get; set; }

    public virtual TripSchedule TripSchedule { get; set; } = null!;
}
