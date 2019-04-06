using System;
using System.Linq;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Domain.Entities.Base.Interfaces
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity Update(TEntity obj);
        TEntity Delete(Guid Id);

        TEntity GetById(Guid Id);
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}
