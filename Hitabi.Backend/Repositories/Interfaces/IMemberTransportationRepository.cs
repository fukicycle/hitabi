using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IMemberTransportationRepository
    {
        IList<MemberTransportation> GetMemberTransportations();

        MemberTransportation GetMemberTransportationByGuid(Guid guid);

        MemberTransportation CreateTransportation();

        bool UpdateTransportation();
    }
}
