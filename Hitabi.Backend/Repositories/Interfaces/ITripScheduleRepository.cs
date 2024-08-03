using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripScheduleRepository
    {
        IList<TripSchedule> GetTripSchedules();

        TripSchedule GetTripScheduleByGuid(Guid guid);

        TripSchedule GetTripSchedule();

        bool UpdateTripSchedule();
    }
}
