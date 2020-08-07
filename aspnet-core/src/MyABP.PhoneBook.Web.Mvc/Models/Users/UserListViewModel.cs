using System.Collections.Generic;
using MyABP.PhoneBook.Roles.Dto;

namespace MyABP.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
