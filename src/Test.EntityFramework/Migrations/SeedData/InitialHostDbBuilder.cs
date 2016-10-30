using Test.EntityFramework;
using EntityFramework.DynamicFilters;

namespace Test.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TestDbContext _context;

        public InitialHostDbBuilder(TestDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
