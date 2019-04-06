using MVCdotNetBaseApp.Data.Context;
using MVCdotNetBaseApp.Domain.Entities.Base.Interfaces;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Data.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected ApplicationDatabaseContext _dbContext;
        public BaseRepository(ApplicationDatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TEntity obj)
        {
            _dbContext.Set<TEntity>().Add(obj);
        }

        public void Update(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
        }

        public TEntity Delete(TEntity obj)
        {
            _dbContext.Entry(obj).State = EntityState.Modified;
            return _dbContext.Set<TEntity>().Remove(obj);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter != null)
                return _dbContext.Set<TEntity>().Where(filter);

            return _dbContext.Set<TEntity>();
        }

        public TEntity GetById(Guid Id)
        {
            return _dbContext.Set<TEntity>().Find(Id);
        }
    }
}
