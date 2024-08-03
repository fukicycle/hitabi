using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class TripSchedule
{
    public Guid Guid { get; set; }

    public Guid OwnerGuid { get; set; }

    public DateOnly CreateDate { get; set; }

    public DateOnly ScheduleStartDate { get; set; }

    public DateOnly? ScheduleEndDate { get; set; }

    public int Budget { get; set; }

    public Guid DestinationPrefectureGuid { get; set; }

    public bool IsPublic { get; set; }

    public virtual ICollection<CopyInfo> CopyInfos { get; set; } = new List<CopyInfo>();

    public virtual Pretecture DestinationPrefecture { get; set; } = null!;

    public virtual Member Owner { get; set; } = null!;

    public virtual ICollection<TripAchievement> TripAchievements { get; set; } = new List<TripAchievement>();

    public virtual ICollection<TripMember> TripMembers { get; set; } = new List<TripMember>();

    public virtual ICollection<TripScheduleDetail> TripScheduleDetails { get; set; } = new List<TripScheduleDetail>();
}
