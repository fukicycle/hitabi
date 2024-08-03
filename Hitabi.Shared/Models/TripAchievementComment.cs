using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripAchievementComment
{
    public Guid Guid { get; set; }

    public Guid TripAchievementGuid { get; set; }

    public Guid MemberGuid { get; set; }

    public string Comment { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;

    public virtual TripAchievement TripAchievement { get; set; } = null!;
}
