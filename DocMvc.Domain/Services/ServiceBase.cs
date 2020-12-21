using DocMvc.Domain.Abstractions.Repositories;
using DocMvc.Domain.Abstractions.Services;
using System;
using System.Collections.Generic;

namespace DocMvc.Domain.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repositoryBase;

        public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
        {
            _repositoryBase = repositoryBase;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repositoryBase.GetAll();
        }

        public TEntity GetByCodigo(int codigo)
        {
            return _repositoryBase.GetByCodigo(codigo);
        }

        public void Add(TEntity entity)
        {
            _repositoryBase.Add(entity);
        }
        
        public void Update(TEntity entity)
        {
            _repositoryBase.Update(entity);
        }

        public void Remove(TEntity entity)
        {
            _repositoryBase.Remove(entity);
        }

        public void Dispose()
        {
            _repositoryBase.Dispose();
        }
    }
}
