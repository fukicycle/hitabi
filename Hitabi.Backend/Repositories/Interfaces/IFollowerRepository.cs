using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IFollowerRepository
    {
        IList<Follower> GetFollowers();

        Follower GetFollowerByGuid(Guid id);

        Follower CreateFollower(Follower follower);

        bool UpdateFollower();
    }
}
