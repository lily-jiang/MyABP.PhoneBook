using System.Collections.Generic;
using MyABP.PhoneBook.Roles.Dto;

namespace MyABP.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
