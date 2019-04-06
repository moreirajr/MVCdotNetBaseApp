using System;
using System.Linq;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Domain.Entities.Base.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        void Update(TEntity obj);
        TEntity Delete(TEntity obj);

        TEntity GetById(Guid Id);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
