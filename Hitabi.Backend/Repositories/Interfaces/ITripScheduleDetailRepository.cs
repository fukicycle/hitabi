using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripScheduleDetailRepository
    {
        IList<TripScheduleDetail> GetTripScheduleDetails();

        TripScheduleDetail GetTripScheduleDetailByGuid(Guid guid);

        TripScheduleDetail CreateTripScheduleDetail();

        bool UpdateTripScheduleDetail();
    }
}
