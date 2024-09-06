using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ITripAchievementPhotoRepository
    {
        IList<TripAchievementPhoto> GetAreas();

        TripAchievementPhoto GetTripAchievementPhotoByGuid(Guid guid);

        TripAchievementPhoto CreateTripAchievementPhoto();

        bool UpdateTripAchievementPhoto();
    }
}
