using Abp.AspNetCore.Mvc.Controllers;
using Microsoft.AspNet.Identity;
using Abp.IdentityFramework;

namespace Test.Web.Controllers
{
    public abstract class TestControllerBase: AbpController
    {
        protected TestControllerBase()
        {
            LocalizationSourceName = TestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}