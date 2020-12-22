using DocMvc.Application.Abstractions;
using DocMvc.Domain.Abstractions.Services;
using System;
using System.Collections.Generic;

namespace DocMvc.Application.Services
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetByCodigo(int codigo)
        {
            return _serviceBase.GetByCodigo(codigo);
        }
        public void Add(TEntity entity)
        {
            _serviceBase.Add(entity);
        }

        public void Update(TEntity entity)
        {
            _serviceBase.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _serviceBase.Remove(entity);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}
