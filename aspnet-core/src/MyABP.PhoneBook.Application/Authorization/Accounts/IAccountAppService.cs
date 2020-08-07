using System.Threading.Tasks;
using Abp.Application.Services;
using MyABP.PhoneBook.Authorization.Accounts.Dto;

namespace MyABP.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
