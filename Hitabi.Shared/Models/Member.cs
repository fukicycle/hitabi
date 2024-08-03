using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class Member
{
    public Guid Guid { get; set; }

    public string? Email { get; set; }

    public string DisplayName { get; set; } = null!;

    public Guid LoginTypeGuid { get; set; }

    public virtual ICollection<CopyInfo> CopyInfos { get; set; } = new List<CopyInfo>();

    public virtual ICollection<Follower> FollowerFollowerMembers { get; set; } = new List<Follower>();

    public virtual ICollection<Follower> FollowerMembers { get; set; } = new List<Follower>();

    public virtual LoginType LoginType { get; set; } = null!;

    public virtual ICollection<MemberBudget> MemberBudgets { get; set; } = new List<MemberBudget>();

    public virtual ICollection<MemberTransportation> MemberTransportations { get; set; } = new List<MemberTransportation>();

    public virtual ICollection<TripAchievementComment> TripAchievementComments { get; set; } = new List<TripAchievementComment>();

    public virtual ICollection<TripMember> TripMembers { get; set; } = new List<TripMember>();

    public virtual ICollection<TripScheduleDetailComment> TripScheduleDetailComments { get; set; } = new List<TripScheduleDetailComment>();

    public virtual ICollection<TripSchedule> TripSchedules { get; set; } = new List<TripSchedule>();
}
