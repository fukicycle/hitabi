using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class MemberTransportation
{
    public Guid Guid { get; set; }

    public Guid MemberGuid { get; set; }

    public string Name { get; set; } = null!;

    public virtual Member Member { get; set; } = null!;
}
