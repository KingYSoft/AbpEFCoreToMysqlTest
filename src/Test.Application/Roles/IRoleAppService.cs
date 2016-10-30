using System.Threading.Tasks;
using Abp.Application.Services;
using Test.Roles.Dto;

namespace Test.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
