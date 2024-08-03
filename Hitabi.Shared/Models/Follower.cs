using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class Follower
{
    public Guid Guid { get; set; }

    public Guid MemberGuid { get; set; }

    public Guid FollowerMemberGuid { get; set; }

    public DateTime DateTime { get; set; }

    public virtual Member FollowerMember { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
