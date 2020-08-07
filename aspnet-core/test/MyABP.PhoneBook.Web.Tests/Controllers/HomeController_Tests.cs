using System.Threading.Tasks;
using MyABP.PhoneBook.Models.TokenAuth;
using MyABP.PhoneBook.Web.Controllers;
using Shouldly;
using Xunit;

namespace MyABP.PhoneBook.Web.Tests.Controllers
{
    public class HomeController_Tests: PhoneBookWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}