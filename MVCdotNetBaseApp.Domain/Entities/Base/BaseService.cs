using MVCdotNetBaseApp.Domain.Entities.Base.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Domain.Entities.Base
{
    public abstract class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IBaseRepository<TEntity> _baseRepository;

        public BaseService(IBaseRepository<TEntity> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public abstract TEntity Add(TEntity obj);
        public abstract TEntity Update(TEntity obj);
        public abstract TEntity Delete(Guid id);

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _baseRepository.GetAll(filter);
        }

        public TEntity GetById(Guid id)
        {
            return _baseRepository.GetById(id);
        }
    }
}
