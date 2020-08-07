using System.Threading.Tasks;
using Abp.Application.Services;
using MyABP.PhoneBook.Sessions.Dto;

namespace MyABP.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
