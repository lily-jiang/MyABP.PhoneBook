using Abp.Application.Services;
using MyABP.PhoneBook.MultiTenancy.Dto;

namespace MyABP.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

