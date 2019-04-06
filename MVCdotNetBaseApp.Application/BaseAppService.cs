using MVCdotNetBaseApp.Application.Interfaces;
using MVCdotNetBaseApp.Application.ViewModels;
using MVCdotNetBaseApp.Domain.Entities.Base;
using MVCdotNetBaseApp.Domain.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;


namespace MVCdotNetBaseApp.Application
{
    public abstract class BaseAppService<TEntity, TViewModel> : IBaseAppService<TEntity, TViewModel>
        where TEntity : BaseEntity
        where TViewModel : BaseViewModel, new()
    {
        private readonly IBaseService<TEntity> _baseService;
        protected BaseAppService(IBaseService<TEntity> baseService)
        {
            _baseService = baseService;
        }

        public virtual TViewModel Add(TViewModel viewModel)
        {
            viewModel.Id = viewModel.Id == Guid.Empty ? Guid.NewGuid() : viewModel.Id;
            var entity = AutoMapper.Mapper.Map<TEntity>(viewModel);

            _baseService.Add(entity);
            viewModel.Id = entity.Id;

            return viewModel;
        }

        public abstract TViewModel Update(TViewModel viewModel);

        public TViewModel Delete(Guid id)
        {
            return AutoMapper.Mapper.Map<TViewModel>(_baseService.Delete(id));
        }

        public IEnumerable<TViewModel> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var entity = _baseService.GetAll(filter);
            return AutoMapper.Mapper.Map<IEnumerable<TViewModel>>(entity);
        }

        public TViewModel GetById(Guid id)
        {
            var entity = _baseService.GetById(id);
            return AutoMapper.Mapper.Map<TViewModel>(entity);
        }
    }
}
