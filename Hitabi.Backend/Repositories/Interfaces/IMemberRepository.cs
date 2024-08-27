﻿using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        IList<Member> GetMembers();

        Member GetMemberByGuid(Guid guid);

        Member CreateMember(Member member);

        bool UpdateMember(Guid guid, string? email, string displayName, Guid loginTypeGuid);
    }
}