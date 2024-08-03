using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripScheduleDetail
{
    public Guid Guid { get; set; }

    public Guid TripScheduleGuid { get; set; }

    public DateTime StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? Budget { get; set; }

    public string Destination { get; set; } = null!;

    public virtual TripSchedule TripSchedule { get; set; } = null!;

    public virtual ICollection<TripScheduleDetailComment> TripScheduleDetailComments { get; set; } = new List<TripScheduleDetailComment>();
}
