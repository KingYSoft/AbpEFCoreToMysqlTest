using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using Microsoft.Extensions.Configuration;
using Test.Authorization.Roles;
using Test.Configuration;
using Test.MultiTenancy;
using Test.Users;
using Test.Web;

namespace Test.EntityFramework
{
    [DbConfigurationType(typeof(TestDbConfiguration))]
    public class TestDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        /* Default constructor is needed for EF command line tool. */
        public TestDbContext()
            : base(GetConnectionString())
        {

        }

        private static string GetConnectionString()
        {
            var configuration = AppConfigurations.Get(
                WebContentDirectoryFinder.CalculateContentRootFolder()
                );

            return configuration.GetConnectionString(
                TestConsts.ConnectionStringName
                );
        }

        /* This constructor is used by ABP to pass connection string.
         * Notice that, actually you will not directly create an instance of TestDbContext since ABP automatically handles it.
         */
        public TestDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        /* This constructor is used in tests to pass a fake/mock connection. */
        public TestDbContext(DbConnection dbConnection)
            : base(dbConnection, true)
        {

        }
    }

    public class TestDbConfiguration : DbConfiguration
    {
        public TestDbConfiguration()
        {
            SetProviderServices(
                "MySql.Data.MySqlClient",
            new MySql.Data.MySqlClient.MySqlProviderServices()
                );
            SetProviderFactory("MySql.Data.MySqlClient",
                MySql.Data.MySqlClient.MySqlClientFactory.Instance);
            SetDefaultConnectionFactory(new MySql.Data.Entity.MySqlConnectionFactory());
        }
    }
}
