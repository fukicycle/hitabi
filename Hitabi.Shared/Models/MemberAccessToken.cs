using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class MemberAccessToken
{
    public Guid Guid { get; set; }

    public string Token { get; set; } = null!;

    public Guid MemberGuid { get; set; }

    public DateTime Expires { get; set; }

    public virtual Member Member { get; set; } = null!;
}
