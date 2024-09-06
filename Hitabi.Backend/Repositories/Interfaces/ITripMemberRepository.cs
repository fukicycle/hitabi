using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripMemberRepository
    {
        IList<TripMember> GetTripMembers();

        TripMember GetTripMemberByGuid(Guid guid);

        TripMember CreateTripMember();

        bool UpdateTripMember();
    }
}
