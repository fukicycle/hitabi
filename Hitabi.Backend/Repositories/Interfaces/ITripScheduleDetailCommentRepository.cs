using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripScheduleDetailCommentRepository
    {
        IList<TripScheduleDetailComment> GetTripScheduleDetailComments();

        TripScheduleDetailComment GetTripScheduleDetailCommentByGuid(Guid guid);

        TripScheduleDetailComment CreateTripScheduleDetailComment();

        bool UpdateTripScheduleDetailComment();
    }
}
