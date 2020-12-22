using System.Collections.Generic;

namespace DocMvc.Domain.Abstractions.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByCodigo(int codigo);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
