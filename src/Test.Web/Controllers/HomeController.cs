using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Test.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TestControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}