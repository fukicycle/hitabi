using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripAchievementRepository
    {
        IList<TripAchievement> GetTripAchievements();

        TripAchievement GetTripAchievementByGuid(Guid guid);

        TripAchievement CreateTripAchievement();

        bool UpdateTripAchievement();
    }
}
