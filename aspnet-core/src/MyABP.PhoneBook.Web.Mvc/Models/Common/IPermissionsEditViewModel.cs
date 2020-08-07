using System.Collections.Generic;
using MyABP.PhoneBook.Roles.Dto;

namespace MyABP.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}