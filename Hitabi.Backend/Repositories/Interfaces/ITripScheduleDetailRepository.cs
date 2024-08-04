using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripScheduleDetailRepository
    {
        IList<TripScheduleDetail> GetTripSscheduleDetails();

        TripScheduleDetail GetTripScheduleDetailByGuid(Guid guid);

        TripScheduleDetail CreateTripScheduleDetail();

        bool UpdateTripScheduleDetail();
    }
}