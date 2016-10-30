using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Test.EntityFramework.Repositories
{
    public abstract class TestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TestRepositoryBase(IDbContextProvider<TestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TestRepositoryBase<TEntity> : TestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TestRepositoryBase(IDbContextProvider<TestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
