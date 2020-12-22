using System.Collections.Generic;

namespace DocMvc.Application.Abstractions
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();
        TEntity GetByCodigo(int codigo);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
