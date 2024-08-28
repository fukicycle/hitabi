using Hitabi.Shared.Models;

namespace Hitabi.Backend.Repositories.Interfaces
{
    public interface IMemberBudgetRepository
    {
        IList<MemberBudget> GetMemberBudgets();

        MemberBudget GetMemberBudgetByGuid(Guid guid);

        MemberBudget CreateMemberBudget(MemberBuget memberBuget);

        bool UpdateMemberBudget(MemberBuget memberBuget);
    }
}
