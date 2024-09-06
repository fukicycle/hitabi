using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripAchievementCommentRepository
    {
        IList<TripAchievementComment> GetTripAchievementComments();

        TripAchievementComment GetTripAchievementCommentByGuid(Guid guid);

        TripAchievementComment CreateTripAchievementComment();

        bool UpdateTripAchievementComment();
    }
}
