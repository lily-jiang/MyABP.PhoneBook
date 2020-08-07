using System.Threading.Tasks;
using MyABP.PhoneBook.Configuration.Dto;

namespace MyABP.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
