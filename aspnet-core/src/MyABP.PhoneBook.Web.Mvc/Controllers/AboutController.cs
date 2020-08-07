using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MyABP.PhoneBook.Controllers;

namespace MyABP.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
