using System;
using System.Collections.Generic;

namespace Hitabi.Shared.Models;

public partial class MemberBudget
{
    public Guid Guid { get; set; }

    public Guid MemberGuid { get; set; }

    public int Price { get; set; }

    public virtual Member Member { get; set; } = null!;
}
