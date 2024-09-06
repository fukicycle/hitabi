using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IPrefectureRepository
    {
        IList<Pretecture> GetPrefectures();

        Pretecture GetPrefectureByGuid(Guid guid);

        Pretecture CreatePrefecture();

        bool UpdatePrefecture();
    }
}
