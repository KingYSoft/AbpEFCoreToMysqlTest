using Abp.Authorization;
using Test.Authorization.Roles;
using Test.MultiTenancy;
using Test.Users;

namespace Test.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
