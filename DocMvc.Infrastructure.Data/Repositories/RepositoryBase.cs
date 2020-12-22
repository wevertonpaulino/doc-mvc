using DocMvc.Domain.Abstractions.Repositories;
using DocMvc.Infrastructure.Data.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace DocMvc.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected DocumentoContext Db = new DocumentoContext();

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetByCodigo(int codigo)
        {
            return Db.Set<TEntity>().Find(codigo);
        }

        public void Add(TEntity entity)
        {
            Db.Set<TEntity>().Add(entity);
            Db.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            Db.Set<TEntity>().Remove(entity);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
