using Abp.MultiTenancy;
using MyABP.PhoneBook.Authorization.Users;

namespace MyABP.PhoneBook.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
