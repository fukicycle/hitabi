using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripAchievementPhoto
{
    public Guid Guid { get; set; }

    public Guid TripAchievementGuid { get; set; }

    public string? PhotoUrl { get; set; }

    public DateTime DateTime { get; set; }

    public virtual TripAchievement TripAchievement { get; set; } = null!;
}
