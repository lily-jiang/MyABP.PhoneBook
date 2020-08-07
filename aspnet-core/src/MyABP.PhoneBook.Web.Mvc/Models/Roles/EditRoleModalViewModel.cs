using Abp.AutoMapper;
using MyABP.PhoneBook.Roles.Dto;
using MyABP.PhoneBook.Web.Models.Common;

namespace MyABP.PhoneBook.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
