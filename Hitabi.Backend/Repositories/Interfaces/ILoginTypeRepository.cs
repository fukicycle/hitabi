using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface ILoginTypeRepository
    {
        IList<LoginType> GetLoginTypes();

        LoginType GetLoginTypeByGuid(Guid id);

        LoginType CreateLoginType(LoginType loginType);

        bool UpdateLoginType(LoginType loginType);
    }
}
