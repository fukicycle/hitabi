using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripAchievement
{
    public Guid Guid { get; set; }

    public Guid TripScheduleGuid { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public virtual ICollection<TripAchievementComment> TripAchievementComments { get; set; } = new List<TripAchievementComment>();

    public virtual ICollection<TripAchievementPhoto> TripAchievementPhotos { get; set; } = new List<TripAchievementPhoto>();

    public virtual TripSchedule TripSchedule { get; set; } = null!;
}
