using Abp.Authorization;
using MyABP.PhoneBook.Authorization.Roles;
using MyABP.PhoneBook.Authorization.Users;

namespace MyABP.PhoneBook.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
