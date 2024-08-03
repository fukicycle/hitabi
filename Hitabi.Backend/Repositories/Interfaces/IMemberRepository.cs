using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        IList<Member> GetMembers();

        Member GetMemberByGuid(Guid guid);

        Member CreateMember();

        bool UpdateMember();
    }
}
