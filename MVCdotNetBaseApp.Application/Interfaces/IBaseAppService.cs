using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Application.Interfaces
{
    public interface IBaseAppService<TEntity, TViewModel>
        where TEntity : class
        where TViewModel : class
    {
        TViewModel Add(TViewModel viewModel);

        TViewModel Update(TViewModel viewModel);

        TViewModel Delete(Guid id);

        TViewModel GetById(Guid id);

        IEnumerable<TViewModel> GetAll(Expression<Func<TEntity, bool>> filter = null);
    }
}