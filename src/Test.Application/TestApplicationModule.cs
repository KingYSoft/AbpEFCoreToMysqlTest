using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Test.Authorization;

namespace Test
{
    [DependsOn(
        typeof(TestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class TestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<TestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}